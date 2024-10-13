s1="здравствуйтеаааА"
print(s1)
rem=s1.count("а")+s1.count("А")

result=s1.replace("а","").replace("А","")
a="а"
aa="А"
if a or aa in s1:
   print("yes")
else: print("No")
print(result)
print(rem)
print (len(s1))


