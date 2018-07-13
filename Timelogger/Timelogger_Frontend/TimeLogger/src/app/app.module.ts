import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { DaysViewerComponent } from './days-viewer/days-viewer.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    DaysViewerComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
