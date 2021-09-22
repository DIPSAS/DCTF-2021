Visiting `knees` by clicking the `Knees` button leads to `DCTF-Flag` being included in the HTTP headers:

`DCTF-Flag ZDpjdGZ7d2hlcmVzLXlvdXItaHR0cC1oZWFkZXItYXQ/fQ==`

Base64-decoding this reveals the flag: `d:ctf{wheres-your-http-header-at?}`