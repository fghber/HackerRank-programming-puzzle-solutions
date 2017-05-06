number = list()
N = int(raw_input())
for i in range(N):
    number.append(str(raw_input()))

 def wrapper(f):
    def fun(l):
        f("+91 "+c[-10:-5]+" "+c[-5:] for c in l)
    return fun    

@wrapper
def standardize(number):
	return "+91" + " " + number[-10:-5] + " " + number[-5:]

print '\n'.join(standardize(number))