import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NotesboardComponent } from './notesboard.component';

describe('NotesboardComponent', () => {
  let component: NotesboardComponent;
  let fixture: ComponentFixture<NotesboardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NotesboardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NotesboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
