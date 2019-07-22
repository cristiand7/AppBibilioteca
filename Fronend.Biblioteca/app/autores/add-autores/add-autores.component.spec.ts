import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddAutoresComponent } from './add-autores.component';

describe('AddAutoresComponent', () => {
  let component: AddAutoresComponent;
  let fixture: ComponentFixture<AddAutoresComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddAutoresComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddAutoresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
