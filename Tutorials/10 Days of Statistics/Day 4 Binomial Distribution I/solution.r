input<-file('stdin', 'r')

readdnum <- function(){
  l <- readLines(input, n = 1)
  data = as.numeric(unlist(strsplit(l, " ", fixed = TRUE)))
  return(data)
}

d <- readdnum()
p <- d[1]
n <- d[2]

writeLines(sprintf("%.3f",sum(dbinom(3:6,6,p/(1+p)))))