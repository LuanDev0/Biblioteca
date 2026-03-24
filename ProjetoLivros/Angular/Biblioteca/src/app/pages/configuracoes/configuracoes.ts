import { Component } from '@angular/core';
import { PainelExpansivelComponent } from '../../shared/components/painel-expansivel/painel-expansivel';
import { BotaoPainelComponent } from '../../shared/components/botao-painel/botao-painel';

@Component({
  selector: 'app-configuracoes',
  standalone: true,
  imports: [
    PainelExpansivelComponent,
    BotaoPainelComponent
  ],
  templateUrl: './configuracoes.html'
})
export class ConfiguracoesComponent {
  expandido = false;
  larguraPainel = 200;

  togglePainel() {
    this.expandido = !this.expandido;
    this.larguraPainel = this.expandido ? 325 : 200;
  }
}