import { Injectable } from '@angular/core';

import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs'; 
import { environment } from 'src/environments/environment';
import { ResponseApi } from '../Interfaces/response-api'; 
import { Desencriptar } from '../Interfaces/desencriptar';

@Injectable({
  providedIn: 'root'
})
export class DesencriptarService {

  private urlApi:string = environment.endpoint + "Desencriptar/"

  constructor(private http:HttpClient) { }

  desencriptaFrase(request : Desencriptar):Observable<ResponseApi>{
    return this.http.post<ResponseApi>(`${this.urlApi}DesencriptaFrase`, request)
  }
}
