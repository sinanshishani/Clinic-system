import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { AllergiesLookupsComponent } from './allergies-lookups/allergies-lookups.component';
import { SystemLookupsComponent } from './system-lookups.component';
import {NgbDropdownModule} from '@ng-bootstrap/ng-bootstrap';

const routes: Routes = [
  {
    path: '',
    component: SystemLookupsComponent,
  },
  {
    path: 'allergies',
    component: AllergiesLookupsComponent
  }
  ];

@NgModule({
  declarations: [SystemLookupsComponent, AllergiesLookupsComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    NgbDropdownModule,
  ]
})
export class SystemLookupsModule { }
