import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-attributes',
  templateUrl: './attribute.component.html'
})
export class AttributeComponent implements OnInit {

  attributes: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get('http://localhost:7000/Attributes')
      .subscribe(result => this.attributes = result);
  }


}