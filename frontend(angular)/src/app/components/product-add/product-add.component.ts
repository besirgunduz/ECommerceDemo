import { ToastrService } from 'ngx-toastr';
import { ProductService } from './../../services/product.service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms'

@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html',
  styleUrls: ['./product-add.component.css']
})
export class ProductAddComponent implements OnInit {

  productAddForm: FormGroup;
  constructor(private formBuilder: FormBuilder,
    private productService: ProductService,
    private toastrService: ToastrService) { }

  ngOnInit(): void {
    this.createProductAddForm();
  }

  createProductAddForm() {
    this.productAddForm = this.formBuilder.group({
      name: ["", Validators.required],
      price: ["", Validators.required],
      categoryId: ["", Validators.required]
    })
  }

  add() {
    debugger;
    if (this.productAddForm.valid) {

      let productModel = Object.assign({}, this.productAddForm.value);
      this.productService.add(productModel).subscribe(response => {
        this.toastrService.success(response.message, "Başarılı")
      },

        responseError => {
          if (responseError.error.Errors.length > 0) {
            for (let i = 0; i < responseError.error.Errors.length; i++) {
              this.toastrService.error(responseError.error.Errors[i].ErrorMessage, "Doğrulama hatası");

            }
          }
        });

    } else {
      this.toastrService.error("Formunuz eksik.", "Dikkat")
    }

  }

}
