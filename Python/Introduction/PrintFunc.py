import sys
'''
Without using any string methods, try to print the sequence of numbers 123...N (without spaces)
'''
if __name__ == '__main__':
    n = int(input())
    for i in range(1,n+1):
        sys.stdout.write(str(i))
    sys.stdout.flush() 

	#or as a one-liner using the unpack operator
	#print(*range(1, int(input()) + 1), sep="") 
	