import { Component, OnInit } from "@angular/core";
import { EmployeeClient, Employee } from "../CleanArchitecture-api";

@Component({
  selector: "app-employee",
  templateUrl: "./employee.component.html",
  styleUrls: ["./employee.component.css"]
})
export class EmployeeComponent implements OnInit {
  public werknemers: Employee[] = [];
  constructor(private client: EmployeeClient) {
    client.getAllEmployees().subscribe(response => {
      this.werknemers = response;
      console.log(response);
    });
  }

  ngOnInit() {}
}
