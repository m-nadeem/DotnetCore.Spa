import { Component } from '@angular/core';
import { DataService } from '../../services/data.service';

@Component({
  selector: 'app-contact-list',
  templateUrl: './contact-list.component.html'
})

export class ContactListComponent {
  public contactsList: StoreModel[];

  constructor(private dataService: DataService) {

    this.dataService.getContactsList().subscribe(result => {
      this.contactsList = result;
    },
      error => console.error(error));
  }
}
