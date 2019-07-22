import { Component, OnInit } from '@angular/core';
import {MatTableDataSource} from '@angular/material/table';
import { Autor } from 'src/app/share/clases/autor';
import { AutorService } from 'src/app/share/services/autor.service';

@Component({
  selector: 'app-view-autores',
  templateUrl: './view-autores.component.html',
  styleUrls: ['./view-autores.component.scss']
})
export class ViewAutoresComponent implements OnInit {

  displayedColumns: string[] = ['nombres', 'apellidos','fechaNacimiento','actions'];
  dataSource = new MatTableDataSource<Autor>();
  autores: Autor[];

  constructor(private service : AutorService) { }
  
  ngOnInit() {
    this.actualizar();
  }
  deleteAutor(autorId: string){
    this.service.deleteAutor(autorId).subscribe(
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
        this.autores=datos;       
        this.dataSource.data=this.autores;
      },error =>{
         console.log(error);
      }
    );  
  }
}
