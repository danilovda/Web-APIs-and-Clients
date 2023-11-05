import sqlite3
DATABASE_NAME = "employees.db"

def get_db():
    conn = sqlite3.connect(DATABASE_NAME)
    return conn

def create_tables():
    tables = [
        """CREATE TABLE IF NOT EXISTS employees(
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                firstName TEXT NOT NULL,
				lastName TEXT NOT NULL				
            )
            """
    ]
    db = get_db()
    cursor = db.cursor()
    for table in tables:
        cursor.execute(table)

def get_employees():
    db = get_db()
    cursor = db.cursor()
    query = "SELECT id, firstName, lastName FROM employees"
    cursor.execute(query)
    return cursor.fetchall()

def insert_employee(firstName, lastName):
    db = get_db()
    cursor = db.cursor()
    statement = "INSERT INTO employees(firstName, lastName) VALUES (?, ?)"
    cursor.execute(statement, [firstName, lastName])
    db.commit()
    return True