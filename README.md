# InterviewLab - Base C# + Angular

Base propre pour une revue de PR d'entretien.

Le principe:
- `main` contient une version simple et saine.
- une branche de PR ajoute des endpoints et des erreurs volontaires pour discussion technique.

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

## Endpoints de base

- `GET /api/candidates`
- `GET /api/candidates/{id}`
