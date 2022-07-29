import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
	selector: 'app-root',
	templateUrl: './app.component.html',
	styleUrls: ['./app.component.scss']
})
export class AppComponent {
	title = 'UILayerAngular13';
	constructor(private http: HttpClient) { }
	users: any;
	ngOnInit(): void {
		this.getUsers();
	}
	getUsers() {
		this.http.get('https://localhost:7019/api/Users').subscribe((Response) => {
		this.users = Response;
		console.log(this.users);
		})
	}
}
