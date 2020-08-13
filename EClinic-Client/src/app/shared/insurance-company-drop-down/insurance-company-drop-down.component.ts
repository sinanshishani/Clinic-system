import { AppComponentBase } from 'src/shared/app-component-base';
import { Component, EventEmitter, Injector, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'insuranceDD',
  templateUrl: './insurance-company-drop-down.component.html',
  styleUrls: ['./insurance-company-drop-down.component.scss']
})
export class InsuranceCompanyDropDownComponent extends AppComponentBase implements OnInit {

  comapnies: any[] = [];

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
