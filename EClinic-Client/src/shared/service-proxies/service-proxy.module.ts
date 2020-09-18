import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import * as ApiServiceProxies from './service-proxies';
import { API_BASE_URL } from './service-proxies';
import { AppConsts } from '../AppConsts';

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
    ApiServiceProxies.HospitalsServiceProxy,
    { provide: API_BASE_URL, useFactory: () => AppConsts.remoteServiceBaseUrl },
]
})
export class ServiceProxyModule { }
