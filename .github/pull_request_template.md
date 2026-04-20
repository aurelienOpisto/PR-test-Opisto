## Contexte

Cette PR simule une contribution reelle dans une app C# + Angular.
Elle est volontairement imparfaite pour servir de support d'entretien technique.

## Feature ajoutee

- ajout d'un endpoint de recherche par competence: `GET /api/candidates/search?skill=...`
- ajout d'un endpoint de creation: `POST /api/candidates`
- ajout des filtres cote frontend (nom + competence)

## Ce que le reviewer doit faire

- relire comme une PR de prod
- identifier les risques (fonctionnels, robustesse, conception, testabilite)
- proposer un plan de correction priorise

## Fichiers principaux a relire

- bff/Controllers/CandidatesController.cs
- frontend/src/app/app.ts
- frontend/src/app/app.html

## Notes

- des erreurs volontaires existent aussi dans:
  - bff/InterviewExercises/BrokenRepository.cs.txt
  - frontend/InterviewExercises/broken-service.ts.txt
- ces fichiers ne sont pas compiles
