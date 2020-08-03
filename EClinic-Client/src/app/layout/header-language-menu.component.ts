import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'header-language-menu',
  templateUrl: './header-language-menu.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush

})
export class HeaderLanguageMenuComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
