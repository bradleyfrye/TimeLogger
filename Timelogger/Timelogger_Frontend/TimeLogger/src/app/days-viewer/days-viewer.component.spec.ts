import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DaysViewerComponent } from './days-viewer.component';

describe('DaysViewerComponent', () => {
  let component: DaysViewerComponent;
  let fixture: ComponentFixture<DaysViewerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DaysViewerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DaysViewerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
