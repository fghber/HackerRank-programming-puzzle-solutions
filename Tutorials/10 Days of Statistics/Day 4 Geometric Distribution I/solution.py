'''
The probability that a machine produces a defective product is 1/3. What is the probability that the 5th defect is found during the inspection?
'''
import functools
p= functools.reduce((lambda x, y: x/y), map(float, input().split()))
q=1-p
n = int(input())
print(round(q**(n-1)*p,3))

#py2
# p= reduce((lambda x, y: x/y), map(float, raw_input().split()))
# q=1-p
# n = int(input())
# print(round(q**(n-1)*p,3))