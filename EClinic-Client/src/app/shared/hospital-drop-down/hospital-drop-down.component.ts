import { AppComponentBase } from 'src/shared/app-component-base';
import { Component, EventEmitter, Injector, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'hospitalDD',
  templateUrl: './hospital-drop-down.component.html',
  styleUrls: ['./hospital-drop-down.component.scss']
})
export class HospitalDropDownComponent extends AppComponentBase implements OnInit {

  hospitals: any[] = [];

  @Input() showNoneOption: boolean = true;
  @Input() selected:string;

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
