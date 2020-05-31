import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable(({
  providedIn: 'root'
}) as any)
export class DataService {
  private baseUrl;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getContactsList(): Observable<Array<StoreModel>> {
    return this.http.get<Array<StoreModel>>(this.baseUrl + 'api/SampleData/getContacts');
  }

  getContact(id): Observable<StoreModel> {
    return this.http.get<StoreModel>(this.baseUrl + 'api/SampleData/getContact?id=' + id);
  }
}

