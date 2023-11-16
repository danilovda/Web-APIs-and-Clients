# Node.js Web API Implementation

## Introduction

Welcome to the Node.js Web API implementation within the Web-APIs-and-Clients project. This component demonstrates server-side functionality using Node.js and the Express framework.

## Getting Started

Follow these steps to set up and run the Node.js Web API:

1. **Clone the repository:**
   ```bash
   git clone https://github.com/danilovda/Web-APIs-and-Clients.git
   ```

2. **Navigate to the Node.js Web API directory:**
   ```bash
   cd Web-APIs-and-Clients/APIs/node
   ```

3. **Install dependencies:**
   ```bash
   npm install
   ```

4. **Run the Node.js Web API:**
   ```bash
   node index.js
   ```
   or
   ```bash
   npm start   
   ```

   The API will be available at `http://localhost:4000`.

## API Endpoints

The Node.js Web API provides the following endpoints:

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

- Adjust the port or configuration in the `index.js` file if necessary.
- Feel free to explore and modify the code to better understand Node.js and Express for web development.
