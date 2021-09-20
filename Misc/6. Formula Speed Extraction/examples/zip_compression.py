# To create the archive series, this is one solution to prepare the files (ending at 1337)
from zipfile import ZipFile

file_to_compress = 'solution.txt'

for n in range(1, 1338):
    zip_name = f"formula-{n}.zip"

    try:
        with ZipFile(zip_name, mode='w') as zf:
            zf.write(file_to_compress)
    finally:
        print(f"Compressed the file to {zip_name}")
    
    file_to_compress = zip_name