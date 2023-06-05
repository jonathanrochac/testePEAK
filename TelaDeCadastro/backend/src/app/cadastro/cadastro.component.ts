import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.css']
})
export class CadastroComponent {
  parcelas: number = 0;
  valor: number = 0;
  resultado: number = 0;

  constructor(private http: HttpClient) { }

  salvar() {
    const data = {
      parcelas: this.parcelas,
      valor: this.valor
    };

    this.http.post<any>('http://localhost:5000/api/calculo', data).subscribe(response => {
      this.resultado = response.resultado;
    });
  }
}
