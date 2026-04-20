import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

type Candidate = {
  id: number;
  firstName: string;
  lastName: string;
  yearsOfExperience: number;
  skills: string[];
  isAvailable: boolean;
};

@Component({
  selector: 'app-root',
  imports: [CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  title = 'Interview Candidates';
  candidates: Candidate[] = [];
  loading = false;

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.loadCandidates();
  }

  loadCandidates() {
    this.loading = true;
    this.http.get<Candidate[]>('/api/candidates').subscribe({
      next: (data) => {
        this.candidates = data;
        this.loading = false;
      },
      error: () => {
        this.loading = false;
      }
    });
  }
}
