import { Component, OnInit } from '@angular/core';
import { EventData } from '../models/EventData';
import { EventService } from '../services/event.service';

@Component({
  selector: 'app-special-events',
  templateUrl: './special-events.component.html'
})
export class SpecialEventsComponent implements OnInit {

  events:Array<EventData> = new Array<EventData>();
  constructor(private _eventService: EventService) { }

  ngOnInit(): void {
    this._eventService.getSpecialEvents().subscribe(res => this.events = res, err => console.log(err))
  }

}
