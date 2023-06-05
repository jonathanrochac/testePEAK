import { Component } from '@angular/core';


@Component({
  selector: 'app-tela-cadastro',
  templateUrl: './tela-cadastro.component.html',
  styleUrls: ['./tela-cadastro.component.css']
})
export class TelaCadastroComponent {
  parcelas: number = 0;
  valor: number = 0;
  resultado: number = 0;

  salvar() {
    console.log('Botão Salvar clicado');
  
    // Verifica se as parcelas e o valor são números válidos
    if (isNaN(this.parcelas) || isNaN(this.valor)) {
      console.log('Parcelas e valor devem ser números válidos');
      return;
    }
  
    // Faz o cálculo do resultado
    this.resultado = this.parcelas * this.valor;
  
  }
}  