Instead of using JSON Web Encryption (JWE), Jørgen has packed the flag into a JSON Web Signature (JWS).

Decoding the message with www.jwt.io produces the flag:

```
{
  "iss": "jorgen@dips.no",
  "sub": "cn=Jørgen, o=DIPS AS",
  "flag": "d:ctf{beware-of-grizzly-bearer-tokens}",
  "exp": 1640912485,
  "iat": 1630912485
}
```