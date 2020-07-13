import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-componentpacientes',
  templateUrl: './componentpacientes.component.html',
  styleUrls: ['./componentpacientes.component.css']
})
export class ComponentpacientesComponent implements OnInit {

conversion:any;
rta:[];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/paciente')
    .subscribe(data => {
      this.conversion=data;
      this.rta=this.conversion;

      console.log('prueba', this.rta);
    });
  }

}
