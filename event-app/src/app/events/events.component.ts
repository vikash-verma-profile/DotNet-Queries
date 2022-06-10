import { Component, OnInit } from '@angular/core';
import { EventData } from '../models/EventData';
import { EventService } from '../services/event.service';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html'
})
export class EventsComponent implements OnInit {

  events:Array<EventData> = new Array<EventData>();
  constructor(private _eventService: EventService) { }

  ngOnInit(): void {
    this._eventService.getEvents().subscribe(res => this.events = res, err => console.log(err))
  }

}
