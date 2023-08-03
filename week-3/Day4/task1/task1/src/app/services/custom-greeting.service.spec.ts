import { TestBed } from '@angular/core/testing';

import { CustomGreetingService } from './custom-greeting.service';

describe('CustomGreetingService', () => {
  let service: CustomGreetingService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CustomGreetingService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
