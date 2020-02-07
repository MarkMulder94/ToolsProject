import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppComponent } from "./app.component";
import { EmployeeComponent } from "./employee/employee.component";
import { EmployeeClient } from "./CleanArchitecture-api";
import { HttpClientModule, HttpClient } from "@angular/common/http";

@NgModule({
  declarations: [AppComponent, EmployeeComponent],
  imports: [BrowserModule, HttpClientModule],
  entryComponents: [EmployeeComponent],
  providers: [EmployeeClient, HttpClient],
  bootstrap: [AppComponent]
})
export class AppModule {}
