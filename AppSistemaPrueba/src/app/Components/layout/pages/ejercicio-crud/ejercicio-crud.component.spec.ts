import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EjercicioCrudComponent } from './ejercicio-crud.component';

describe('EjercicioCrudComponent', () => {
  let component: EjercicioCrudComponent;
  let fixture: ComponentFixture<EjercicioCrudComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EjercicioCrudComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EjercicioCrudComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
