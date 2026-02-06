# 🔥 Blazor Hello World — For Angular Developers

A starter Blazor Web App with Angular-to-Blazor annotations throughout the code.

## Quick Start

```bash
cd BlazorHelloWorld
dotnet run
```

Then open https://localhost:5001 in your browser.

## What's Inside

| Page | What it Demonstrates |
|------|---------------------|
| **Home** (`/`) | Project structure overview, info cards |
| **Counter** (`/counter`) | Event binding (`@onclick`), state in `@code` block |
| **Greeting** (`/greeting`) | Two-way binding (`@bind`), child components, `[Parameter]`, `EventCallback` |

## Angular → Blazor Cheat Sheet

| Angular | Blazor |
|---------|--------|
| `@Input()` | `[Parameter]` |
| `@Output() EventEmitter` | `[Parameter] EventCallback` |
| `(click)="fn()"` | `@onclick="Fn"` |
| `[(ngModel)]="val"` | `@bind="val"` |
| `*ngIf` | `@if (...)` |
| `*ngFor` | `@foreach (...)` |
| `{{ value }}` | `@value` |
| `ngOnInit` | `OnInitializedAsync()` |
| `<router-outlet>` | `@Body` (in layout) |
| `{ path: '...', component }` | `@page "/..."` |

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
