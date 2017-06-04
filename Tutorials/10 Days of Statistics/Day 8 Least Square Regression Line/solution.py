import math
def sqr(x):
    return [x_el * x_el for x_el in x]

def mean(x):
    if len(x) == 0:
        return 0
    return sum(x)/len(x)

def sd(x):
    if len(x) == 0:
        return 0
    return math.sqrt(mean(sqr(x)) - mean(x) * mean(x))

def pearson(x, y):
    if len(x) != len(y):
        return 0
    corr = 0
    mean_x = mean(x)
    mean_y = mean(y)
    sd_x = sd(x)
    sd_y = sd(y)
    n = len(x)
    for i in range(n):
        corr += (x[i] - mean_x) * (y[i] - mean_y)
    return corr/(n*sd_x * sd_y)

x = [95, 85, 80, 70, 60]
y = [85, 95, 70, 65, 70]

b = pearson(x, y) * sd(y)/sd(x)
a = mean(y) - b * mean(x)

print("%.3f" % round(a + b * 80, 3))