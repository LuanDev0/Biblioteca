import { Component, OnInit, signal, computed } from '@angular/core';
import { Api } from '../../../services/api';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-prateleira',
  imports: [CommonModule],
  templateUrl: './prateleira.html',
  styleUrl: './prateleira.css',
})
export class Prateleira implements OnInit {

  listaGeneros = signal<any[]>([]);

  generosOrdenados = computed(() => {
    return [...this.listaGeneros()].sort((a, b) => 
      (a.nome || '').localeCompare(b.nome || '')
    );
  });

  constructor(private apiService: Api) { }

  ngOnInit() {
    this.apiService.getGeneros().subscribe({
      next: (dados) => {
        const lista = Array.isArray(dados) ? dados : [dados];
        this.listaGeneros.set(lista);
        console.log('Sinal atualizado!', this.listaGeneros());
      },
      error: (dados) => {
        console.log("Falha", dados);
      }
    });
  }
}