import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EjercicioEncriptacionComponent } from './ejercicio-encriptacion.component';

describe('EjercicioEncriptacionComponent', () => {
  let component: EjercicioEncriptacionComponent;
  let fixture: ComponentFixture<EjercicioEncriptacionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EjercicioEncriptacionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EjercicioEncriptacionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
