from flask import Flask, render_template, redirect, url_for, request, g, session, abort, send_file, make_response
import os
app = Flask(__name__)
app.config.update(dict(SECRET_KEY=os.urandom(16)))

@app.route("/", methods=['GET'])
def index():
    response = make_response(render_template('index.html'))
    return response

@app.route("/spooky", methods=['GET', 'POST'])
def clickTry():
    if request.method == 'POST':
        response = make_response(render_template('index.html'))
        return response
    return redirect(url_for('index'))

@app.route("/ghost", methods=['GET', 'POST'])
def clickClick():
    if request.method == 'POST':
        response = make_response(render_template('index.html'))
        response.headers['Pumpkin-flag'] = 'VWlUSGFjazIwe2FyZV95b3VfYV9wdW1wa2luX3NwaWNlX2xhdHRlX3BlcnNvbj99=='
        return response
    return redirect(url_for('index'))

@app.route("/pizza", methods=['GET', 'POST'])
def clickHit():
    if request.method == 'POST':
        response = make_response(render_template('index.html'))
        return response
    return redirect(url_for('index'))