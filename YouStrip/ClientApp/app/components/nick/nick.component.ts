﻿import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'nick',
    template: require('./nick.component.html'),
    styles: [require('./nick.component.css')]
})

export class NickTestComponent {

    constructor(private http: Http) { }

    //sendText(name: string) {
    //    http.get('/api/YouStrip/
    //}

    sendDefaultText() {
        this.http.get('/api/YouStrip/SendMessage').subscribe(result => {
            console.log("Success");
        });
    }
}