import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Comingsoon } from 'app/models/comingsoon.model';
import { ComingsoonsService } from 'app/services/comingsoons.service';



@Component({
  selector: 'app-edit-comingsoon',
  templateUrl: './edit-comingsoon.component.html',
  styleUrls: ['./edit-comingsoon.component.css']
})
export class EditComingsoonComponent implements OnInit {
  
  comingsoonDetails: Comingsoon = {
    id: '',
    name: '',
  };

  constructor(private route: ActivatedRoute, private comingsoonService: ComingsoonsService, private router: Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');

        if (id) {
          this.comingsoonService.getComingsoon(id)
          .subscribe({
            next: (response) => {
              this.comingsoonDetails = response;
            }
          });
        }
      }
    })
  }

  updateComingsoon() {
    this.comingsoonService.updateComingsoon(this.comingsoonDetails.id, this.comingsoonDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['comingsoons']);
      }
    });
  }

  deleteComingsoon(id: string) {
    this.comingsoonService.deleteComingsoon(id)
    .subscribe({
      next: (response) => {
        this.router.navigate(['comingsoons']);
      }
    });
  }

}
