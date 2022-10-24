import { TestBed } from '@angular/core/testing';

import { ComingsoonsService } from './comingsoons.service';

describe('ComingsoonsService', () => {
  let service: ComingsoonsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ComingsoonsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
