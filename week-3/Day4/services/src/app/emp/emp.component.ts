import { Component } from '@angular/core';
import { RecordsService } from '../records.service';

@Component({
  selector: 'app-emp',
  templateUrl: './emp.component.html',
  styleUrls: ['./emp.component.css'],
  providers: [RecordsService]
})
export class EmpComponent {
  infoReceived1:string[]=[];
  infoReceived2:string[]=[];
  infoReceived3:string[]=[];
  getInfoFromService1(){
    this.infoReceived1=this.rService.getInfo1();
  }
  
  getInfoFromService2(){
    this.infoReceived2=this.rService.getInfo2();
  
  }

  getInfoFromService3(){
    this.infoReceived3=this.rService.getInfo3();
  }

  constructor(private rService: RecordsService){

  }
}
