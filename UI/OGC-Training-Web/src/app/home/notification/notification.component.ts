import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

import { Notifications } from '../../notifications/notifications.model';

import { SelectItem } from 'primeng/primeng';
import { Lookups } from '../../common/constants';

@Component({
    selector: 'notification',
    templateUrl: './notification.component.html',
    styleUrls: ['./notification.component.css']
})

export class NotificationComponent implements OnInit {
    @Input()
    private message: Notifications;

    @Output()
    close = new EventEmitter<any>();

    ngOnInit(): void {

    }

    constructor() {
        
    }

    ngOnChanges(): void {
    }

    cancel() {
        this.close.emit();
    }
}