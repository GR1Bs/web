l = [5,4,3,4,12,6,12,8,9,10]
max_l = max(l) 
a=0 #Меньше макс
c=0
b=0 #Больше макс
for element in l:
    if element < max_l:
        a+=1
    elif element == max_l:
        c+=1    
    elif element > b:
       b +=1
    
print("максимальный элемет:", max_l)
print("Меньшн максимального числа:", a)
print ("Больше максимального числа:", b)
print ("Равные максимальному числу:",c)