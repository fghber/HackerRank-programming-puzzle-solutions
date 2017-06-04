import numpy
#You are given a space separated list of nine integers. 
#Your task is to convert this list into a 3x3 NumPy array.
a = numpy.array(list(map(int, input().split())))
a.shape = (3,3)
print(a)