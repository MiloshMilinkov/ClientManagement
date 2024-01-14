import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee.model';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.scss']
})
export class EmployeesListComponent implements OnInit{

  employees: Employee[] = [
    {
      id: '1-a',
      firstName: 'Boban',
      lastName: 'Bobanovic',
      email: 'boban@gmail.com',
      phone:'+381999183573',
      salary: 1600,
      department: 'Human Resources'
    },
    {
      id: '1-b',
      firstName: 'Marko',
      lastName: 'Markov',
      email: 'marko@gmail.com',
      phone:'+381642383583',
      salary: 2200,
      department: 'Development'
    }
  ];

  constructor(){

  }

  ngOnInit(): void {
  }
  
}
