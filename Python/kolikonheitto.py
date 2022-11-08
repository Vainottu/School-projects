


import random

kruuna = int(0)
klaava = int(0)

n = int(input("Kuinka monta kertaa kolikkoa heitetään?"))

for i in range(n):

  luku = random.randint(0,1)

  if luku == 0:

    print("Klaava")

    klaava = klaava + 1

  if luku == 1:

    print("Kruuna")

    kruuna = kruuna + 1