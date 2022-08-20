import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'app-root',
	templateUrl: './app.component.html',
	styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
	title = 'UILayerAngular13';
	constructor(private http: HttpClient) { }
	users: any;
	ngOnInit(): void {
		this.getUsers();
	}

	getUsers() {
		this.http.get('https://localhost:7019/api/Users').subscribe((Response) => {
		this.users = Response;
		}, error => {
			console.log(error);
		})
	}
}
