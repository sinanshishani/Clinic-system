import { NgModule, ModuleWithProviders } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutStoreService } from './layout/layout-store.service';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
})
export class SharedModule {
   static forRoot(): ModuleWithProviders<SharedModule> {
     return {
         ngModule: SharedModule,
         providers: [
//             //AppSessionService,
//             //AppUrlService,s
//             //AppAuthService,
//             //AppRouteGuard,
             LayoutStoreService
//             //DigitsOnlyDirective
         ]
     };
 }
 }

