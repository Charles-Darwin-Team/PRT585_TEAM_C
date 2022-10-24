import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Observable } from 'rxjs';
import { Comingsoon } from '../models/comingsoon.model';

@Injectable({
  providedIn: 'root'
})
export class ComingsoonsService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }


  getAllComingsoons(): Observable<Comingsoon[]> {
    return this.http.get<Comingsoon[]>(this.baseApiUrl + '/api/comingsoon');
  }

  addComingsoon(addComingsoonRequest: Comingsoon): Observable<Comingsoon> {
    addComingsoonRequest.id = '0';
    return this.http.post<Comingsoon>(this.baseApiUrl + '/api/comingsoon', addComingsoonRequest);
  }

  getComingsoon(id: string): Observable<Comingsoon> {
    return this.http.get<Comingsoon>(this.baseApiUrl + '/api/comingsoon/' + id);
  }

  updateComingsoon(id: string, updateComingsoonRequest: Comingsoon): Observable<Comingsoon> {
    return this.http.put<Comingsoon>(this.baseApiUrl + '/api/comingsoon/' + id, updateComingsoonRequest);
  }

  deleteComingsoon(id: string): Observable<Comingsoon> {
    return this.http.delete<Comingsoon>(this.baseApiUrl + '/api/comingsoon/' + id);
  }

}
