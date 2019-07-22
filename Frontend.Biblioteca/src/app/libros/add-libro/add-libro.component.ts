import { Component, OnInit } from '@angular/core';
import { LibroService } from 'src/app/share/services/libro.service';
import { Libro } from 'src/app/share/clases/libro';
import { Categoria } from 'src/app/share/clases/categoria';
import { Autor } from 'src/app/share/clases/autor';
import { AutorService } from 'src/app/share/services/autor.service';
import { CategoriaService } from 'src/app/share/services/categoria.service';

@Component({
  selector: 'app-add-libro',
  templateUrl: './add-libro.component.html',
  styleUrls: ['./add-libro.component.scss']
})
export class AddLibroComponent implements OnInit {
  message:string='';
  libro: Libro;
  categorias: Categoria[];
  categoriasSeleccionadas: string[];
  autores: Autor[];
  constructor(private service:LibroService,private autorService:AutorService,
    private categoriaService:CategoriaService) { }

  ngOnInit() {
    this.libro=new Libro();
    this.libro.listaCategorias=[];
    
    this.autorService.findALl().subscribe(
      datos => {
        this.autores=datos;       
      },error =>{
         console.log(error);
      }
    );  
    this.categoriaService.findALl().subscribe(
      datos => {
        this.categorias=datos;       
      },error =>{
         console.log(error);
      }
    );
  }

  procesar(){
    this.categoriasSeleccionadas.forEach(element => {
      var cat=new Categoria();
      cat.id=element;
      this.libro.listaCategorias.push(cat);
    });
    this.service.addLibro(this.libro).subscribe(
      data=>{
        this.message='Libro guardado con Exito !';
        this.libro=new Libro();
        this.libro.listaCategorias=[];
        this.categoriasSeleccionadas=[];
      },  
      error=>{
          console.log(error.error)
      }
    );     
  } 
}
