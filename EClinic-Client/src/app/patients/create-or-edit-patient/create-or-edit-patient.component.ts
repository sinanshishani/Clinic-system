import { Component, Injector, OnInit } from '@angular/core';
import { AppComponentBase } from 'src/shared/app-component-base';

@Component({
  selector: 'create-or-edit-patient',
  templateUrl: './create-or-edit-patient.component.html',
  styleUrls: ['./create-or-edit-patient.component.scss']
})
export class CreateOrEditPatientComponent extends AppComponentBase implements OnInit {

  constructor(injector: Injector) {
    super(injector);
   }

  ngOnInit(): void {
  }

}
