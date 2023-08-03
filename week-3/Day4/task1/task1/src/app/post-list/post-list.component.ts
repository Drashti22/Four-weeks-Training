import { Component, OnInit} from '@angular/core';
import { Observable } from 'rxjs';
import { JsonPlaceholderService } from '../services/json-placeholder.service';

@Component({
  selector: 'app-post-list',
  templateUrl: './post-list.component.html',
  styleUrls: ['./post-list.component.css']
})
export class PostListComponent implements OnInit {
  posts$!: Observable<any[]>;
  constructor(private jsonPlaceholderService: JsonPlaceholderService){}
  ngOnInit(): void {
    this.posts$ = this.jsonPlaceholderService.fetchPost();
  }
}
