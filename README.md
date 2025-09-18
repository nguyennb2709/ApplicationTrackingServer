# Job Application Tracker API (Backend)

This is the backend API for the Job Application Tracker application.

## Tech Stack

- .NET 9
- Entity Framework Core (In-Memory Database)
- Repository Pattern
- REST API

> **Note:** Since we only have a single repository, using Unit of Work was not considered necessary.

## Features

- Fetch job applications with pagination
- Add, edit, and delete job applications
- In-memory database for quick testing

## Getting Started

1. **Clone the repository**

```bash
git clone <backend-repo-url>
```
2. **Install dependencies(if needed)**
```bash
dotnet restore
```
3. **Run the API Server**
```bash
dotnet run
```
