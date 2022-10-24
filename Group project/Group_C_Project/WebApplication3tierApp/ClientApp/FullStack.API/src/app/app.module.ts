import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';

import { MoviesListComponent } from './components/movies/movies-list/movies-list.component';
import { AddMovieComponent } from './components/movies/add-movie/add-movie.component';
import { EditMovieComponent } from './components/movies/edit-movie/edit-movie.component';
import { ComingsoonsListComponent } from './components/comingsoon/comingsoon-list/comingsoons-list.component';
import { AddComingsoonComponent } from './components/comingsoon/add-comingsoon/add-comingsoon.component';
import { EditComingsoonComponent } from './components/comingsoon/edit-comingsoon/edit-comingsoon.component';

@NgModule({
  declarations: [
    AppComponent,
    MoviesListComponent,
    AddMovieComponent,
    EditMovieComponent,
    ComingsoonsListComponent,
    AddComingsoonComponent,
    EditComingsoonComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
