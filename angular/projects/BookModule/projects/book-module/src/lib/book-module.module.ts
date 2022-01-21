import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { BookModuleComponent } from './components/book-module.component';
import { BookModuleRoutingModule } from './book-module-routing.module';

@NgModule({
  declarations: [BookModuleComponent],
  imports: [CoreModule, ThemeSharedModule, BookModuleRoutingModule],
  exports: [BookModuleComponent],
})
export class BookModuleModule {
  static forChild(): ModuleWithProviders<BookModuleModule> {
    return {
      ngModule: BookModuleModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<BookModuleModule> {
    return new LazyModuleFactory(BookModuleModule.forChild());
  }
}
