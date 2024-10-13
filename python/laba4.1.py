a = int( input( 'Введите число a от 0 до 50 ' ) )
sum=0
if a>=0 and a<=50: 
    for i in reversed(range(100,2,-2)):
     sum +=i*i
     print(sum)
else:print("Неверное чило")