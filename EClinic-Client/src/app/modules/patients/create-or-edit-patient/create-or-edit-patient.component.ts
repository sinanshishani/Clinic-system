import { Component, Injector, OnInit } from '@angular/core';
import { MatDatepickerInputEvent } from '@angular/material/datepicker';
import { ActivatedRoute, Router } from '@angular/router';
import {Location} from '@angular/common';
import { ELEMENT_DATA, PatientDto } from './../patients.component';


@Component({
  selector: 'app-create-or-edit-patient',
  templateUrl: './create-or-edit-patient.component.html',
  styleUrls: ['./create-or-edit-patient.component.scss']
})
export class CreateOrEditPatientComponent implements OnInit {

  title: string = "Add Patient";

  showAdditionalInfo: boolean = false;

  referenceNumber: number;
  nationalId: string;
  name: string;
  selectedSex: number;
  fileNumber: string;
  phoneNumber: string;
  doctorId: string;
  emailAdress: string;
  isInsured: boolean;

  patient: PatientDto;


  id: number;

  constructor(injector: Injector,
    private route: ActivatedRoute,
    private router: Router,
    private _location: Location) {
   }

  ngOnInit(): void {
    this.id = +this.route.snapshot.paramMap.get('id');

    if(this.id && this.id !== 0){
      this.title = "Edit patient";
      this.patient = ELEMENT_DATA.filter(a => a.refernceNumber == this.id)[0];

    }else{
      this.patient = {};
      this.patient.refernceNumber = ELEMENT_DATA.length + 1;
    }
  }

  createPatient(){
    if(this.patient.doctorId == 1){
      this.patient.physician = "سعد جابر";
    }else{
      this.patient.physician = "مأمون المومني";
    }

    ELEMENT_DATA.push(this.patient);
    this.router.navigateByUrl('app/patients');
  }

  addEvent( event: MatDatepickerInputEvent<Date>) {
    this.patient.birthdate = event.value;
  }

  toggleAdditionalInfo(){
    this.showAdditionalInfo = !this.showAdditionalInfo;
  }

}
