# Writeup for Formula Speed Extraction
By extracting the zip archives, either manually or through an automated process, you would eventually find the flag in a `.txt` file.

## Solution 1
One suggested solution using `python` to extract the files can be found [here](examples/zip_decompression.py).

## Solution 2
You might also use `bash` to extract the files, which could be found [here](examples/zip_decompression.sh).

Run the script (it must be in the same folder as the zip file):
```
$ sh zip_decompression.sh formula-1337.zip ; cat *.txt ; echo ""
```
## Solution 3
Manually extract the files.

## Solution 4
Anyone have a one-liner to extract the files? :)

# Result
The flag is `d:ctf{Mika-Hakkinen}`.