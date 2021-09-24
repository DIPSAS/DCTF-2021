`reverse5` is a Docker image, which can be loaded with `docker load reverse5`.

You can either unpack the image manually with `tar xf reverse5` or inspect the image with `docker image inspect reverse5` to reveal the environment variables:

```
"Env": [
            "PATH=/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin",
            "SECRET_PASSWORD=LetMeIn43275943",
            "FLAG_END=to-your-doorstep"
],
```

Running the image (or extracting the executable from it and running it) and supplying the password `LetMeIn43275943` yields the flag `d:ctf{credentials-delivered-to-your-doorstep}`