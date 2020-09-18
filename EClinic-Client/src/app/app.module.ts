import { SharedModule } from './../shared/shared.module';
import { NgModule, APP_INITIALIZER } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { JwtModule } from "@auth0/angular-jwt";
import { HttpClientInMemoryWebApiModule } from 'angular-in-memory-web-api';
import { ClipboardModule } from 'ngx-clipboard';
import { TranslateModule } from '@ngx-translate/core';
import { InlineSVGModule } from 'ng-inline-svg';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AuthService } from './modules/auth/_services/auth.service';
import { FakeAPIService } from './_helpers/fake/fake-api.service';
import { environment } from 'src/environments/environment';
// Highlight JS
import { HighlightModule, HIGHLIGHT_OPTIONS } from 'ngx-highlightjs';
import highlight from 'highlight.js/lib/highlight';
import xml from 'highlight.js/lib/languages/xml';
import json from 'highlight.js/lib/languages/json';
import scss from 'highlight.js/lib/languages/scss';
import typescript from 'highlight.js/lib/languages/typescript';
import { SplashScreenModule } from './_metronic/partials/layout/splash-screen/splash-screen.module';
import { AppConsts } from '../shared/AppConsts';

function appInitializer(authService: AuthService) {
  return () => {
    return new Promise((resolve) => {
      authService.getUserByToken().subscribe().add(resolve);
    });
  };
}

/**
 * Import specific languages to avoid importing everything
 * The following will lazy load highlight.js core script (~9.6KB) + the selected languages bundle (each lang. ~1kb)
 */
export function getHighlightLanguages() {
  return [
    { name: 'typescript', func: typescript },
    { name: 'scss', func: scss },
    { name: 'xml', func: xml },
    { name: 'json', func: json },
  ];
}

export function tokenGetter() {
  return localStorage.getItem(AppConsts.authorization.encryptedAuthTokenName);
}

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    SplashScreenModule,
    TranslateModule.forRoot(),
    HttpClientModule,
    HighlightModule,
    ClipboardModule,
    environment.isMockEnabled
      ? HttpClientInMemoryWebApiModule.forRoot(FakeAPIService, {
          passThruUnknownUrl: true,
          dataEncapsulation: false,
        })
      : [],
    AppRoutingModule,
    InlineSVGModule.forRoot(),
    NgbModule,
    SharedModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        allowedDomains: [AppConsts.remoteServiceBaseUrl],
        disallowedRoutes: ["http://example.com/examplebadroute/"],
      },
    }),
  ],
  providers: [
    {
      provide: APP_INITIALIZER,
      useFactory: appInitializer,
      multi: true,
      deps: [AuthService],
    },
    {
      provide: HIGHLIGHT_OPTIONS,
      useValue: {
        languages: getHighlightLanguages,
      },
    },
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
