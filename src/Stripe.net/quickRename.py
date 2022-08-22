import imp

import os
import string
from numpy import void
from sqlalchemy import false, null, true

from sympy import li

def scan_file(path : str):
    with open(path, "r") as file:
        data = file.readlines()
    
    for i in range(len(data)):
        if line_starts_with_internal(data[i]):
            print(f"Adding annotations to line {i} in {path}\n\n")
            data[i] = str.replace(str.replace(data[i], "internal", "public"), "set;", "private set;")
            data.insert(i, "        [JsonInclude]\n")
            print(f"Finished annotations to line {i} in {path}\n\n")

    with open(path, "w") as file:
        file.writelines(data)


       
            

def line_starts_with_internal(line : str):
    if str.startswith(str.strip(line), "internal ExpandableField<"):
        return True
    return False

def scan_folder(path : str, deepness = 0, max_depth = 3):
    if deepness >= max_depth:
        return None
    for item in os.scandir(path):
        if item.is_file():
            scan_file(item.path)
        if item.is_dir():
            scan_folder(item.path, deepness + 1, 3)
    return None

scan_folder("Entities")
