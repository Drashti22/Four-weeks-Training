import { Component, OnInit } from '@angular/core';
import { JsonPlaceholderService } from '../services/json-placeholder.service';

@Component({
  selector: 'app-posts',
  templateUrl: './posts.component.html',
  styleUrls: ['./posts.component.css']
})
export class PostsComponent implements OnInit{
  constructor(private jsonPlaceholderService: JsonPlaceholderService) {}
  ngOnInit(): void {
    this.jsonPlaceholderService.fetchPost().subscribe(posts => {
      console.log('Fetched posts:', posts);
    });
    this.jsonPlaceholderService
      .createPost('New Post', 'This is a new post created with the JSONPlaceholder service.', 1)
      .subscribe(newPost => {
        console.log('New Post:', newPost);
      });
      this.jsonPlaceholderService
      .updatePost(1, 'Updated Title', 'This post has been updated.')
      .subscribe(updatedPost => {
        console.log('Updated Post:', updatedPost);
      });
      this.jsonPlaceholderService.deletePost(1).subscribe(result => {
        if (result) {
          console.log('Post deleted successfully.');
        } else {
          console.log('Failed to delete the post.');
        }
      });
  }
}
