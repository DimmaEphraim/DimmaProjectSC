import os
import shutil

fdir = input("Dir of folder to protect: ")
fname = input("Folder name to create: ")
pasw = input("Password: ")

todir = "C:/Users/Dimma/Desktop"
todir = os.path.join(todir,fname)
os.mkdir(todir)

for i in pasw:
    for j in range(1,11):
        path = os.path.join(todir,str(j))
        try:
            os.mkdir(path)
        except:
            print("error 1")
        for k in range(1,11):
            path2 = os.path.join(path, str(k))
            try:
                os.mkdir(path)
            except:
                print("error 2")

    todir = todir + '/' + i

try:
    shutil.move(fdir,todir)
except:
    print()
