import { Routes } from '@angular/router';
import { Inicio } from './components/pages/inicio/inicio';
import { Sobre } from './components/pages/sobre/sobre';

export const routes: Routes = [

    {
        path: '',
        component : Inicio
    },

    {
        path: 'sobre',
        component: Sobre
    },

    {
    path: '**',
    redirectTo: ''
    }

];
