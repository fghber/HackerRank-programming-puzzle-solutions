let rec fact n:int =
    match n with
    | 0 | 1 -> 1
    | _ -> n * fact(n-1)

let comb(n:int, x:int) =
    fact(n) / (fact(x) * fact(n-x))

let pbinom(x:int, n:int, p:float) =        
    (comb(n, x) |>float) * (p**float(x)) * ((1.0-p)**(n-x |>float))

let p = 1.09/2.09
let listsum = [ 3;4;5;6 ] |> List.map (fun k -> pbinom(k, 6, p)) |> List.sum 
printfn "%.3f" (listsum)