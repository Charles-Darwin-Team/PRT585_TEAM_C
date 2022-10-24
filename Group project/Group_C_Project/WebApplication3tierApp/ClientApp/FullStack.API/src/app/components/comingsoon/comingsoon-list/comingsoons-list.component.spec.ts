import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComingsoonsListComponent } from './comingsoons-list.component';

describe('ComingsoonsListComponent', () => {
  let component: ComingsoonsListComponent;
  let fixture: ComponentFixture<ComingsoonsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComingsoonsListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ComingsoonsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
