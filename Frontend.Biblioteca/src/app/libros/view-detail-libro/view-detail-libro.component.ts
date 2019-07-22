import { Component, OnInit, Inject } from '@angular/core';
import {MAT_DIALOG_DATA} from '@angular/material/dialog';
import { Libro } from 'src/app/share/clases/libro';


@Component({
  selector: 'app-view-detail-libro',
  templateUrl: './view-detail-libro.component.html',
  styleUrls: ['./view-detail-libro.component.scss']
})
export class ViewDetailLibroComponent implements OnInit {


  constructor(@Inject(MAT_DIALOG_DATA) public data: Libro) {}
  
  ngOnInit() {
  }

}
