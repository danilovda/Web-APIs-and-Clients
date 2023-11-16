# Python Web API Implementation with Flask

## Introduction

Welcome to the Python Web API implementation within the Web-APIs-and-Clients project. This component demonstrates server-side functionality using Python and the Flask framework.

## Getting Started

Follow these steps to set up and run the Python Web API:

1. **Clone the repository:**
   ```bash
   git clone https://github.com/danilovda/Web-APIs-and-Clients.git
   ```

2. **Navigate to the Python Web API directory:**
   ```bash
   cd Web-APIs-and-Clients/APIs/python
   ```

3. **Install dependencies:**
   ```bash
   pip install flask
   pip install flask-sqlalchemy
   ```

4. **Run the Python Web API:**
   ```bash
   python main.py
   ```

   The API will be available at `http://127.0.0.1:3000`.

## API Endpoints

The Python Web API provides the following endpoints:

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

- Adjust the port or configuration in the `main.py` file if necessary.
- Feel free to explore and modify the code to better understand Python and Flask for web development.
