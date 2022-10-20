import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Movie } from 'app/models/movie.model';
import { MoviesService } from 'app/services/movies.service';

@Component({
  selector: 'app-add-movie',
  templateUrl: './add-movie.component.html',
  styleUrls: ['./add-movie.component.css']
})
export class AddMovieComponent implements OnInit {

  addMovieRequest: Movie = {
    id: '',
    name: '',
  };

  constructor(private movieService: MoviesService, private router: Router) { }

  ngOnInit(): void {
  }

  addMovie() {
    this.movieService.addMovie(this.addMovieRequest)
    .subscribe({
      next: (movie) => {
        this.router.navigate(['movies']);
      }
    });
  }

}
