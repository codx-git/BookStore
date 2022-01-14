import type { AuditedEntityDto } from '@abp/ng.core';
import type { BookType } from './books/book-type.enum';

export interface BookDto extends AuditedEntityDto<string> {
  name?: string;
  type: BookType;
  publishDate?: string;
  price: number;
}
