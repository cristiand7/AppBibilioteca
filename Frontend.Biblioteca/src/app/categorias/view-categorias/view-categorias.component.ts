import { Component, OnInit } from '@angular/core';
import {MatTableDataSource} from '@angular/material/table';
import { Categoria } from 'src/app/share/clases/categoria';
import { CategoriaService } from 'src/app/share/services/categoria.service';

@Component({
  selector: 'app-view-categorias',
  templateUrl: './view-categorias.component.html',
  styleUrls: ['./view-categorias.component.scss']
})
export class ViewCategoriasComponent implements OnInit {
  categorias :Categoria[];

  constructor(private service : CategoriaService) { }

  displayedColumns: string[] = ['nombre', 'descripcion','actions'];
  dataSource = new MatTableDataSource<Categoria>();
  
  ngOnInit() {
    this.actualizar();
  }

  deleteCategoria(categoriaId: string){
    this.service.deleteCategoria(categoriaId).subscribe(
      datos => {
        this.actualizar();
      },error =>{
         console.log(error);
      }
    );
  }
  actualizar(){
    this.service.findALl().subscribe(
      datos => {
        this.categorias=datos;       
        this.dataSource.data=this.categorias;
      },error =>{
         console.log(error);
      }
    );  

  }
}
