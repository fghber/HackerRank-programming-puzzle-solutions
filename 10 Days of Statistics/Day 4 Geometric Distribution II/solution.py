'''
Probability of 1st failure (=success) within 5 inspections using neg. bernouli: 0.868
In 1st inspection = 0.33 
In 2nd inspection = (1-0.33) * 0.33   (Failed first time)
In 3rd inspection = (1-0.33)^2 * 0.33 (Failed 2 times in row)
In 4th inspection = (1-0.33)^3 * 0.33 (Failed 3 times in row)
In 5th inspection = (1-0.33)^4 * 0.33 (Failed 4 times in row)
'''
import functools
p= functools.reduce((lambda x, y: x/y), map(float, input().split()))
q=1-p
n = int(input())
#prob = sum(p * q**(i-1) for i in range(1, 6))
#or simply using geometric progression: 1 - q^n
print("%.3f" %(1 - q**n))