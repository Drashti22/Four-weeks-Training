import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

const BASE_URL = 'https://jsonplaceholder.typicode.com'

@Injectable({
  providedIn: 'root'
})
export class JsonPlaceholderService {
  constructor(private http: HttpClient) { }

  fetchPost(): Observable<any[]>{
    return this.http.get<any[]>(`${BASE_URL}/posts`)
  }

  createPost(title: string, body: string, userId: number): Observable<any[]>{
    const payLoad ={title, body, userId};
    return this.http.post<any>(`${BASE_URL}/posts`, payLoad);
  }
  updatePost(postId: number, title: string, body: string): Observable<any[]>{
    const payLoad: any ={};
    if(title){
      payLoad.title=title;
    }
    if(body){
      payLoad.body=body;
    }
    return this.http.put<any>(`${BASE_URL}/posts/${postId}`, payLoad);
  }
  deletePost(postId: number):  Observable<any[]>{
    return this.http.delete<any>(`${BASE_URL}/posts/${postId}`);
  }
}
