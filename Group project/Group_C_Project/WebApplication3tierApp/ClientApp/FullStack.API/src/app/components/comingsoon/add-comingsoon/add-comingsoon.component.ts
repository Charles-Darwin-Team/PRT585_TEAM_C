import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Comingsoon } from 'app/models/comingsoon.model';
import { ComingsoonsService } from 'app/services/comingsoons.service';

@Component({
  selector: 'app-add-comingsoon',
  templateUrl: './add-comingsoon.component.html',
  styleUrls: ['./add-comingsoon.component.css']
})
export class AddComingsoonComponent implements OnInit {

  addComingsoonRequest: Comingsoon = {
    id: '',
    name: '',
  };

  constructor(private comingsoonService: ComingsoonsService, private router: Router) { }

  ngOnInit(): void {
  }

  addComingsoon() {
    this.comingsoonService.addComingsoon(this.addComingsoonRequest)
    .subscribe({
      next: (comingsoon) => {
        this.router.navigate(['comingsoons']);
      }
    });
  }

}
