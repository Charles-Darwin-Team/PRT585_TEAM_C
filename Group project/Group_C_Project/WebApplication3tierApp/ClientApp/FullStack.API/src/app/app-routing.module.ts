import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import {BrowserModule} from '@angular/platform-browser';
import {CommonModule} from '@angular/common';

import { AddMovieComponent } from './components/movies/add-movie/add-movie.component';
import { EditMovieComponent } from './components/movies/edit-movie/edit-movie.component';
import { MoviesListComponent } from './components/movies/movies-list/movies-list.component';
import { ComingsoonsListComponent } from './components/comingsoon/comingsoon-list/comingsoons-list.component';
import { AddComingsoonComponent } from './components/comingsoon/add-comingsoon/add-comingsoon.component';
import { EditComingsoonComponent } from './components/comingsoon/edit-comingsoon/edit-comingsoon.component';

const routes: Routes = [
 
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
  },
  {
    path: 'comingsoons',
    component: ComingsoonsListComponent
  },
  {
    path: 'comingsoons/add',
    component: AddComingsoonComponent 
  },
  {
    path: 'comingsoons/edit/:id',
    component: EditComingsoonComponent 
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes), BrowserModule, CommonModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
