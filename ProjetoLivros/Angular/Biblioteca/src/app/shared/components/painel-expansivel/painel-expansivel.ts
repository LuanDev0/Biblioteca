import { Component, input } from '@angular/core';
import { MatExpansionModule } from '@angular/material/expansion';

@Component({
  selector: 'app-painel-expansivel',
  standalone: true,
  imports: [MatExpansionModule],
  templateUrl: './painel-expansivel.html',
  styleUrl: './painel-expansivel.css'
})
export class PainelExpansivelComponent {
  // Usando a nova API de Inputs do Angular (mais moderna)
  titulo = input.required<string>();
  descricao = input<string>(''); // Opcional
}