import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './layout.component';
import { EjercicioEncriptacionComponent } from './pages/ejercicio-encriptacion/ejercicio-encriptacion.component';
import { EjercicioFibonacciComponent } from './pages/ejercicio-fibonacci/ejercicio-fibonacci.component';
import { EjercicioCrudComponent } from './pages/ejercicio-crud/ejercicio-crud.component';

const routes: Routes = [
  {
    path:'', 
    component: LayoutComponent,
    children: [
      {
        path: 'encriptacion',
        component: EjercicioEncriptacionComponent
      },
      {
        path: 'fibonacci',
        component: EjercicioFibonacciComponent
      },
      {
        path: 'crud',
        component: EjercicioCrudComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LayoutRoutingModule { }
