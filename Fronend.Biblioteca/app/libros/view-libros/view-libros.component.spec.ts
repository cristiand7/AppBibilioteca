import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewLibrosComponent } from './view-libros.component';

describe('ViewLibrosComponent', () => {
  let component: ViewLibrosComponent;
  let fixture: ComponentFixture<ViewLibrosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewLibrosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewLibrosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
