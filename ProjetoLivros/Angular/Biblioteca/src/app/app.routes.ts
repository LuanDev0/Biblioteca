import { Routes } from '@angular/router';
import { Inicio } from './components/pages/inicio/inicio';
import { Sobre } from './components/pages/sobre/sobre';
import { Prateleira } from './components/pages/prateleira/prateleira';

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
    path: '**',
    redirectTo: ''
    }

];
