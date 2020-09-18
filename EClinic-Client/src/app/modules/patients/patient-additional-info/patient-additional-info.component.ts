import { Component, OnInit, Output, Injector, EventEmitter } from '@angular/core';

@Component({
  selector: 'patientAdditionalInfo',
  templateUrl: './patient-additional-info.component.html',
  styleUrls: ['./patient-additional-info.component.scss']
})
export class PatientAdditionalInfoComponent implements OnInit {

  @Output() closeEvent = new EventEmitter<any>();

  familyDis = [{value: 1, text: "Diabetes"}, {value: 2, text: "Blood Preasure"}, {value: 3, text: "Alzheimer's"}];

  familyDisSelcted: any;
  fmaiyDisList = [];

  constructor(Injector: Injector) {
   }

  ngOnInit(): void {
  }

  newDis(){
    if(this.familyDisSelcted != undefined && this.familyDisSelcted != 0 && this.familyDisSelcted != -1){
      console.log(this.familyDisSelcted)
      let x = this.familyDis.filter(a => a.value == this.familyDisSelcted)[0];
      if(x){
        this.fmaiyDisList.push(x);
        let index = this.familyDis.indexOf(x);
        this.familyDis.splice(index,1);
        this.familyDisSelcted = null;
      }
    }
  }

  removeItem(value){
    let x = this.fmaiyDisList.filter(a => a.value == value)[0];

    if(x){
      this.familyDis.push(x);
        let index = this.fmaiyDisList.indexOf(x);
        this.fmaiyDisList.splice(index,1);
        this.familyDisSelcted = null;
    }
  }

  closeSection(){
    this.closeEvent.emit();
  }

}
