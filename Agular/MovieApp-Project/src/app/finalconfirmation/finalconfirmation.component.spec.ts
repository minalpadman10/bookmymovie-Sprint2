import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FinalconfirmationComponent } from './finalconfirmation.component';

describe('FinalconfirmationComponent', () => {
  let component: FinalconfirmationComponent;
  let fixture: ComponentFixture<FinalconfirmationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FinalconfirmationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FinalconfirmationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});