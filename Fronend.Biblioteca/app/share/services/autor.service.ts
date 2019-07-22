import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Autor } from '../clases/autor';
@Injectable({
  providedIn: 'root'
})
export class AutorService {

  private path: string = 'https://localhost:5001';

  constructor(private http: HttpClient) {
  }

  findALl(): Observable<Autor[]> {
    return this.http.get<Autor[]>(this.path + '/api/autor');
  }

  findById(autorId: string) {
    return this.http.get<Autor>(this.path + '/api/autor'+autorId);
  }


  addAutor(autor: Autor) {
    return this.http.post(this.path + '/api/autor', autor,
      httpOptions);
  }

  updateAutor(autor: Autor) {
    return this.http.put(this.path + '/api/autor', Autor,
      httpOptions);
  }

  deleteAutor(autorId: string) {
    return this.http.delete(this.path + '/api/autor/'+autorId);
  }
}
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};
