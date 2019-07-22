import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewDetailLibroComponent } from './view-detail-libro.component';

describe('ViewDetailLibroComponent', () => {
  let component: ViewDetailLibroComponent;
  let fixture: ComponentFixture<ViewDetailLibroComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewDetailLibroComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewDetailLibroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
