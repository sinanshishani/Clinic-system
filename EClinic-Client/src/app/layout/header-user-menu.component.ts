import { Component, ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'header-user-menu',
  templateUrl: './header-user-menu.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush

})
export class HeaderUserMenuComponent {

  constructor() { }

  logout(): void {
    //this._authService.logout();
  }

}
