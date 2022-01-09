import { Category } from './category';
export interface Product {
    id:number;
    name: string;
    price: number;
    categoryId: number;
    createDate:Date;
    status:boolean;
    category:Category;
}