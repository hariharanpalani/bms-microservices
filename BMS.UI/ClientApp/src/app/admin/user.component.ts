import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-users',
  templateUrl: './user.component.html'
})
export class UserComponent implements OnInit {
  users: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get('http://localhost:7000/Users')
      .subscribe(result => this.users = result);
  }

}
