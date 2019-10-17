import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'side-menu',
  templateUrl: './side-menu.html',
  styleUrls: ['./side-menu.scss']
})
export class SideMenu{

	isLoggedIn: boolean;

  	constructor() {
  		this.isLoggedIn = true;
  	}

}
