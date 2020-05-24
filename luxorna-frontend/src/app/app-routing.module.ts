import { NgModule } from '@angular/core';
import { SectionComponent } from './components/section/section.component';
import { RouterModule, Routes } from '@angular/router';
import { CommonModule } from '@angular/common';
import{MainComponent}from'./components/main/main.component'
import{AdminlayoutComponent}from './components/adminlayout/adminlayout.component';

import { LoginComponent } from './components/login/login.component';
import { PlacesComponent } from './components/places/places.component';
import { AddNewSectionComponent } from './components/add-new-section/add-new-section.component';
import { UpdatesectionComponent } from './components/updatesection/updatesection.component';
import { PreloadAllModules } from '@angular/router';
// const routes :Routes= [
//   {path:'updatesection',component: UpdatesectionComponent },
//     {path:'addsection',component: AddNewSectionComponent },
//   {path:'main',component: MainComponent},
//   {path:'login',component:LoginComponent},
//   {path:'adminlayout',component:AdminlayoutComponent},  
//   {path:'section',component: SectionComponent},
//   {path:'places',component:PlacesComponent},
//   /* تعديل علي section */ 
//   {path:'',redirectTo:'main',pathMatch:'full'}, 
// ] 

const routes :Routes = [
   
    { path: 'login', component: LoginComponent },
    { path: 'adminlayout', component: AdminlayoutComponent,
    children: [
        { path: '', redirectTo: 'login', pathMatch: 'full' },
        { path: 'main', component: MainComponent },
        {path:'section',component: SectionComponent},
  {path:'places',component:PlacesComponent},
   {path:'updatesection',component: UpdatesectionComponent },
    {path:'addsection',component: AddNewSectionComponent },
      ] },
 
    // otherwise redirect to home
    { path: '**', redirectTo: '/login' }
];
export const routing = RouterModule.forRoot(routes);
@NgModule({
  declarations: [],
  imports: [
    CommonModule,
     RouterModule.forRoot(routes)

    // RouterModule.forRoot(
    //   routes,
    //   {
    //     preloadingStrategy: PreloadAllModules
    //   }
    // )

      //  RouterModule.forChild(routes)

  ],
  exports:[RouterModule]

})

export class AppRoutingModule { }
