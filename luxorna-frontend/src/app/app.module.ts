import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{AdminlayoutComponent}from './components/adminlayout/adminlayout.component'
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { FormsModule } from '@angular/forms';
import { SectionComponent } from './components/section/section.component';
import { AppRoutingModule } from './app-routing.module';
import{MainComponent}from'./components/main/main.component';
import { PlacesComponent } from './components/places/places.component';
import { AddNewSectionComponent } from './components/add-new-section/add-new-section.component';
import { UpdatesectionComponent } from './components/updatesection/updatesection.component';
import { HomeComponent } from './components/home/home.component'

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    MainComponent,
    AdminlayoutComponent,
    SectionComponent,
    PlacesComponent,
    AddNewSectionComponent,
    UpdatesectionComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
