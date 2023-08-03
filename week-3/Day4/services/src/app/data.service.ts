import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {
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
  addInfo(info : string){
    this.info1.push(info)
    this.info2.push(info)
    this.info3.push(info)
    return this.info1
  }
  constructor() { }
}
