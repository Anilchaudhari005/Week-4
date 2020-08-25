import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { error } from '@angular/compiler/src/util';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  Students: Student[] = [];

  constructor(http: HttpClient, @Inject('BASE URL') baseurl: string) {

    http.get<Student[]>(baseurl + 'api/Students').subscribe(result => {
      this.Students = result;
    }, error=> console.error(error));
  }
}

interface Student {

  Id: number;
  Name: string;
  Roll: number;

}
