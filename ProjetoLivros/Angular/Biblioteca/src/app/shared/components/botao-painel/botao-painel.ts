import { Component, EventEmitter, Output, Input } from '@angular/core';

@Component({
  selector: 'app-botao-painel',
  standalone: true,
  templateUrl: './botao-painel.html',
  styleUrl: './botao-painel.css'
})
export class BotaoPainelComponent {

  @Input() expandido: boolean = false;
  @Output() clicado = new EventEmitter<void>();

  clicar() {
    this.clicado.emit();
  }
}