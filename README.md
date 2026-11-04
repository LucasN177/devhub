# 🧭 DevHub

**DevHub** ist die zentrale Übersicht über alle meine aktuellen Entwicklungsprojekte. Auf einen Blick sieht man,
woran gerade gearbeitet wird, wie weit ein Projekt ist und wo Code und Live-Version liegen.

**Live:** https://nagelsmann-dev.de/

## ✨ Features

- 👋 **Dashboard** mit Begrüßung, Kennzahlen (gesamt, aktiv, in Planung, abgeschlossen) und allen Projekten als Karten
- 🔎 **Suche** nach Name, Kurzbeschreibung oder Technologie und **Filter** nach Status
- 📄 **Detailansicht** pro Projekt (`/projects/{slug}`) mit Beschreibung, Features, nächsten Schritten,
  Fortschritt, Tech-Stack und Links zu Repository und Live-Version
- 🧭 Seitenmenü mit allen Projekten, auf dem Handy einklappbar
- 🌙 Hell-/Dunkelmodus (startet mit der Systemeinstellung)
- 📲 Installierbar als PWA

## 📁 Projekte

| Projekt | Beschreibung | Status |
|---|---|---|
| [DevHub](https://github.com/LucasN177/devhub) | Zentrale Übersicht über alle laufenden Projekte | Aktiv |
| [Syncro](https://github.com/LucasN177/Syncro) | Projektmanagement mit Kanban-Board, Kalender und Echtzeit-Zusammenarbeit | Aktiv |
| [MonExA](https://github.com/LucasN177/monexa) | Finanzen über mehrere Projekte und Benutzer hinweg verwalten | Aktiv |
| [Darts](https://github.com/LucasN177/Darts) | Darts zählen und trainieren – mit 27 Spiel- und Trainingsmodi und Computergegnern | Aktiv |
| [Placebook](https://github.com/LucasN177/placebook) | Orte sammeln – alle Filialen einer Kette auf der Karte abhaken | Aktiv |
| [Split](https://github.com/LucasN177/Split) | Gemeinsame Ausgaben mit Freunden und Gruppen fair aufteilen | Aktiv |
| [Football Tracker](https://github.com/LucasN177/FootballTracker) | Tabellen, Spieltage, Teams und Spieler von Bundesliga bis Champions League verfolgen | Aktiv |
| [CodeSail](https://github.com/LucasN177/CodeSail) | Leichtgewichtiger Code-Editor für iPad und Tablets – direkt im Browser | Aktiv |
| [Social](https://github.com/LucasN177/social) | Soziales Netzwerk mit Feed, Stories und Nachrichten als PWA | Aktiv |
| [Cards](https://github.com/LucasN177/Cards) | Klassische Kartenspiele gegen clevere Computergegner – direkt im Browser | Aktiv |
| [Doxera](https://github.com/LucasN177/Doxera) | PDF-Editor im Browser – lokal, offline und datenschutzfreundlich | Aktiv |

## 🛠 Tech-Stack

| Bereich | Technologie |
|---|---|
| Frontend | [Blazor WebAssembly](https://learn.microsoft.com/aspnet/core/blazor/) (.NET 10) |
| UI-Komponenten | [MudBlazor](https://mudblazor.com/) 9 |
| Projektdaten | Statische JSON-Datei (`wwwroot/data/projects.json`) |
| Backend (vorbereitet) | [Supabase](https://supabase.com/) – Client und Auth sind registriert, werden aber noch nicht genutzt |
| Hosting | GitHub Pages via GitHub Actions |

## 🗂 Projektstruktur

```
devhub/
  Components/            Projektkarte, Avatar, Status-Chip und Status-Texte/-Farben
  Core/                  Modelle (Project, ProjectStatus), Interfaces, Response-Typen
  Infrastructure/        Supabase-Anbindung (Auth)
  Layout/                Hauptlayout, Seitenmenü, Theme
  Pages/                 Dashboard, Projekt-Detailseite, 404
  Services/              ProjectService (lädt projects.json), AppStateService, AuthService
  wwwroot/data/          projects.json – alle Projekte
  wwwroot/css/app.css    Eigene Styles
.github/workflows/       Build & Deploy auf GitHub Pages
```

## ➕ Projekt hinzufügen oder ändern

Alle Projekte stehen in [`devhub/wwwroot/data/projects.json`](devhub/wwwroot/data/projects.json).
Auf dem Dashboard werden sie nach `updatedAt` sortiert (neueste zuerst).

| Feld | Bedeutung |
|---|---|
| `slug` | Eindeutiger Kurzname, wird Teil der URL (`/projects/<slug>`) |
| `name`, `tagline` | Name und Kurzbeschreibung für Karte und Kopfbereich |
| `description` | Ausführliche Beschreibung; `\n` trennt Absätze |
| `category` | Freitext, z. B. „Finanzen“ |
| `status` | `Idea`, `Planning`, `Active`, `Paused` oder `Completed` |
| `progress` | Fortschritt in Prozent (0–100) |
| `accentColor` | Akzentfarbe als Hex-Wert, z. B. `#EA580C` |
| `startedAt`, `updatedAt` | Datum im Format `JJJJ-MM-TT` |
| `repositoryUrl`, `liveUrl` | Links oder `null` |
| `technologies`, `features`, `nextSteps` | Listen von Texten; leere Listen blenden den Abschnitt aus |
| `links` | Weitere Links als `{ "label": "…", "url": "…" }` |

Erstellt von **Lucas Nagelsmann**
