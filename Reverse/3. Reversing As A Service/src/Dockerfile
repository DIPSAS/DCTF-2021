FROM golang:alpine as app-builder
WORKDIR /go/src/app
COPY . .
# Static build required so that we can safely copy the binary over.
# `-tags timetzdata` embeds zone info from the "time/tzdata" package.
RUN CGO_ENABLED=0 GOOS=linux go build -a -ldflags '-extldflags "-static"' .

FROM scratch
# the test program:
COPY --from=app-builder /go/src/app/reverse5 /reverse5
COPY --from=app-builder /go/src/app/flag-start /flag-start
# the tls certificates:
# NB: this pulls directly from the upstream image, which already has ca-certificates:
# COPY --from=alpine:latest /etc/ssl/certs/ca-certificates.crt /etc/ssl/certs/
ENV SECRET_PASSWORD=LetMeIn43275943
ENV FLAG_END=to-your-doorstep
ENTRYPOINT ["/reverse5"]
