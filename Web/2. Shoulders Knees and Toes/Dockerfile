FROM python:3
EXPOSE 80
ADD src/ /challenge/
RUN pip install flask gunicorn
ENV FLASK_APP=/challenge/server.py
WORKDIR /challenge/
CMD ["gunicorn", "-w", "4", "-b", "0.0.0.0:80", "server:app"]