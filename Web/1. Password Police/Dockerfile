FROM golang
EXPOSE 80
ADD luggage/ /luggage/
WORKDIR /luggage/
RUN go build luggage.go
ENTRYPOINT [ "/luggage/luggage" ]