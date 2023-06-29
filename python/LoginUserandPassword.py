#login
Us = "Dimma"
Passw = "Tutorial"
#Gantilah yang kalian ingini

#Main
print("Login\n\nMasukan User")
User = input("User >> ")
print("\n\nMasukan Password")
Password = input("Password >> ")

#Checking
if User==Us:
    if Password==Passw:
        print("Login Berhasil!")

    else:
        print("User Dan Password Tidak Sepadan")

else:
    print("User Dan Password Tidak Sepadan")
