import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BotaoPainel } from './botao-painel';

describe('BotaoPainel', () => {
  let component: BotaoPainel;
  let fixture: ComponentFixture<BotaoPainel>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BotaoPainel],
    }).compileComponents();

    fixture = TestBed.createComponent(BotaoPainel);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
