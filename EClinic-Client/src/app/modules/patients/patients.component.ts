import { Component, Injector, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable, MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';

export class PatientDto {
  refernceNumber?: number;
  nationalId?: string;
  fileNumber?: string;
  name?: string;
  phoneNumber?: string;
  email?: string;
  physician?: string;
  isInsured?: boolean;
  insuranceCompany?: string;
  lastVisit?: Date;
  doctorId?: number;
  sex?: number;
  birthdate?: Date;
  locationAdress? :string;
}

export var ELEMENT_DATA: PatientDto[] = [
  { refernceNumber: 1,nationalId: "1234213123", name: 'سعد',       fileNumber: "23",    phoneNumber: "0787654321", email: "example@domain.com", doctorId: 1 ,physician: "سعد جابر", isInsured:true  ,insuranceCompany: "الشرق العربي", lastVisit: new Date(2020, 5, 11, 10, 33, 30, 0) ,sex: 1 },
  { refernceNumber: 2,nationalId: "2213213422", name: 'محمد',      fileNumber: "52",    phoneNumber: "0787654321", email: "example@domain.com", doctorId: 1, physician: "سعد جابر", isInsured:false ,insuranceCompany: "الشرق العربي", lastVisit: new Date(2017, 11, 4, 10, 33, 30, 0) ,sex: 1 },
  { refernceNumber: 3,nationalId: "2289073422", name: 'رهام',     fileNumber: "162",     phoneNumber: "0787654321", email: "example@domain.com", doctorId: 2,  physician: "مأمون المومني", isInsured:false ,insuranceCompany: "الشرق العربي", lastVisit: new Date(2020, 9, 22, 10, 33, 30, 0) ,sex: 2 },
  { refernceNumber: 4,nationalId: "2234353322", name: 'سمير',      fileNumber: "23",    phoneNumber:"0787654321",  email: "example@domain.com", doctorId: 1, physician: "سعد جابر", isInsured:true  ,insuranceCompany: "الشرق العربي", lastVisit: new Date(2020, 1, 30, 10, 33, 30, 0) ,sex: 1 },
  { refernceNumber: 5,nationalId: "2200089422", name: 'عمر',      fileNumber: "235",     phoneNumber: "0787654321", email: "example@domain.com", doctorId: 2, physician: "مأمون المومني", isInsured:true  ,insuranceCompany: "الشرق العربي", lastVisit: new Date(2019, 12, 17, 10, 33, 30, 0) ,sex: 1 },
  { refernceNumber: 6,nationalId: "2213333322", name: 'عبدالله',     fileNumber: "85",  phoneNumber: "0787654321", email: "example@domain.com", doctorId: 1, physician: "سعد جابر", isInsured:false ,insuranceCompany: "الشرق العربي", lastVisit: new Date(2018, 11, 4, 10, 33, 30, 0) ,sex: 1 },
  { refernceNumber: 7,nationalId: "2244444422", name: 'زياد',       fileNumber: "93",   phoneNumber: "0787654321", email: "example@domain.com", doctorId: 2, physician: "مأمون المومني", isInsured:true  ,insuranceCompany: "الشرق العربي", lastVisit: new Date(2020, 2, 6, 10, 33, 30, 0) ,sex: 1 },
  { refernceNumber: 8,nationalId: "2757213422", name: 'رامي',     fileNumber: "56",     phoneNumber: "0787654321", email: "example@domain.com", doctorId: 1, physician: "سعد جابر", isInsured:false ,insuranceCompany: "الشرق العربي", lastVisit: new Date(2016, 8, 8, 10, 33, 30, 0) ,sex: 1 },
  { refernceNumber: 9,nationalId: "2268213422", name: 'سها',        fileNumber: "45",   phoneNumber: "0787654321", email: "example@domain.com", doctorId: 1, physician: "سعد جابر", isInsured:false ,insuranceCompany: "الشرق العربي", lastVisit: new Date(2018, 4, 23, 10, 33, 30, 0),sex: 2  },
  { refernceNumber: 10,nationalId: "2205213422", name: 'مسعود',      fileNumber: "1", phoneNumber: "0787654321", email: "example@domain.com", doctorId: 2, physician: "مأمون المومني", isInsured:true  ,insuranceCompany: "الشرق العربي", lastVisit: new Date(2019, 1, 2, 10, 33, 30, 0)  ,sex: 1 },
  { refernceNumber: 11,nationalId: "2205874422", name: 'حسام',      fileNumber: "150", phoneNumber: "0777654321", email: "example@domain.com", doctorId: 1, physician: "سعد جابر", isInsured:true  ,insuranceCompany: "الشرق العربي", lastVisit: new Date(2017, 7, 15, 10, 33, 30, 0) ,sex: 1 },

];

@Component({
  selector: 'app-patients',
  templateUrl: './patients.component.html',
  styleUrls: ['./patients.component.scss']
})
export class PatientsComponent implements OnInit {

  searchName: string;
  referenceNumberSearch: number;
  displayedColumns: string[] = ['nationalId', 'name', 'fileNumber', 'phoneNumber','email','physician','isInsured', 'insuranceCompany','lastVisit','star'];
  dataSource: MatTableDataSource<PatientDto>;

  @ViewChild('patientsTable', {static: true}) table: MatTable<PatientDto>;
  @ViewChild(MatSort, {static: true}) sort: MatSort;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;




  constructor(injector: Injector,
    private router: Router){
   }


  ngAfterViewInit(): void {
  }

   ngOnInit() {
    this.setDataSource(ELEMENT_DATA);
   }

   setDataSource(data){
    this.dataSource = new MatTableDataSource<PatientDto>(data);
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
    this.table.dataSource = this.dataSource;
   }
   public searchPatient(data){
    if(this.searchName || this.referenceNumberSearch){
      let searchedData = ELEMENT_DATA.filter(
        m => m.name.toLowerCase().includes(this.searchName)
        || m.refernceNumber == this.referenceNumberSearch
      );
      this.setDataSource(searchedData);
    }else{
      this.setDataSource(ELEMENT_DATA);
    }
  }

  resetSearch($event){
    this.searchName = undefined;
    this.referenceNumberSearch = undefined;
    this.setDataSource(ELEMENT_DATA);
  }

  goToEdit(refernceNumber){
    this.router.navigate(['app/patients',refernceNumber]);
    console.log(refernceNumber);
  }

}
