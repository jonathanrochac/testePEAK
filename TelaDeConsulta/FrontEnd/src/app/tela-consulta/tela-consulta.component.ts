import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-consulta',
  templateUrl: './consulta.component.html',
  styleUrls: ['./consulta.component.css']
})
export class ConsultaComponent {
  id: number = 0;
  nome: string = '';
  erro: string = '';

  constructor(private http: HttpClient) { }

  buscar() {
    this.http.get<string>(`https://localhost:4200/api/consulta/${this.id}`)
      .subscribe(
        nome => this.nome = nome,
        error => this.erro = error.error
      );
  }
}
