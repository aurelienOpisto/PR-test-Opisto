# Contexte candidat

## Objectif de l'exercice

Tu rejoins une equipe qui maintient une application de gestion de candidats.

Le scope de cette PR:
- ajout d'une fonctionnalite de recherche par competence
- ajout d'un endpoint de creation de candidat
- adaptation du front pour filtrer les candidats

Le projet est compose de:
- un BFF ASP.NET Core
- un frontend Angular

## Consignes pour le candidat

- Lire la PR comme en situation reelle.
- Identifier les points bloquants avant merge.
- Distinguer:
  - bug/risque fonctionnel
  - probleme de robustesse
  - dette de conception
  - ameliorations de lisibilite/tests
- Proposer un plan de correction priorise.

## Points de depart (a explorer)

API:
- GET /api/candidates
- GET /api/candidates/{id}
- GET /api/candidates/search?skill=...
- POST /api/candidates

Front:
- liste des candidats
- filtre par nom
- filtre par competence

## Livrable attendu du candidat

En 30 a 45 minutes:
- 5 a 10 remarques argumentees
- 2 a 3 corrections critiques proposees
- une strategie de test rapide (unitaires + integration)
