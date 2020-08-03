import { SharedModule } from './../../shared/shared.module';
import { Component, OnInit, Injector, ChangeDetectionStrategy } from '@angular/core';
import { AppComponentBase } from './../../shared/app-component-base';
import { appModuleAnimation } from './../../shared/animations/routerTransition';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
  animations: [appModuleAnimation()],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class HomeComponent extends AppComponentBase implements OnInit {

  constructor(injector : Injector) { 
    super(injector);
  }

  ngOnInit(): void {
  }

}
