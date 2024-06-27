import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatChipsModule } from '@angular/material/chips';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatTableModule } from '@angular/material/table';
import { HomeComponent } from '../screens/home/home.component';
import { ComponentsRoutingModule } from './components-routing.module';
import { TableComponent } from './table/table.component';

@NgModule({
  declarations: [HomeComponent, TableComponent],
  imports: [
    MatTableModule,
    MatInputModule,
    MatFormFieldModule,
    MatChipsModule,
    MatButtonModule,
    CommonModule,
    ComponentsRoutingModule,
    HttpClientModule,
    MatCardModule,
  ],
  exports: [HomeComponent],
})
export class ComponentsModule {}
