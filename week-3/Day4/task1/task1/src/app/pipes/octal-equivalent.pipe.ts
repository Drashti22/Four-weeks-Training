import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'octalEquivalent'
})
export class OctalEquivalentPipe implements PipeTransform {

  transform(value: number): string {
    return value.toString(8);
  }

}
