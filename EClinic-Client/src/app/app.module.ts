import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './layout/header.component';
import { FooterComponent } from './layout/footer.component';
import { HeaderLanguageMenuComponent } from './layout/header-language-menu.component';
import { HeaderLeftNavbarComponent } from './layout/header-left-navbar.component';
import { HeaderUserMenuComponent } from './layout/header-user-menu.component';
import { SidebarLogoComponent } from './layout/sidebar-logo.component';
import { SidebarMenuComponent } from './layout/sidebar-menu.component';
import { SidebarUserPanelComponent } from './layout/sidebar-user-panel.component';
import { SidebarComponent } from './layout/sidebar.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    HeaderLanguageMenuComponent,
    HeaderLeftNavbarComponent,
    HeaderUserMenuComponent,
    SidebarLogoComponent,
    SidebarMenuComponent,
    SidebarUserPanelComponent,
    SidebarComponent,
  ],
  imports: [
    CommonModule,
    AppRoutingModule
  ],
  providers: [],
})
export class AppModule { }
