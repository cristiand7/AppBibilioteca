import { Component, OnInit } from '@angular/core';
import { Categoria } from 'src/app/share/clases/categoria';
import { CategoriaService } from 'src/app/share/services/categoria.service';

@Component({
  selector: 'app-add-categorias',
  templateUrl: './add-categorias.component.html',
  styleUrls: ['./add-categorias.component.scss']
})
export class AddCategoriasComponent implements OnInit {
  message:string='';
  categoria: Categoria;

  constructor(private service: CategoriaService) { }

  ngOnInit() { 
    this.categoria=new Categoria();
  }

  procesarAutor(){
    this.service.addCategoria(this.categoria).subscribe(
      data=>{
        this.message='Categoria guardada con Exito !';
        this.categoria=new Categoria();
      },  
      error=>{
          console.log(error.error)
      }
    );     
  }
}
