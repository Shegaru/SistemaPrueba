import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LayoutRoutingModule } from './layout-routing.module';
import { EjercicioEncriptacionComponent } from './pages/ejercicio-encriptacion/ejercicio-encriptacion.component';
import { EjercicioFibonacciComponent } from './pages/ejercicio-fibonacci/ejercicio-fibonacci.component';
import { EjercicioCrudComponent } from './pages/ejercicio-crud/ejercicio-crud.component';
import { SharedModule } from 'src/app/Reutilizable/shared/shared.module';


@NgModule({
  declarations: [
    EjercicioEncriptacionComponent,
    EjercicioFibonacciComponent,
    EjercicioCrudComponent
  ],
  imports: [
    CommonModule,
    LayoutRoutingModule,

    SharedModule
  ]
})
export class LayoutModule { }
