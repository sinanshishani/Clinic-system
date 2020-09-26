import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { AllergiesLookupsComponent } from './allergies-lookups/allergies-lookups.component';
import { SystemLookupsComponent } from './system-lookups.component';

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
  ]
})
export class SystemLookupsModule { }
