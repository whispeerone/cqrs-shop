import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginPage } from './pages/login.page/login.page.component';

import { AdminPage } from './pages/admin.page/admin.page';
import { OrderPage } from './pages/order.page/order.page';
import { ProductListPage } from './pages/product-list.page/product-list.page';
import { ProductPage } from './pages/product.page/product.page';

const routes: Routes = [
	{
		path : "login",
		component : LoginPage 
	},
	{
		path : "product",
		component : ProductPage 
	},
	{
		path : "product-list",
		component : ProductListPage
	},
	{
		path : "order",
		component : OrderPage
	},
	{
		path : "admin",
		component : AdminPage 
	},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
