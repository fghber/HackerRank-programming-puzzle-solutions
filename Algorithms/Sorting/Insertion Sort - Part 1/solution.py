def insertionSort(ar,m):
    i=m-1
    temp=ar[i]
    while(ar[i-1]>temp and i>0):
        ar[i]=ar[i-1]
        print(' '.join(map(str,ar)))
        i-=1
    ar[i]=temp
    print(' '.join(map(str,ar)))
    return ar

m = int(input())
ar= list(map(int, input().split()))
ar=insertionSort(ar,m)