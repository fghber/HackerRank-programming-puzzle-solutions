a <- readLines("stdin" , warn = FALSE)
a <- strsplit(a[[1]]," ")
a <- as.numeric(a[[1]])
p <- (a[1]/100)
sum1  = dbinom(0, size=a[2], prob=p) + dbinom(1, size=a[2], prob=p) + dbinom(2, size=a[2], prob=p)
#sum2 = 0
#for(i in 2:a[2] ){
#    sum2 = sum2 + dbinom(i, size=a[2], prob=p)  
#}
sum2  = 1.0 - dbinom(0, size=a[2], prob=p) - dbinom(1, size=a[2], prob=p)

at_most2 <- round(sum1,3)
at_least2 <- round(sum2,3)
cat(at_most2)
cat("\n")
cat(at_least2)