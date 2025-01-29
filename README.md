# CI/CD Pipeline for Encryption/Decryption API

This project demonstrates the implementation of a **CI/CD pipeline** for a C# ASP.NET Web API that provides encryption and decryption functionality. The API is deployed to **AWS Elastic Beanstalk** using **GitHub Actions**. The project follows **Git Flow** for version control and includes unit testing using **xUnit**. Additionally, **Swagger** is used for API documentation and testing.

---

## Table of Contents
### Project Overview

- API Endpoints

- Technologies Used

- Git Flow and Branching Strategy

- CI/CD Pipeline

- Unit Testing

- Deployment to AWS Elastic Beanstalk

- How to Run the Project Locally

---

## Project Overview
The goal of this project is to create a fully automated CI/CD pipeline for a C# ASP.NET Web API. The API provides two endpoints:

Encrypt: Encrypts a given input using an OTP encryption method.

Decrypt: Decrypts the encrypted input.

The project uses GitHub Actions for continuous integration and deployment (CI/CD) and follows parts of Git Flow for version control. The API is deployed to AWS Elastic Beanstalk.

---

## API Endpoints With Swagger
The API exposes the following endpoints:

### POST /api/Crypt/encrypt**

Leave key as it is, put your message in the plainText field.
**Request Body:**
```
{
  "plainText": "Hello World",
  "key": "string"
}
```

Here you get the encrypted text with your unique key, save them for decryption.
**Response body:**
```
{
  "encryptedText": "Spwwz+bz}wo",
  "key": "|S?@Lw^3TT3"
}
```

### POST /api/Crypt/decrypt

Use the encrypt Response body.
Request Body:
Example Value | Schema
```
{
  "encryptedText": "Spwwz+bz}wo",
  "key": "|S?@Lw^3TT3"
}
```

Response body:
```
{
  "decryptedText": "Hello World"
}
```
---

## Technologies Used
Backend: ASP.NET Core Web API (.NET 8)

Testing Framework: xUnit

Version Control: Git with GitHub

CI/CD: GitHub Actions

Cloud Deployment: AWS Elastic Beanstalk

Encryption Method: OTP.

---

## Git Flow and Branching Strategy

The project follows parts of the **Git Flow** workflow:
- **Main Branch**: Contains the production-ready code.
- **Develop Branch**: Used for features and bug fixes.

All code changes are pushed into the `develop` branch via **Pull Requests (PRs)**. Once tested and approved, the `develop` branch is merged into `main` for deployment.

---

## CI/CD Pipeline

The CI/CD pipeline is implemented using **GitHub Actions** and includes the following steps:
1. **Build**: Compiles the .NET project.
2. **Test**: Runs unit tests using xUnit.
3. **Deploy**: Deploys the API to **AWS Elastic Beanstalk**.

The pipeline is triggered on:
- Push to the `main` or `development` branches.
- Pull requests to the `main` or `development` branches.

---

## Unit Testing

Unit tests are written using **xUnit** and cover the encryption and decryption APIs. The tests are automatically executed as part of the CI/CD pipeline.

---

## Deployment to AWS Elastic Beanstalk

The API is deployed to **AWS Elastic Beanstalk** using GitHub Actions. The deployment process includes:

1. **Building the .NET project**.
2. **Packaging the application**.
3. **Deploying the package to AWS Elastic Beanstalk**.

The deployment is automated and triggered by changes to the `main` branch.

---

## How to Run the Project Locally

**Clone the Repository**:
bash
```
git clone git@github.com:Flying0101/cryptic.git
```
Enter the web project dir.
```
dotnet restore

dotnet run
```
**Access the API**
Open your browser or use a tool like Postman to access the API at localhost.