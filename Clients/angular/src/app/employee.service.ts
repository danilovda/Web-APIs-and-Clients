import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { IEmployeeModel } from './models/employee';

@Injectable({
  providedIn: 'root',
})
export class EmployeeService {
  constructor(private httpClient: HttpClient) {}

  //private baseUrl: string = 'http://127.0.0.1:3000';
  private baseUrl: string = 'http://localhost:5093';

  public getAllEmployee(): Observable<IEmployeeModel[]> {
    const url = `${this.baseUrl}/api/employees`;
    return this.httpClient.get<IEmployeeModel[]>(url);
  }

  public addEmployee(employee: IEmployeeModel): Observable<IEmployeeModel> {
    const url = `${this.baseUrl}/api/employees`;
    return this.httpClient.post<IEmployeeModel>(url, employee);
  }
}
