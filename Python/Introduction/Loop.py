'''
Read an integer N and print for all integers i < N the square of i.
'''
if __name__ == '__main__':
    n = int(input())
    for i in range(0, n):
        print(i*i)
		
	#or as a one-line using list comprehenssion
	#print('\n'.join( [str(x**2) for x in range(int(input()))] ))