#!/bin/bash
FILENAME=$1

if [ -z $FILENAME ]; then
    echo "Usage: sh ${0} <file to extract>"
else
    if ! command -v unzip > /dev/null; then
        echo "Error: You need to install unzip to continue."
        exit
    else
        i=1337
        while [ $i -gt 0 ]
        do
            f="formula-${i}.zip"
            if [ -f "${f}" ]; then
                if unzip $f > /dev/null; then
                    echo "Successfully extracted ${f}."
                    if rm -rf $f > /dev/null; then
                        echo "Cleaned up file ${f}."
                    fi
                else
                    echo "Error: Could not unzip ${f}."
                fi
            else
                echo "Error: File does not exists: ${f}."
            fi
            
            i="$(($i-1))"
        done
    fi
fi