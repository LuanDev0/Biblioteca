import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core'; // Adicione este
import { provideRouter } from '@angular/router';
import { provideHttpClient, withFetch } from '@angular/common/http';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async'; 
import { routes } from './app.routes';
import { provideClientHydration, withEventReplay } from '@angular/platform-browser';

export const appConfig: ApplicationConfig = {
  providers: [
    // Isso aqui é CRUCIAL para o clique funcionar nas versões novas
    provideZoneChangeDetection({ eventCoalescing: true }), 
    
    provideRouter(routes),

    // Deixe apenas UM provideHttpClient
    provideHttpClient(withFetch()), 
    
    // Ignore o risco por enquanto, ele vai funcionar até a versão 23
    provideAnimationsAsync(), 
  ]
};