const sqlite3 = require('sqlite3').verbose();

let db = new sqlite3.Database('employees.db', (err) => {
    if (err) {
        console.error(err.message);
        throw err;
    }
    else {
        console.log('Connected to db ...');
        db.run(`CREATE TABLE employees (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            firstName TEXT,
            lastName TEXT
        )`,
            (err) => {
                if (err) {
                    console.log('Table already created');
                }
            });
    }
});

module.exports = db;