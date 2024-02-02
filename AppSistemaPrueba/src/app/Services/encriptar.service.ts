import { Injectable } from '@angular/core';


import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs'; 
import { environment } from 'src/environments/environment';
import { ResponseApi } from '../Interfaces/response-api'; 
import { Encriptar } from '../Interfaces/encriptar'; 

@Injectable({
  providedIn: 'root'
})
export class EncriptarService {

  private urlApi:string = environment.endpoint + "Encriptar/"

  constructor(private http:HttpClient) { }

  encriptaFrase(request : Encriptar):Observable<ResponseApi>{
    return this.http.post<ResponseApi>(`${this.urlApi}EncriptaFrase`, request)
  }
}  
