import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

interface BlogPost{
  id: number,
  title: string,
  body: string
}

@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.css']
})
export class BlogComponent implements OnInit {
  blogPosts: BlogPost[]=[];
  constructor(private http:HttpClient){}
  ngOnInit(): void {
    this.fetchBlogPosts();
  }
  fetchBlogPosts() {
    this.http.get<BlogPost[]>('https://jsonplaceholder.typicode.com/posts').subscribe((posts) => {
      this.blogPosts = posts;
    })
  }
}
