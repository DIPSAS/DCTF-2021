from zipfile import ZipFile
import os

file_to_decompress = 'formula-1337.zip'

for n in range(1337, 0, -1):

    zip_name = f"formula-{n}.zip"

    try:
        with ZipFile(zip_name, mode='r') as zf:
            zf.extractall()
    finally:
        print(f"Decompressed the file {zip_name}")
        os.remove(zip_name)