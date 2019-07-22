import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewAutoresComponent } from './view-autores.component';

describe('ViewAutoresComponent', () => {
  let component: ViewAutoresComponent;
  let fixture: ComponentFixture<ViewAutoresComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewAutoresComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewAutoresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
