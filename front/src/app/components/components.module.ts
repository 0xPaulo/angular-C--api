import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { HomeComponent } from '../screens/home/home.component';
import { ComponentsRoutingModule } from './components-routing.module';

@NgModule({
  declarations: [HomeComponent],
  imports: [CommonModule, ComponentsRoutingModule, HttpClientModule],
  exports: [HomeComponent],
})
export class ComponentsModule {}
