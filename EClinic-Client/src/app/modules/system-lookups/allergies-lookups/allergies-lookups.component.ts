import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable, MatTableDataSource } from '@angular/material/table';
import { AccountAllergicsServiceProxy, LookupDto } from '../../../../shared/service-proxies/service-proxies';
import { finalize } from 'rxjs/operators';

@Component({
  selector: 'allergies-lookups',
  templateUrl: './allergies-lookups.component.html',
  styleUrls: ['./allergies-lookups.component.scss']
})
export class AllergiesLookupsComponent implements OnInit {

  dataSource: MatTableDataSource<LookupDto>;
  displayedColumns: string[] = ['ID', 'name', 'Status'];
  data: LookupDto[];

  @ViewChild('allergicsTable', {static: true}) table: MatTable<LookupDto>;
  @ViewChild(MatSort, {static: true}) sort: MatSort;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;

  constructor(private _allergiesServiceProxy: AccountAllergicsServiceProxy) { }

  ngOnInit(): void {
    this._allergiesServiceProxy.allergies2().pipe(finalize(()=> {
      this.setDataSource(this.data)
    }))
    .subscribe(res =>{
      if(res.isSuccessful){
        this.data = res.data.allergies;
      }
    })
  }

  setDataSource(data){
    this.dataSource = new MatTableDataSource<LookupDto>(data);
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
    this.table.dataSource = this.dataSource;
   }

}
