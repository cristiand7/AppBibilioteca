import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddCategoriasComponent } from './add-categorias.component';

describe('AddCategoriasComponent', () => {
  let component: AddCategoriasComponent;
  let fixture: ComponentFixture<AddCategoriasComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddCategoriasComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddCategoriasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
