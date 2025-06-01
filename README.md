# 🛍️ ProductStoreApi

A clean and scalable ASP.NET Core Web API for managing products, customers, orders, categories, and suppliers.

## 📦 Features

- CRUD APIs for products (models coming soon)
- CI/CD using GitHub Actions ✅
- Dockerized with a working `Dockerfile` 🐳
- Kubernetes-ready deployment with future YAML files
- Git workflow with `main`, `development`, and `feature/*` branches
- Ready for unit & integration testing with xUnit

## 📁 Project Structure

ProductStoreApi/
├── Controllers/
├── Models/ ← coming soon
├── Program.cs
├── Dockerfile
├── .github/workflows/ci-cd.yml


## 🚀 Technologies Used

- ASP.NET Core 8
- Docker
- GitHub Actions (CI/CD)
- Kubernetes (local + Azure)
- Visual Studio 2022
- Git branching (main, development, feature branches)

## 📜 Git Branching Strategy

- `main` – Production-ready stable code
- `development` – In-progress features and active CI/CD
- `feature/*` – Each feature (models, API, tests, etc.) is built here and merged into `development`

## 🛠️ Setup Instructions

```bash
git clone https://github.com/MrNauman9/ProductStoreApi.git
cd ProductStoreApi
dotnet build
dotnet run

docker build -t productstore:latest .
docker run -p 8080:80 productstore:latest

🔄 Upcoming Features
 Dockerfile + GitHub CI/CD

 Product + Category Models

 Full CRUD for Products

 SQLite + EF Core DB

 Unit & Integration Tests

 Azure Kubernetes Deployment

🙌 Author
Nauman
🔗 GitHub Profile
