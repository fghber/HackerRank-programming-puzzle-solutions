def fact(n):
    return 1 if n == 0 else n*fact(n-1)

def comb(n, x):
    return fact(n) / (fact(x) * fact(n-x))

def pbinom(x, n, p):
    return comb(n, x) * p**x * (1-p)**(n-x)

p,n = map(int, input().split(" "))
#at most 2 bad
print(round(sum([pbinom(i, n, p/100.0) for i in range(0, 3)]), 3))
#at least 2 bad
print(round(1 - sum([pbinom(i, n, p/100.0) for i in range(0, 2)]), 3))