import math
import cmath
x = float(input("Введите значение x: "))
y = float(input("Введите значение y: "))
z = float(input("Введите значение z: "))
sum = cmath.sqrt(pow(x, y) + y ** y + z ** x + ((math.exp (x)  + math.log1p (math.fabs( math.sin(y)))) / (z ** 4 * 0.87)))
print ("Результат:",'{0:.3f}'.format(sum))
#print("Результат: ",sum)