import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ComponentpacientesComponent } from './componentpacientes.component';

describe('ComponentpacientesComponent', () => {
  let component: ComponentpacientesComponent;
  let fixture: ComponentFixture<ComponentpacientesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ComponentpacientesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ComponentpacientesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
