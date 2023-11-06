import { AfterViewInit, Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { IEmployeeModel } from '../models/employee';
import { EmployeeService } from '../employee.service';
import { Observable, firstValueFrom } from 'rxjs';

@Component({
  selector: 'app-employee-list',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.scss'],
})
export class EmployeeListComponent implements AfterViewInit {
  public employeeForm = new FormGroup({
    firstName: new FormControl('', Validators.required),
    lastName: new FormControl('', Validators.required),
  });

  public data$?: Observable<IEmployeeModel[]>;

  constructor(private employeeService: EmployeeService) {}

  ngAfterViewInit(): void {
    this.refresh();
  }

  refresh(): void {
    this.data$ = this.employeeService.getAllEmployee();
  }

  async addEmployee() {
    const newEmployee: IEmployeeModel = {
      firstName: this.employeeForm.value.firstName ?? '',
      lastName: this.employeeForm.value.lastName ?? '',
    };
    await firstValueFrom(this.employeeService.addEmployee(newEmployee));
    this.refresh();
    this.employeeForm.reset();
  }
}
