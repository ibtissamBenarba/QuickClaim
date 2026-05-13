import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class ExpenseService {
  // Check your backend port in Program.cs or launchSettings.json
  private apiUrl = 'https://localhost:7292/api/expenses'; 

  constructor(private http: HttpClient) {}

  getExpenses(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }

  createExpense(expense: any): Observable<any> {
    return this.http.post<any>(this.apiUrl, expense);
  }
}