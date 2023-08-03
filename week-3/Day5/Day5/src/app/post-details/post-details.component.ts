import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-post-details',
  templateUrl: './post-details.component.html',
  styleUrls: ['./post-details.component.css']
})
export class PostDetailsComponent implements OnInit{
  
  post: any;
  comments: any[] = [];
  
  constructor(
    private route: ActivatedRoute,
    private http: HttpClient
  ) {}
  ngOnInit() {
    const postId = this.route.snapshot.params['id'];
    this.http.get<any>(`https://jsonplaceholder.typicode.com/posts/${postId}`).subscribe(post =>{
      this.post = post;
    });
    this.http.get<any[]>(`https://jsonplaceholder.typicode.com/posts/${postId}/comments`).subscribe(comments => {
      this.comments = comments;
    });

  }
   
}
