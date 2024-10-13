
def nod(a,b):
  while b:
    a,b=b,a%b
    return a
def nok(a,b):
  return(a*b)/nod(a,b)
a=int(input("Введите натуральноечисло a "))
b = int (input("Введите натуральное число b "))
NOD= nod(a,b)
NOK = nok(a,b)
print("НОД= ",NOD)
print("НОК= ", NOK)