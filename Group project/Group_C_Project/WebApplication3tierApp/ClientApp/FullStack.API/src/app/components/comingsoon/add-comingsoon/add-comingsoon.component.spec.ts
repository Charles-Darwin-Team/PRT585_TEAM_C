import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddComingsoonComponent } from './add-comingsoon.component';

describe('AddComingsoonComponent', () => {
  let component: AddComingsoonComponent;
  let fixture: ComponentFixture<AddComingsoonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddComingsoonComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddComingsoonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
