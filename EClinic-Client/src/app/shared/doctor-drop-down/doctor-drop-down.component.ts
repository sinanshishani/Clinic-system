import { Component, EventEmitter, Injector, Input, OnInit, Output } from '@angular/core';
import { AppComponentBase } from 'src/shared/app-component-base';

@Component({
  selector: 'doctorDD',
  templateUrl: './doctor-drop-down.component.html',
  styleUrls: ['./doctor-drop-down.component.scss']
})
export class DoctorDropDownComponent extends AppComponentBase implements OnInit {

  doctors: any[] = [];

  @Input() showNoneOption: boolean = true;
  @Input() selected:string;
  @Input() slectedHospital:string;

  @Output() selectedChange = new EventEmitter<string>();

  constructor(injector: Injector) {
    super(injector);
   }

  ngOnInit(): void {

  }

  changeValue(){
    console.log(this.selected);
    this.selectedChange.emit(this.selected);
  }

}
