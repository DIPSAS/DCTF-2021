Reviewing the source of the login page reveals this comment:

```
<!-- TODO: Can someone explain why admin doesn't want us to exclude all of the common passwords linked? -->
<!-- At the very least let's exclude the top 20... -->
```

Maybe 

Looking at the linked article, we see that the other top 20 passwords are

```
11.    1234567
12.    qwerty
13.    abc123
14.    Million2
15.    000000
16.    1234
17.    iloveyou
18.    aaron431
19.    password1
20.    qqww1122
```

`Million2` satisfies all of the requirements: it has a lowercase letter, a capital letter and a number, and it is 8 characters long.

Logging in as `admin`/`Million2` (or any of the other passwords satisfying the criteria) reveals the flag `d:ctf{all-my-passwords-are-on-sticky-notes}`