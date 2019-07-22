import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Categoria } from '../clases/categoria';
@Injectable({
  providedIn: 'root'
})
export class CategoriaService {

  private path: string = 'https://localhost:5001';

  constructor(private http: HttpClient) {
  }



  findALl(): Observable<Categoria[]> {
    return this.http.get<Categoria[]>(this.path + '/api/categoria');
  }

  findById(categoriaId: string) {
    return this.http.get<Categoria[]>(this.path + '/api/categoria'+categoriaId);
  }


  addCategoria(categoria: Categoria) {
    return this.http.post(this.path + '/api/categoria', categoria,
      httpOptions);
  }

  updateCategoria(categoria: Categoria) {
    return this.http.put(this.path + '/api/categoria', categoria,
      httpOptions);
  }

  deleteCategoria(categoriaId: string) {
    return this.http.delete(this.path + '/api/categoria/'+categoriaId);
  }
}
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
    //   ,'Authorization': 'my-auth-token'
  })
};