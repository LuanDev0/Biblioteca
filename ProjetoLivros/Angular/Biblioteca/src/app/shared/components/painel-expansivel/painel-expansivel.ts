import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-painel-expansivel',
  standalone : true,
  imports: [],
  templateUrl: './painel-expansivel.html',
  styleUrls: ['./painel-expansivel.css'],
})
export class PainelExpansivelComponent {
  @Input() expandido: boolean = false;
}