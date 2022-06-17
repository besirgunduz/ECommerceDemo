import { ProductService } from './../../services/product.service';
import { Product } from './../../models/product';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  products: Product[] = [];
  dataLoaded = false;
  filterText = "";

  constructor(private productService: ProductService, private activatedRoute: ActivatedRoute, private toasterService: ToastrService) { }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(params => {
      if (params["categoryId"]) {
        this.getProductListByCategoryId(params["categoryId"])
      }
      else {
        this.getProducts()
      }
    })
  }

  getProducts() {
    this.productService.getProducts().subscribe((response) => {
      this.products = response.data;
      this.dataLoaded = true;
    })
  }

  getProductListByCategoryId(categoryId: number) {
    this.productService.getProductListByCategoryId(categoryId).subscribe((response) => {
      this.products = response.data;
      this.dataLoaded = true;
    })
  }

  addToCart(product: Product) {
    this.toasterService.success("Sepete eklendi",product.name)
  }

}
