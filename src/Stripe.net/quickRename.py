import imp

import os
import string
from sqlalchemy import false, true

from sympy import li

# for item in os.scandir("/Entities"):
#     if item.is_file:


def scan_file(path : str):
    with open(path, "r") as file:
        data = file.readlines()
    
    for i in range(len(data)):
        if line_starts_with_internal(data[i]):
            data[i] = str.replace(str.replace(data[i], "internal", "public"), "set;", "private set;")
            data.insert(i, "        [JsonInclude]\n")

    with open(path, "w") as file:
        file.writelines(data)


       
            

def line_starts_with_internal(line : str):
    if str.startswith(str.strip(line), "internal ExpandableField<"):
        return True
    return False

scan_file("Entities\Accounts\AccountSettingsBranding.cs")