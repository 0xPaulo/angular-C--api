import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, of } from 'rxjs';
import { Pessoa } from '../interfaces/pessoa';

@Injectable({
  providedIn: 'root',
})
export class PessoasService {
  urlApi = 'http://localhost:5008/pessoas';

  getAllPessoas(): Observable<Pessoa[]> {
    return this.http.get<Pessoa[]>(`${this.urlApi}`).pipe(
      catchError(() => {
        return of([]);
      })
    );
  }

  constructor(private http: HttpClient) {}
}
