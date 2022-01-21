import { ModuleWithProviders, NgModule } from '@angular/core';
import { BOOK_MODULE_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class BookModuleConfigModule {
  static forRoot(): ModuleWithProviders<BookModuleConfigModule> {
    return {
      ngModule: BookModuleConfigModule,
      providers: [BOOK_MODULE_ROUTE_PROVIDERS],
    };
  }
}
