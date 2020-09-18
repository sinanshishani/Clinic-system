import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CreateOrEditPatientComponent } from './create-or-edit-patient/create-or-edit-patient.component';
import { PatientsComponent } from './patients.component';

const routes: Routes = [
  {
    path: '',
    component: PatientsComponent,
  },
  { 
    path: ':id',
     component : CreateOrEditPatientComponent
  },
  { path: 'add',
   component : CreateOrEditPatientComponent
  },
  {
    path: '**',
    redirectTo: 'form-controls/autocomplete',
    pathMatch: 'full',
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PatientsRoutingModule { }
