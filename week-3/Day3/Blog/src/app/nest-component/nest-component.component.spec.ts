import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NestComponentComponent } from './nest-component.component';

describe('NestComponentComponent', () => {
  let component: NestComponentComponent;
  let fixture: ComponentFixture<NestComponentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NestComponentComponent]
    });
    fixture = TestBed.createComponent(NestComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
