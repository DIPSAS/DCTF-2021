We are dropped into a FreeDOS command prompt. If you're familiar with the command line, your first instinct is probably to run `dir`:

```
A:\>dir                                                                         
 Volume in drive A is FREEDOS                                                   
 Volume Serial Number is E4C9-5CE8                                              
 Directory of A:\                                                               
                                                                                
COMMAND  COM        66,090  12-10-03  7:49a                                     
AUTOEXEC BAT           149  09-07-21  4:27p                                     
DCTF                 <DIR>  09-07-21  4:18p                                     
CONFIG   SYS           245  09-07-21  4:29p                                     
README   TXT           176  09-07-21  4:31p                                     
FDOS                 <DIR>  10-25-12  7:02p                                     
         4 file(s)         66,660 bytes                                         
         2 dir(s)         518,144 bytes free                                    
```

`README` looks like a promising start - either `TYPE README.TXT` or `EDIT README.TXT` will reveal the first part of the flag, `d:ctf{640k-is-`

The file tells us to look elsewhere for the second part. We enter the DCTF folder with `cd DCTF`, and explore its contents:

```
A:\DCTF>dir                                                                     
 Volume in drive A is FREEDOS                                                   
 Volume Serial Number is E4C9-5CE8                                              
                                                                                
 Directory of A:\DCTF                                                           
                                                                                
.                    <DIR>  09-07-21  4:18p                                     
..                   <DIR>  09-07-21  4:18p                                     
SECRET   TXT           187  09-07-21  4:24p                                     
         1 file(s)            187 bytes                                         
         2 dir(s)         518,144 bytes free                                    
```

`TYPE SECRET.TXT` reveals the second part of the flag, `enough-for-`, but complains about "extended memory" errors.

Searching troubleshooting tips for "extended memory" and "out of memory" errors in DOS will lead to suggestions - e.g. http://doublehammer.com/help/ismemdos.htm - for checking that AUTOEXEC.BAT or CONFIG.SYS are set up correctly. Reading either of these files reveals the final part of the flag: `you-and-me}`