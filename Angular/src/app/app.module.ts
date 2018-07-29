import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { FinderComponent } from './finder/finder.component';
import { SearchComponent } from './finder/search/search.component';
import { SupervisorComponent } from './finder/supervisor/supervisor.component';
import { EmployeeComponent } from './finder/employee/employee.component';
import { EmployeeListComponent } from './finder/employee-list/employee-list.component';

@NgModule({
  declarations: [
    AppComponent,
    FinderComponent,
    SearchComponent,
    SupervisorComponent,
    EmployeeComponent,
    EmployeeListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
