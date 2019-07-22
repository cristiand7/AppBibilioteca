import { Injectable } from '@angular/core';
import { Libro } from '../clases/libro';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class LibroService {

  private path: string = 'https://localhost:5001';

  constructor(private http: HttpClient) {
  }

  findALl(): Observable<Libro[]> {
    return this.http.get<Libro[]>(this.path + '/api/libro');
  }

  find(nombre: string,categoria:string,autor: string): Observable<Libro[]> {
    return this.http.get<Libro[]>(this.path + '/api/libro'+
      '?nombre='+nombre+'&categoria='+categoria+'&autor='+autor);
  }

  findById(libroId: string) {
    return this.http.get<Libro[]>(this.path + '/api/libro'+libroId);
  }


  addLibro(libro: Libro) {
    return this.http.post(this.path + '/api/libro', libro,
      httpOptions);
  }

  updateLibro(libro: Libro) {
    return this.http.put(this.path + '/api/libro', libro,
      httpOptions);
  }

  deleteLibro(libroId: string) {
    return this.http.delete(this.path + '/api/libro/'+libroId);
  }

}

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
    //   ,'Authorization': 'my-auth-token'
  })
};
