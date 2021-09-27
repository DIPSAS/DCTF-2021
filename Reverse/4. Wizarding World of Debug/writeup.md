The password can be found by debugging the app using a program like DnSpy
https://github.com/dnSpy/dnSpy/releases
 
Download the 32 bit version to debug our program
By putting a breakpoint around where the password is compared to input, you can see the 
decrypted password in plaintext in the debugger. 

The password is: <b>Time is Galleons, little brother</b>
Which will then give you the flag: 
	<b>d:ctf{Don't let the Muggles get you down}</b>
