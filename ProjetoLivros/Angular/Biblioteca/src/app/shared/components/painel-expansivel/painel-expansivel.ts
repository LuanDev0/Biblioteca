import { Component } from '@angular/core';

@Component({
  selector: 'app-painel-expansivel',
  standalone : true,
  imports: [],
  templateUrl: './painel-expansivel.html',
  styleUrls: ['./painel-expansivel.css'],
})
export class PainelExpansivel {
  expandido = false;

  toggle() {
    this.expandido = !this.expandido;
  }
}