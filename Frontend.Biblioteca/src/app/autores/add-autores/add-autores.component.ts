import { Component, OnInit } from '@angular/core';

import { Autor} from 'src/app/share/clases/autor';
import { AutorService } from 'src/app/share/services/autor.service';
@Component({
  selector: 'app-add-autores',
  templateUrl: './add-autores.component.html',
  styleUrls: ['./add-autores.component.scss']
})
export class AddAutoresComponent implements OnInit {

  message:string='';
  autor: Autor;

  constructor(private service: AutorService) { }

  ngOnInit() {
    this.autor=new Autor;
  }

  procesarAutor(){
    console.log(this.autor);
    this.service.addAutor(this.autor).subscribe(
      data=>{
        this.message='Autor guardado con Exito !';
        this.autor=new Autor();
      },  
      error=>{
          console.log(error.error)
      }
    );     
  }
}
