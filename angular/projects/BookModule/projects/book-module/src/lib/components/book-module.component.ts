import { Component, OnInit } from '@angular/core';
import { BookModuleService } from '../services/book-module.service';

@Component({
  selector: 'lib-book-module',
  template: ` <p>book-module works!</p> `,
  styles: [],
})
export class BookModuleComponent implements OnInit {
  constructor(private service: BookModuleService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
