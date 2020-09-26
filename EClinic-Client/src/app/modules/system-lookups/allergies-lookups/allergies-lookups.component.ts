import { Component, OnInit } from '@angular/core';
import { AccountAllergicsServiceProxy } from '../../../../shared/service-proxies/service-proxies';

@Component({
  selector: 'allergies-lookups',
  templateUrl: './allergies-lookups.component.html',
  styleUrls: ['./allergies-lookups.component.scss']
})
export class AllergiesLookupsComponent implements OnInit {

  constructor(private _allergiesServiceProxy: AccountAllergicsServiceProxy) { }

  ngOnInit(): void {
    this._allergiesServiceProxy.allergies2().subscribe(res =>{
      console.log(res);
    })
  }

}
