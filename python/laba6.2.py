print ("Введите 10 чисел")
array =[]
for i in range(10):
    num=int(input("1:"))
    array.append(num)
sum=0
for num in array:
   if num>5:
       sum +=num
print (sum)
    