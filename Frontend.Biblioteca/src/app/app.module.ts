import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { UpdateLibroComponent } from './libros/update-libro/update-libro.component';
import { AddLibroComponent } from './libros/add-libro/add-libro.component';
import { ViewLibrosComponent } from './libros/view-libros/view-libros.component';
import { ViewCategoriasComponent } from './categorias/view-categorias/view-categorias.component';
import { ViewAutoresComponent } from './autores/view-autores/view-autores.component';
import { AddAutoresComponent } from './autores/add-autores/add-autores.component';
import { UpdateAutoresComponent } from './autores/update-autores/update-autores.component';
import { UpdateCategoriasComponent } from './categorias/update-categorias/update-categorias.component';
import { AddCategoriasComponent } from './categorias/add-categorias/add-categorias.component';
import { MenuComponent } from './menu/menu.component';
import { LibroService } from './share/services/libro.service';
import {MatTableModule} from '@angular/material/table'; 
import {MatMenuModule} from '@angular/material/menu'; 
import { MatListModule } from '@angular/material/list';
import { HttpClientModule } from '@angular/common/http';
import { CategoriaService } from './share/services/categoria.service';
import { AutorService } from './share/services/autor.service';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
//selection

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    UpdateLibroComponent,
    AddLibroComponent,
    ViewLibrosComponent,
    ViewCategoriasComponent,
    ViewAutoresComponent,
    AddAutoresComponent,
    UpdateAutoresComponent,
    UpdateCategoriasComponent,
    AddCategoriasComponent,
    MenuComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatTableModule,
    HttpClientModule,
    MatMenuModule,
    ReactiveFormsModule,
    FormsModule,
    BrowserAnimationsModule ,
    MatListModule
  ],
  providers: [
    LibroService
    ,AutorService,
    CategoriaService]
    ,
  bootstrap: [AppComponent]
})
export class AppModule { }
