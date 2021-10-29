import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, forkJoin } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title(title: any) {
    throw new Error('Method not implemented.');
  }
  loadedCharacter!: {};
  constructor(private httpClient: HttpClient) {}

  ngOnInit() {
    let character = this.httpClient.get('https://jsonplaceholder.typicode.com/users/1');
    let characterHomeworld = this.httpClient.get('https://jsonplaceholder.typicode.com/users/3');

    forkJoin([character, characterHomeworld]).subscribe(results => {
       this.loadedCharacter=results;
       console.log(results[0]+" " + results[1]);
   });
 }
}



