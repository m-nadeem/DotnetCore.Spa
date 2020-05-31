import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataService } from '../../services/data.service';

@Component({
  selector: 'app-contact-details',
  templateUrl: './contact-details.component.html'
})
export class ContactDetailsComponent {
  public contactDetails: StoreModel;

  constructor(private dataService: DataService, private activatedRoute: ActivatedRoute) {
    const routeSnap = this.activatedRoute.snapshot;

    this.dataService.getContact(routeSnap.params.id).subscribe(result => {
      this.contactDetails = result;
    },
      error => console.error(error))
  }
}
