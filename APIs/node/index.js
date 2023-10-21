const express = require('express');
const db = require('./database');
const bodyParser = require('body-parser');

const app = express();

app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

app.get('/api/employees', (req, res) => {
    var sql = 'select * from employees;'
    var params = [];

    db.all(sql, params, (err, rows) => {
        if (err) {
            res.status(400).json({ "error": err.message });
        }
        res.status(200).json(rows);
    });

});

app.post('/api/employees/', (req, res) => {
    var errors = [];
    if (!req.body.firstName) {
        errors.push("No FirstName supplied");
    }
    if (!req.body.lastName) {
        errors.push("No lastName supplied");
    }

    if (errors.length) {
        res.status(400).json({ 'error': errors.join(',') });
        return;
    }

    var data = {
        firstName: req.body.firstName,
        lastName: req.body.lastName
    }

    var sql = 'INSERT INTO employees (firstName, lastName) VALUES (?, ?);';
    var params = [data.firstName, data.lastName];

    db.run(sql, params, function (err, result) {
        if (err) {
            res.status(400).json({ 'error': err.message });
        }
        res.status(201).json({
            id: this.lastID,
            firstName: data.firstName,
            lastName: data.lastName
        })
    });
});

app.listen(4000, () => {
    console.log('Server running on port 4000');
});