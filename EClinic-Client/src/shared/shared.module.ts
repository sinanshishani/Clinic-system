import { NgModule, ModuleWithProviders } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutStoreService } from './layout/layout-store.service';
import { EqualValidator } from './directives/equal-validator.directive';
import { DigitsOnlyDirective } from './directives/digits-only.directive';



@NgModule({
  declarations: [EqualValidator, DigitsOnlyDirective],
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

