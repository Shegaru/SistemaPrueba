import { Injectable } from '@angular/core';


import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs'; 
import { environment } from 'src/environments/environment';
import { ResponseApi } from '../Interfaces/response-api'; 
import { Fibonacci } from '../Interfaces/fibonacci';

@Injectable({
  providedIn: 'root'
})
export class FibonacciService {

  private urlApi:string = environment.endpoint + "Fibonacci/"

  constructor(private http:HttpClient) { }

  validaFibo(request : Fibonacci):Observable<ResponseApi>{
    return this.http.post<ResponseApi>(`${this.urlApi}validaFibo`, request)
  }
}
