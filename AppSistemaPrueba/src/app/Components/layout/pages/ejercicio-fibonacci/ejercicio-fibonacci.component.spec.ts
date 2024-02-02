import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EjercicioFibonacciComponent } from './ejercicio-fibonacci.component';

describe('EjercicioFibonacciComponent', () => {
  let component: EjercicioFibonacciComponent;
  let fixture: ComponentFixture<EjercicioFibonacciComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EjercicioFibonacciComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EjercicioFibonacciComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
