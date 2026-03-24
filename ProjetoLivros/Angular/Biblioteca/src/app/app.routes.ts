import { Routes } from '@angular/router';
import { Inicio } from './pages/inicio/inicio';
import { Sobre } from './pages/sobre/sobre';
import { Prateleira } from './pages/prateleira/prateleira';
import { ConfiguracoesComponent } from './pages/configuracoes/configuracoes';

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
        path: 'prateleira',
        component: Prateleira
    },

    {
        path: 'configuracoes',
        component: ConfiguracoesComponent
    },

    {
    path: '**',
    redirectTo: ''
    }

];
