import { TestBed } from '@angular/core/testing';

import { BookModuleService } from './book-module.service';

describe('BookModuleService', () => {
  let service: BookModuleService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BookModuleService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
