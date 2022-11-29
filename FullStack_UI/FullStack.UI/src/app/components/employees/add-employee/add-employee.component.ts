import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {
  addEmployeeRequest: Employee = {
    id: "ddddd",
      name: ' John Smith',
      email: 'john@generator.com',
      phone: 11111,
      salary: 133333,
      department: 'Home department'
  }
  constructor() { }

  ngOnInit(): void {
  }

}
