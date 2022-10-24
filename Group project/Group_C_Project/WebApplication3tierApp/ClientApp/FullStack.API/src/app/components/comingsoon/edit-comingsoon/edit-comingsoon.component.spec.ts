import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditComingsoonComponent } from './edit-comingsoon.component';

describe('EditComingsoonComponent', () => {
  let component: EditComingsoonComponent;
  let fixture: ComponentFixture<EditComingsoonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditComingsoonComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditComingsoonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
