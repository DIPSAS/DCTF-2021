# Writeup for Formula Speed Extraction
By extracting the zip archives, either manually or through an automated process, you would eventually find the flag in a `.txt` file.

## Solution 1
One suggested solution using `python` to extract the files can be found [here](examples/zip_decompression.py).

Run the script (it must be in the same folder as the zip file):

```
$ python zip_decompression.py
```

## Solution 2
You might also use `bash` to extract the files, which could be found [here](examples/zip_decompression.sh).

Run the script (it must be in the same folder as the zip file):

```
$ sh zip_decompression.sh formula-1337.zip ; cat *.txt ; echo ""
```


## Solution 3
Manually extract the files.

## Solution 4

Using .NET 6, run the following program using `dotnet run` (Adjust the `Path` const accordingly):

```
using System.IO.Compression;

var zipper = new dhack2021.Unzipper();
zipper.Go();

namespace dhack2021
{
    class Unzipper
    {
        public void Go()
        {
            const string Path = @"C:\Work\d-ctf2021\extract\formula-1337.zip";
            Unzip(Path);
        }
        public void Unzip(string path)
        {
            var fileInfo = new FileInfo(path);
            ZipArchive zip = new ZipArchive(System.IO.File.OpenRead(path));
            zip.ExtractToDirectory(fileInfo.DirectoryName);

            var entry = zip.Entries.FirstOrDefault();

            if (entry == null)
            {
                return;
            }

            var entryName = entry.Name;
            if (!entryName.EndsWith(".zip"))
            {
                return;
            }

            Unzip(Path.Combine(fileInfo.DirectoryName, entryName));
        }
    }
}
```

# Result
The flag is `d:ctf{Mika-Hakkinen}`.
