import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { Observable } from 'rxjs';
import { Movie } from '../models/movie.model';

@Injectable({
  providedIn: 'root'
})
export class MoviesService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }


  getAllMovies(): Observable<Movie[]> {
    return this.http.get<Movie[]>(this.baseApiUrl + '/api/movie');
  }

  addMovie(addMovieRequest: Movie): Observable<Movie> {
    addMovieRequest.id = '0';
    return this.http.post<Movie>(this.baseApiUrl + '/api/movie', addMovieRequest);
  }

  getMovie(id: string): Observable<Movie> {
    return this.http.get<Movie>(this.baseApiUrl + '/api/movie/' + id);
  }

  updateMovie(id: string, updateMovieRequest: Movie): Observable<Movie> {
    return this.http.put<Movie>(this.baseApiUrl + '/api/movie/' + id, updateMovieRequest);
  }

  deleteMovie(id: string): Observable<Movie> {
    return this.http.delete<Movie>(this.baseApiUrl + '/api/movie/' + id);
  }

}
