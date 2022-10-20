import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddMovieComponent } from './components/movies/add-movie/add-movie.component';
import { EditMovieComponent } from './components/movies/edit-movie/edit-movie.component';
import { MoviesListComponent } from './components/movies/movies-list/movies-list.component';

const routes: Routes = [
  {
    path: '',
    component: MoviesListComponent
  },
  {
    path: 'movies',
    component: MoviesListComponent
  },
  {
    path: 'movies/add',
    component: AddMovieComponent 
  },
  {
    path: 'movies/edit/:id',
    component: EditMovieComponent 
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
