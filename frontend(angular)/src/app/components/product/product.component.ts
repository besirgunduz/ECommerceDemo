import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  product = { productId: 1, productName: "Kitap1", categoryId: 1 };
  product2 = { productId: 2, productName: "Kitap2", categoryId: 1 };
  product3 = { productId: 3, productName: "Kitap3", categoryId: 1 };
  product4 = { productId: 4, productName: "Kitap4", categoryId: 1 };
  product5 = { productId: 5, productName: "Kitap5", categoryId: 1 };

  products = [this.product, this.product2, this.product3, this.product4, this.product5];

  constructor() { }

  ngOnInit(): void {
  }

}
