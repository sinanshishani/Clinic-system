import { AppRouteGuard } from './../shared/auth/auth-route-guard';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { PatientsComponent } from './patients/patients.component';
import { CreateOrEditPatientComponent } from './patients/create-or-edit-patient/create-or-edit-patient.component';

const routes: Routes = [
  {
      path: '',
      component: AppComponent,
      children: [
          { path: 'home', component: HomeComponent,  /*canActivate: [AppRouteGuard] */},
          { path: 'patients', component: PatientsComponent },
          { path: 'patients/:id', component : CreateOrEditPatientComponent },
          { path: 'patients/add', component : CreateOrEditPatientComponent},
          // { path: 'users', component: UsersComponent, data: { permission: 'Pages.Users' },/*canActivate: [AppRouteGuard] */},
          // { path: 'roles', component: RolesComponent, data: { permission: 'Pages.Roles' }, /*canActivate: [AppRouteGuard] */ },
          // { path: 'tenants', component: TenantsComponent, data: { permission: 'Pages.Tenants' }, /*canActivate: [AppRouteGuard] */ },
          // { path: 'about', component: AboutComponent },
          // { path: 'update-password', component: ChangePasswordComponent },
          // {
          //     path: 'patients',
          //     loadChildren: () => import('app/patients/patients.module').then(m => m.PatientsModule), // Lazy load account module
          //     data: { preload: true }
          // },
          // {
          //     path: 'operations',
          //     loadChildren: () => import('app/operations-management/operations-management.module').then(m => m.OperationsManagementModule), // Lazy load account module
          //     data: { preload: true }
          // }
      ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
