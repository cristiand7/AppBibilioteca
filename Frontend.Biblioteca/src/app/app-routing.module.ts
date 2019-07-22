import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ViewLibrosComponent } from './libros/view-libros/view-libros.component';
import { ViewCategoriasComponent } from './categorias/view-categorias/view-categorias.component';
import { ViewAutoresComponent } from './autores/view-autores/view-autores.component';
import { AddAutoresComponent } from './autores/add-autores/add-autores.component';
import { AddCategoriasComponent } from './categorias/add-categorias/add-categorias.component';
import { AddLibroComponent } from './libros/add-libro/add-libro.component';
import { ViewDetailLibroComponent } from './libros/view-detail-libro/view-detail-libro.component';


const routes: Routes = [
  {path: 'home', component: HomeComponent },
  {path: 'libros/view-detail-libros', component: ViewDetailLibroComponent },
  {path: 'libros/view-libros', component: ViewLibrosComponent },
  {path: 'libros/add-libros', component: AddLibroComponent },
  {path: 'categorias/view-categorias', component: ViewCategoriasComponent },
  {path: 'categorias/add-categorias', component: AddCategoriasComponent  },
  {path: 'autores/view-autores', component: ViewAutoresComponent },
  {path: 'autores/add-autores', component: AddAutoresComponent },
  {path: '', pathMatch: 'full', redirectTo: 'home'},//por defecto
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
