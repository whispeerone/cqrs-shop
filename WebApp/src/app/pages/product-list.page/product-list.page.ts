import { Component, OnInit } from '@angular/core';
import { IProductView } from '../../models/models';

@Component({
  selector: 'product-list.page',
  templateUrl: './product-list.page.html',
  styleUrls: ['./product-list.page.scss']
})

export class ProductListPage implements OnInit {

	products : IProductView[] = [];

  	constructor() { 

  		this.products.push({title: "sd", count : 2,  descr : "dasdadvk ksdkcdsk kwedk "});
  		this.products.push({title: "sd1", count : 3,  descr : "1dasdadvk ksdkcdsk kwedk "});
  		this.products.push({title: "sd2", count : 4,  descr : "2dasdadvk ksdkcdsk kwedk "});
  		this.products.push({title: "sd3", count : 5,  descr : "3dasdadvk ksdkcdsk kwedk "});
  		this.products.push({title: "sd4", count : 6,  descr : "4dasdadvk ksdkcdsk kwedk "});
  	}

  	ngOnInit() {
  	}

  	addToCart(item){

  	}

  	

}
