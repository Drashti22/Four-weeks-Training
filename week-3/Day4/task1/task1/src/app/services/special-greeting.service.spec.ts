import { TestBed } from '@angular/core/testing';

import { SpecialGreetingService } from './special-greeting.service';

describe('SpecialGreetingService', () => {
  let service: SpecialGreetingService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SpecialGreetingService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
