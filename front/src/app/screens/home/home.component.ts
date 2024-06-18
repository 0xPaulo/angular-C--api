import { Component } from '@angular/core';
import { Pessoa } from 'src/app/interfaces/pessoa';
import { PessoasService } from 'src/app/services/pessoas.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  pessoas: Pessoa[] = [];

  constructor(private pessoaService: PessoasService) {}

  getPessoas() {
    this.pessoaService
      .getAllPessoas()
      .subscribe((resultado) => (this.pessoas = resultado));
  }
}
