from flask import Flask, render_template, redirect, url_for, request, make_response
import os
app = Flask(__name__)
app.config.update(dict(SECRET_KEY=os.urandom(16), HOST="0.0.0.0", PORT=80))

@app.route("/", methods=['GET'])
def index():
    response = make_response(render_template('index.html'))
    return response

@app.route("/shoulders", methods=['GET', 'POST'])
def shoulders():
    if request.method == 'POST':
        response = make_response(render_template('index.html'))
        return response
    return redirect(url_for('index'))

@app.route("/knees", methods=['GET', 'POST'])
def knees():
    if request.method == 'POST':
        response = make_response(render_template('index.html'))
        response.headers['DCTF-Flag'] = 'ZDpjdGZ7d2hlcmVzLXlvdXItaHR0cC1oZWFkZXItYXQ/fQ=='
        return response
    return redirect(url_for('index'))

@app.route("/toes", methods=['GET', 'POST'])
def toes():
    if request.method == 'POST':
        response = make_response(render_template('index.html'))
        return response
    return redirect(url_for('index'))