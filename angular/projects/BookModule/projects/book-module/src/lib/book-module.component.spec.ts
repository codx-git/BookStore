import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { BookModuleComponent } from './book-module.component';

describe('BookModuleComponent', () => {
  let component: BookModuleComponent;
  let fixture: ComponentFixture<BookModuleComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ BookModuleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BookModuleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
