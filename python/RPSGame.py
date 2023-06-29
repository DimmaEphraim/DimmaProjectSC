#Tutorial membuat game gunting, kertas, batu di python
import random
import time

while True:
    print("\n\n\n\n\n\n\n")
    print("1. Gunting\n2. Kertas\n3. Batu")
    Musuh = random.choice(["Gunting", "Kertas", "Batu"])

    Option = int(input("Pilih Option >> "))
    if Option==1:
        print("Saya >> Gunting")
        print("Musuh >>", Musuh)
        if Musuh=="Gunting":
            print("Seri/Draw")
        if Musuh=="Kertas":
            print("Kamu Menang!")
        if Musuh=="Batu":
            print("Kamu Kalah :(")
        time.sleep(3)

    if Option==2:
        print("Saya >> Kertas")
        print("Musuh >>", Musuh)
        if Musuh=="Gunting":
            print("Kamu Kalah :(")
        if Musuh=="Kertas":
            print("Seri/Draw")
        if Musuh=="Batu":
            print("Kamu Menang!")
        time.sleep(3)
        
    if Option==3:
        print("Saya >> Batu")
        print("Musuh >>", Musuh)
        if Musuh=="Gunting":
            print("Kamu Menang!")
        if Musuh=="Kertas":
            print("Kamu Kalah :(")
        if Musuh=="Batu":
            print("Seri/Draw")
        time.sleep(3)
