import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PainelExpansivel } from './painel-expansivel';

describe('PainelExpansivel', () => {
  let component: PainelExpansivel;
  let fixture: ComponentFixture<PainelExpansivel>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PainelExpansivel],
    }).compileComponents();

    fixture = TestBed.createComponent(PainelExpansivel);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
