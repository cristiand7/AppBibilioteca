import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateAutoresComponent } from './update-autores.component';

describe('UpdateAutoresComponent', () => {
  let component: UpdateAutoresComponent;
  let fixture: ComponentFixture<UpdateAutoresComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UpdateAutoresComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateAutoresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
