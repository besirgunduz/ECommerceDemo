import { ResponseModel } from './../models/responseModel';
import { Product } from './../models/product';
import { listResponseModel } from './../models/listResponseModel';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  apiUrl = "https://localhost:44379/api/";

  constructor(private httpClient: HttpClient) { }

  getProducts(): Observable<listResponseModel<Product>> {
    let newPath=this.apiUrl+"Products/GetAll";
    return this.httpClient.get<listResponseModel<Product>>(newPath)
  }

  getProductListByCategoryId(categoryId: number): Observable<listResponseModel<Product>> {
    let newPath=this.apiUrl+"Products/GetProductListByCategoryId?categoryId="+categoryId;
    return this.httpClient.get<listResponseModel<Product>>(newPath)
  }

  add(product:Product):Observable<ResponseModel>{
    return this.httpClient.post<ResponseModel>(this.apiUrl+"Products/Add",product) //hangi adrese ne göndereyim
  }

}
