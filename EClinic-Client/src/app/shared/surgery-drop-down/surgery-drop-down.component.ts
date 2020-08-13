import { AppComponentBase } from 'src/shared/app-component-base';
import { Component, EventEmitter, Injector, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'surgeryDD',
  templateUrl: './surgery-drop-down.component.html',
  styleUrls: ['./surgery-drop-down.component.scss']
})
export class SurgeryDropDownComponent extends AppComponentBase implements OnInit {

  surgeries: any[] = [];

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
