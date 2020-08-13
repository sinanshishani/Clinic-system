import { Component, Injector, OnInit, ViewChild } from '@angular/core';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { appModuleAnimation } from 'src/shared/animations/routerTransition';
import { AppComponentBase } from 'src/shared/app-component-base';

export interface PeriodicElement {
  name: string;
  position: number;
  weight: number;
  symbol: string;
  also: number;
  then: number;
  after:number;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {position: 1, name: 'Hydrogen', weight: 1.0079, symbol: 'H',also: 12, then:21,after:2131},
  {position: 2, name: 'Helium', weight: 4.0026, symbol: 'He',also: 12, then:21,after:2231},
  {position: 3, name: 'Lithium', weight: 6.941, symbol: 'Li',also: 12, then:21,after:2131},
  {position: 4, name: 'Beryllium', weight: 9.0122, symbol: 'Be',also: 12, then:21,after:21531},
  {position: 5, name: 'Boron', weight: 10.811, symbol: 'B',also: 12, then:21,after:2131},
  {position: 6, name: 'Carbon', weight: 12.0107, symbol: 'C',also: 12, then:21,after:2131},
  {position: 7, name: 'Nitrogen', weight: 14.0067, symbol: 'N',also: 12, then:21,after:21331},
  {position: 8, name: 'Oxygen', weight: 15.9994, symbol: 'O',also: 12, then:21,after:2131},
  {position: 9, name: 'Fluorine', weight: 18.9984, symbol: 'F',also: 12, then:21,after:2131},
  {position: 10, name: 'Neon', weight: 20.1797, symbol: 'Ne',also: 12, then:21,after:2131},
];



@Component({
  selector: 'app-patients',
  templateUrl: './patients.component.html',
  styleUrls: ['./patients.component.scss'],
  animations: [appModuleAnimation()]
})
export class PatientsComponent extends AppComponentBase implements OnInit {

  displayedColumns: string[] = ['position', 'name', 'weight', 'symbol','also','then','after','star'];
  dataSource = new MatTableDataSource(ELEMENT_DATA);


  constructor(injector: Injector,
            //private _patientServiceServiceProxy: PatientServiceServiceProxy
            ){
    super(injector);
   }



   @ViewChild(MatSort, {static: true}) sort: MatSort;

   ngOnInit() {
    //this._patientServiceServiceProxy.patientsQuery().subscribe(res => {console.log(res)});

     this.dataSource.sort = this.sort;
   }
}
