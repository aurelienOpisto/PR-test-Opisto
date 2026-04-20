# InterviewLab - PR d'entretien (branche avec erreurs)

Cette branche est volontairement imparfaite pour simuler une vraie PR de revue technique.

Le principe:
- `main` contient une version simple et saine.
- `feature/interview-pr-errors` ajoute des endpoints et des erreurs volontaires.

## Structure

- `bff`: API ASP.NET Core (BFF)
- `frontend`: application Angular

## Lancer le projet

## 1) BFF

Depuis la racine:

```powershell
dotnet run --project .\bff\InterviewLab.Bff.csproj
```

API disponible en local sur `http://localhost:5194`.

## 2) Frontend

Dans `frontend`:

```powershell
npm install
npm start
```

Application disponible sur `http://localhost:4200`.

## Endpoints proposes dans cette PR

- `GET /api/candidates`
- `GET /api/candidates/{id}`
- `GET /api/candidates/search?skill=...`
- `POST /api/candidates`

## Exemples d'erreurs volontaires

- Typage faible cote Angular (`any[]`)
- Tri en place dans un getter
- Donnees statiques mutables cote API
- Endpoint de recherche sans robustesse sur les entrees
- Snippets avec erreurs de syntaxe hors build:
	- `bff/InterviewExercises/BrokenRepository.cs.txt`
	- `frontend/InterviewExercises/broken-service.ts.txt`
