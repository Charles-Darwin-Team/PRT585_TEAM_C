import { Component, OnInit } from '@angular/core';
import { Movie } from 'app/models/movie.model';
import { MoviesService } from 'app/services/movies.service';

@Component({
  selector: 'app-movies-list',
  templateUrl: './movies-list.component.html',
  styleUrls: ['./movies-list.component.css']
})
export class MoviesListComponent implements OnInit {

  movies: Movie[] = [];
  constructor(private moviesService: MoviesService) { }

  ngOnInit(): void {
    this.moviesService.getAllMovies()
    .subscribe({
      next: (movies) => {
        this.movies = movies;
      },
      error: (response) => {
        console.log(response);
      }
    });
    
  }

}
