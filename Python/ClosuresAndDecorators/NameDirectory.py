def formal(ns):
    first,last,age,sex = ns
    return ('Mr. ' if sex == 'M' else 'Ms. ') + first + ' ' + last
    
def std(f):
    def inner(ns):
        return map(formal, f(ns))
    return inner
    
@std
def nsort(ns):
    return [x[1] for x in sorted(enumerate(ns), key=lambda x: (x[1][2],x[0]))]

n = int(raw_input())
for x in nsort([raw_input().split() for x in range(n)]):
    print x