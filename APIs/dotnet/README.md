# .NET Web API Implementation with ASP.NET Core

## Introduction

Welcome to the .NET Web API implementation within the Web-APIs-and-Clients project. This component demonstrates server-side functionality using C# and the ASP.NET Core framework.

## Getting Started

Follow these steps to set up and run the .NET Web API:

1. **Clone the repository:**
   ```bash
   git clone https://github.com/danilovda/Web-APIs-and-Clients.git
   ```

2. **Navigate to the .NET Web API directory:**
   ```bash
   cd Web-APIs-and-Clients/APIs/dotnet
   ```

3. **Build and run the application:**
   ```bash
   dotnet build
   dotnet run
   ```

   The API will be available at `http://localhost:5093`.

## API Endpoints

The .NET Web API provides the following endpoints:

- **GET /api/employees:** Returns a list of employees.
- **POST /api/employees:** Adds a new employee to the database.
  Example:
  ```json
  {
    "firstName": "John",
    "lastName": "Doe"
  }
  ```

## Additional Information

- Adjust the port or configuration in the `/Properties/launchSettings.json` file if necessary.
- Feel free to explore and modify the code to better understand C# and ASP.NET Core for web development.
