import { Component, OnInit, Input } from '@angular/core';
import { IProductView } from '../../models/models';

@Component({
  selector: 'product-view',
  templateUrl: './product-view.component.html',
  styleUrls: ['./product-view.component.scss']
})
export class ProductView {

	@Input()
	product : IProductView;

  	constructor() {
  	}

}
