open System

let sqr x = x |> List.map(fun i -> i*i)
let sum x = x |> List.sum

let mean(x) : float =
    match x with
    | [] -> 0.0
    | _ -> sum(x)/x.Length |> float

let sd(x:int list) : float =
    match x with
    | [] -> 0.0
    | _ -> Math.Sqrt(mean(sqr(x)) - mean(x) * mean(x))

let ols(x:int list, y:int list, point:float) : float =
    let mean_x:float = mean(x)
    let mean_y:float = mean(y)
    let sd_x:float = sd(x)
    let sd_y:float = sd(y)
    let n:float = x.Length |>float
    let corr:float = List.fold2(fun acc xi yi -> acc + ((xi|>float) - mean_x) * ((yi|>float) - mean_y)) 0.0 x y
    let pearson:float = corr/(n * sd_x * sd_y) |>float
    let b:float = pearson * (sd_y|>float)/(sd_x|>float)
    let a:float = (mean_y|>float) - b * (float mean_x)
    a + b * point

(*Determine the equation of the best-fit line using least squares,
then compute and print the value of y when x=80*)
let x = [95; 85; 80; 70; 60]
let y = [85; 95; 70; 65; 70]
printfn "%.3f" (ols(x,y,80.0))