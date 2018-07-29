import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions, RequestMethod, Jsonp, BaseRequestOptions } from '@angular/http';
import { Observable } from 'rxjs';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';

import {Employee} from './employee.model';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  SearchID : String;
  selectedEmployee : Employee;
  supervisorList : Employee[];
  employeeList : Employee[];
  constructor(private http : Http) { }

  getSupervisor(emailID : String){
    this.http.get('http://localhost:52472/api/Employees/' + emailID +'/')
    .map((data : Response) => {
      return data.json() as Employee[];
    }).toPromise().then(x => {
      this.supervisorList = x;
    })
    this.http.get('http://localhost:52472/api/Employees/Get/' + emailID +'/')
    .map((data : Response) => {
      return data.json() as Employee[];
    }).toPromise().then(x => {
      this.employeeList = x;
      this.selectedEmployee = this.employeeList[0];
    })
  }

  getEmployeeList(supervisorID : number){
    this.http.get('http://localhost:52472/api/Employees/GetEmployees/' + supervisorID +'/')
    .map((data : Response) => {
      return data.json() as Employee[];
    }).toPromise().then(x => {
      this.employeeList = x;
    })
  }

}
