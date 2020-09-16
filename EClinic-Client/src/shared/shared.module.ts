import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ServiceProxyModule } from './service-proxies/service-proxy.module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
  exports:[
    ServiceProxyModule
  ]
})
export class SharedModule { }
