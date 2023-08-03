import { Injectable } from '@angular/core';
import { MyServiceService } from './my-service.service';

@Injectable({
  providedIn: 'root'
})
export class ChildServiceService extends MyServiceService{
  override getMessage(): string {
    return 'This is the overridden child service message';
  }
}
