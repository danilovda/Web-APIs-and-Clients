from flask import Flask, Response, jsonify, request
from database import *
import json

app = Flask(__name__)

@app.route("/", methods=['GET'])
def get_root():
    return "python"

@app.route("/api/employees", methods=['GET'])
def get():
    employee = get_employees()
    return jsonify(employee)

@app.route("/api/employees", methods=['POST'])
def post():
    content = request.json
    firstName = content["firstName"]
    lasrtName = content["lastName"]
    insert_employee(firstName, lasrtName)
    employee = get_employees()
    json_string = json.dumps(employee)
    return Response(json_string, status=201, mimetype='application/json')

if __name__ == "__main__":
    create_tables()
    app.run(debug=True, port=3000, host= "127.0.0.1")