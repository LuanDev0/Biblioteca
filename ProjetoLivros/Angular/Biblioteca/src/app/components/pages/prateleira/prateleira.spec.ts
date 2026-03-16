import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Prateleira } from './prateleira';

describe('Prateleira', () => {
  let component: Prateleira;
  let fixture: ComponentFixture<Prateleira>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Prateleira],
    }).compileComponents();

    fixture = TestBed.createComponent(Prateleira);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
