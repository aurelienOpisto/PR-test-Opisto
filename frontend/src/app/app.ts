import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  imports: [CommonModule, FormsModule],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  title = 'Interview Candidates';
  candidates: any[] = [];
  loading = false;
  search = '';
  selectedSkill = '';

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.loadCandidates();
  }

  loadCandidates() {
    this.loading = true;
    this.http.get<any[]>('/api/candidates').subscribe({
      next: (data) => {
        this.candidates = data;
        this.loading = false;
      },
      error: () => {
        this.loading = false;
      }
    });
  }

  get availableSkills() {
    const allSkills = this.candidates.flatMap((c) => c.skills || []);
    return Array.from(new Set(allSkills));
  }

  get filteredCandidates() {
    let list = this.candidates;

    if (this.selectedSkill) {
      list = list.filter((c) => (c.skills || []).includes(this.selectedSkill));
    }

    if (this.search.trim()) {
      const q = this.search.toLowerCase();
      list = list.filter((c) =>
        `${c.firstName} ${c.lastName}`.toLowerCase().includes(q)
      );
    }

    return list.sort((a, b) => b.yearsOfExperience - a.yearsOfExperience);
  }
}
