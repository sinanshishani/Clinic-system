import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import * as ApiServiceProxies from './service-proxies';

@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
  providers: [
    ApiServiceProxies.AccountServiceProxy,
    ApiServiceProxies.AccountSurgeriesServiceProxy,
    ApiServiceProxies.AccountSurgeryProceduresServiceProxy,
    ApiServiceProxies.PatientsServiceProxy,
    ApiServiceProxies.HospitalsServiceProxy
]
})
export class ServiceProxyModule { }
