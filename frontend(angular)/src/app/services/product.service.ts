import { Product } from './../models/product';
import { listResponseModel } from './../models/listResponseModel';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  apiUrl = "https://localhost:44379/api/Products/GetAll";

  constructor(private httpClient: HttpClient) { }

  getProducts(): Observable<listResponseModel<Product>> {
    return this.httpClient.get<listResponseModel<Product>>(this.apiUrl)
  }
}
