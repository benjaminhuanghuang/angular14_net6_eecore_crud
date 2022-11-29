import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';
import { EmployeesService } from 'src/app/services/employees.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  employees: Employee[] = [];
  // [{
  //   id: "ddddd",
  //   name: ' John Smith',
  //   email: 'john@generator.com',
  //   phone: 11111,
  //   salary: 133333,
  //   department: 'Home department'
  // }];

  constructor(private employeesService: EmployeesService) { }

  ngOnInit(): void {
    this.employeesService.getAllEmployee().subscribe({
      next:( employees) => {
        this.employees = employees;
      },
      error:(err) =>{

      }
    })
  }

}
