import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Category } from '../models/category';
import { listResponseModel } from '../models/listResponseModel';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  apiUrl = "https://localhost:44379/api/Categories/GetAll";

  constructor(private httpClient: HttpClient) { }

  getCategories(): Observable<listResponseModel<Category>> {
    return this.httpClient.get<listResponseModel<Category>>(this.apiUrl)
  }
}
