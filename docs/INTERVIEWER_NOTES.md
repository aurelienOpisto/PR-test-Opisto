# Notes intervieweur (corrige)

Ce document sert de guide de correction et ne doit pas etre donne au candidat au debut.

## Erreurs / sujets attendus

### API (BFF)

1. Etat global mutable
- CandidatesController utilise une liste statique mutable.
- Risque de concurrence, de couplage et de tests fragiles.

2. Validation d'entree insuffisante
- POST accepte le payload sans validation de contrat.
- Pas de checks sur null, champs vides, coherence metier.

3. Semantique HTTP discutable
- POST renvoie 200 OK au lieu de 201 Created + Location.

4. Endpoint de recherche fragile
- search?skill=... ne gere pas correctement les valeurs null/vides.
- comparaison sensible a la casse.

### Frontend (Angular)

5. Typage faible
- usage de any[] pour les candidats.

6. Getter avec effet de bord
- filteredCandidates fait un sort() sur le tableau source.

7. Gestion des erreurs minimaliste
- erreur HTTP ignoree sans message utilisateur.

8. Logique concentree dans le composant
- pas de service dedie pour l'acces API.

### Exercices syntaxe (hors build)

9. Fichier C# casse
- bff/InterviewExercises/BrokenRepository.cs.txt

10. Fichier TS casse
- frontend/InterviewExercises/broken-service.ts.txt

## Barreme conseille

- Detection des risques critiques: 40%
- Qualite des propositions de correction: 35%
- Capacite de priorisation: 15%
- Communication et argumentation: 10%
