import { Injectable } from '@angular/core';

import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs'; 
import { environment } from 'src/environments/environment';
import { ResponseApi } from '../Interfaces/response-api'; 
import { Encriptado } from '../Interfaces/encriptado';

@Injectable({
  providedIn: 'root'
})
export class EncriptadoService {

  private urlApi:string = environment.endpoint + "Encriptado/"

  constructor(private http:HttpClient) { }

  lista():Observable<ResponseApi>{
    return this.http.get<ResponseApi>(`${this.urlApi}lista`)
  }

  guardar(request : Encriptado):Observable<ResponseApi>{
    return this.http.post<ResponseApi>(`${this.urlApi}Guardar`, request)
  }
}
