import { Component, OnInit, Inject } from '@angular/core';
import { Libro } from 'src/app/share/clases/libro';
import { LibroService } from 'src/app/share/services/libro.service';
import {MatTableDataSource} from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';
import { ViewDetailLibroComponent } from '../view-detail-libro/view-detail-libro.component';
import { AddLibroComponent } from '../add-libro/add-libro.component';

@Component({
  selector: 'app-view-libros',
  templateUrl: './view-libros.component.html',
  styleUrls: ['./view-libros.component.scss']
})
export class ViewLibrosComponent implements OnInit {

  libros :Libro[];
  autor: string="";
  categoria: string="";
  nombre: string="";

  displayedColumns: string[] = ['nombre', 'autor', 'ISBN','actions'];
  dataSource = new MatTableDataSource<Libro>();

  constructor(private service : LibroService,public dialog: MatDialog) { }

  ngOnInit() {
    this.actualizar();
  }
  
  deleteLibro(libroId){
    this.service.deleteLibro(libroId).subscribe(
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
        this.libros=datos;       
        this.dataSource.data=this.libros;
      },error =>{
         console.log(error);
      }
    );  
  }

  find(){
    this.service.find(this.nombre,this.categoria,this.autor).subscribe(
      datos => {
        this.libros=datos;       
        this.dataSource.data=this.libros;
      },error =>{
         console.log(error);
      }
    );  
  }

  openDialog(libro: Libro) {
    this.dialog.open(ViewDetailLibroComponent,{
      data: libro   
    });
  }
}

