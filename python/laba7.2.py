import math
def Geron(ab,ad,bd):
    p=(ab+ad+bd)/2
    s= math.sqrt(p*(p-ab)*(p-ad)*(p-bd))
    return s
def q(ab,bc,cd,ad,bd):
    S1=Geron(ab,ad,bd)
    S2 =Geron(bc,cd,bd)
    S=S1+S2
    return S
ab=int(input("AB="))
bc= int(input("BC="))
cd=int(input("CD="))
ad=int(input("AD="))
bd=int(input("BD="))
result_s=q(ab,bc,cd,ad,bd)
print(result_s)