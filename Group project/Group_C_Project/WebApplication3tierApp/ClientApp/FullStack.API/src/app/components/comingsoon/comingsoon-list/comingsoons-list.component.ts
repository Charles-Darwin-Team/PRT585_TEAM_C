import { Component, OnInit } from '@angular/core';
import { Comingsoon } from 'app/models/comingsoon.model';
import { ComingsoonsService } from 'app/services/comingsoons.service';

@Component({
  selector: 'app-comingsoons-list',
  templateUrl: './comingsoons-list.component.html',
  styleUrls: ['./comingsoons-list.component.css']
})
export class ComingsoonsListComponent implements OnInit {

  comingsoons: Comingsoon[] = [];
  constructor(private comingsoonsService: ComingsoonsService) { }

  ngOnInit(): void {
    this.comingsoonsService.getAllComingsoons()
    .subscribe({
      next: (comingsoons) => {
        this.comingsoons = comingsoons;
      },
      error: (response) => {
        console.log(response);
      }
    });
    
  }

}
