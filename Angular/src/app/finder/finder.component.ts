import { Component, OnInit } from '@angular/core';

import { EmployeeService } from './shared/employee.service';

@Component({
  selector: 'app-finder',
  templateUrl: './finder.component.html',
  styleUrls: ['./finder.component.css'],
  providers: [EmployeeService]
})
export class FinderComponent implements OnInit {

  constructor(private employeeService : EmployeeService) {  }

  ngOnInit() {
  }

}
