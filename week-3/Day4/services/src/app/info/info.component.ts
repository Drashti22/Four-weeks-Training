import { Component } from '@angular/core';
import  {DataService} from "../data.service";

@Component({
  selector: 'app-info',
  templateUrl: './info.component.html',
  styleUrls: ['./info.component.css'],
  providers: [DataService]
})
export class InfoComponent {
  infoReceived1:string[]=[];
  infoReceived2:string[]=[];
  infoReceived3:string[]=[];

  getInfoFromService1(){
    this.infoReceived1=this.dService.getInfo1();
  }
  
  getInfoFromService2(){
    this.infoReceived2=this.dService.getInfo2();
  
  }
  
  getInfoFromService3(){
    this.infoReceived3=this.dService.getInfo3();
  }
  constructor(private dService: DataService){}
  updateInfo(frm: any){
    this.dService.addInfo(frm.value.location)
  }
}
