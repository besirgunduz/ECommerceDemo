import { CategoryService } from './../../services/category.service';
import { Category } from './../../models/category';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  categories: Category[] = [];
  currentCategory: Category;
  currentCategory2: Category;
  constructor(private categoryService: CategoryService) { }

  ngOnInit(): void {
    this.getCategories();
  }

  getCategories() {
    this.categoryService.getCategories().subscribe((response) => {
      this.categories = response.data;
    })
  }

  setCurrentCategory(category: Category) {
    this.currentCategory = category;
  }

  setCurrentCategory2() {
    this.currentCategory=this.currentCategory2;
  }

  getCurrentCategoryClass(category: Category) {
    if (category == this.currentCategory) {
      return "list-group-item active"
    } else {
      return "list-group-item"
    }
  }

  getAllCategoryClass() {
    if (!this.currentCategory) {
      return "list-group-item active";
    }
    else {
      return "list-group-item";
    }
  }

}
