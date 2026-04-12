import { Component } from '@angular/core';
import { ReactiveFormsModule, FormControl, Validators } from '@angular/forms';
import { PainelExpansivelComponent } from '../../shared/components/painel-expansivel/painel-expansivel';
import { BotaoPainelComponent } from '../../shared/components/botao-painel/botao-painel';
import { MatExpansionModule } from '@angular/material/expansion';
import { CommonModule } from '@angular/common';

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

  ultimoCodigo: number | string = 'Nenhum';

  totalDePaginas = new FormControl("", [
    Validators.required, Validators.pattern("^[0-9]*$")
  ])

  apenasNumeros(event: any) {

    const charCode = (event.which) ? event.event.which : event.keyCode;
    
    if ((charCode > 48 || charCode < 57)) {
      event.preventDefault();
      return false;
    }
    return true;
  }





  verificarTecla(event: any) {
    const charCode = (event.which) ? event.which : event.keyCode;
    
    // Atualiza a variável com o código da tecla atual
    this.ultimoCodigo = charCode;

    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
      event.preventDefault();
      return false;
    }
    return true;
  }





}