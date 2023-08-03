import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class RecordsService {
  info1: string[]=["Drashti Sataki","354" , "drashti@gmail.com"];
  info2: string[]=["Rushi Sheth","353" , "rushi@gmail.com"];
  info3: string[]=["Anushka Saxena", "234", "anushka@gmail.com"]

  getInfo1(): string[]{
    return this.info1
  }
  getInfo2(): string[]{
    return this.info2
  }
  getInfo3(): string[]{
    return this.info3
  }
  constructor() { }
}
