import { Component } from '@angular/core';
import { PainelExpansivelComponent } from '../../shared/components/painel-expansivel/painel-expansivel';
import { BotaoPainelComponent } from '../../shared/components/botao-painel/botao-painel';
import { MatExpansionModule } from '@angular/material/expansion';

@Component({
  selector: 'app-configuracoes',
  standalone: true,
  imports: [
    PainelExpansivelComponent,
    BotaoPainelComponent,
    MatExpansionModule
  ],
  templateUrl: './configuracoes.html',
  styleUrl: './configuracoes.css'
})
export class ConfiguracoesComponent {
  
}