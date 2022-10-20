import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Movie } from 'app/models/movie.model';
import { MoviesService } from 'app/services/movies.service';



@Component({
  selector: 'app-edit-movie',
  templateUrl: './edit-movie.component.html',
  styleUrls: ['./edit-movie.component.css']
})
export class EditMovieComponent implements OnInit {
  
  movieDetails: Movie = {
    id: '',
    name: '',
  };

  constructor(private route: ActivatedRoute, private movieService: MoviesService, private router: Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');

        if (id) {
          this.movieService.getMovie(id)
          .subscribe({
            next: (response) => {
              this.movieDetails = response;
            }
          });
        }
      }
    })
  }

  updateMovie() {
    this.movieService.updateMovie(this.movieDetails.id, this.movieDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['movies']);
      }
    });
  }

  deleteMovie(id: string) {
    this.movieService.deleteMovie(id)
    .subscribe({
      next: (response) => {
        this.router.navigate(['movies']);
      }
    });
  }

}
