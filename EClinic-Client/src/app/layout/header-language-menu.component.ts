import { AppComponentBase } from 'src/shared/app-component-base';
import { Component, OnInit, ChangeDetectionStrategy, Injector } from '@angular/core';

@Component({
  selector: 'header-language-menu',
  templateUrl: './header-language-menu.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush

})
export class HeaderLanguageMenuComponent extends AppComponentBase implements OnInit {

  constructor(injector: Injector) {
    super(injector);
   }

  ngOnInit(): void {
  }

}
