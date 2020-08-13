import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateOrEditPatientComponent } from './create-or-edit-patient.component';

describe('CreateOrEditPatientComponent', () => {
  let component: CreateOrEditPatientComponent;
  let fixture: ComponentFixture<CreateOrEditPatientComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateOrEditPatientComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateOrEditPatientComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
