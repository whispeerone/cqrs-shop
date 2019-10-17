import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginPage } from './pages/login.page/login.page.component';
import { SideMenu } from './components/side-menu/side-menu';
import { ProductView } from './components/product-view/product-view.component';

import { AdminPage } from './pages/admin.page/admin.page';
import { OrderPage } from './pages/order.page/order.page';
import { ProductListPage } from './pages/product-list.page/product-list.page';
import { ProductPage } from './pages/product.page/product.page';


@NgModule({
  declarations: [
    AppComponent,
    LoginPage,
    SideMenu,
    ProductPage,
    ProductListPage,
    OrderPage,
    AdminPage,
    ProductView
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
