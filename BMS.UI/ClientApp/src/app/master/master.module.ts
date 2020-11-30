import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AttributeComponent } from './attribute.component';
import { MasterRoutingModule } from './master.routing.module';

@NgModule({
  imports: [
    CommonModule,
    MasterRoutingModule
  ],
  declarations: [ AttributeComponent ]
})
export class MasterModule { }
