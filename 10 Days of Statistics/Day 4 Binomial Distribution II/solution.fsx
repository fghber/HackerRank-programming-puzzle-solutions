open System

let rec fact n:int =
    match n with
    | 0 | 1 -> 1
    | _ -> n * fact(n-1)

let comb(n:int, x:int) =
    fact(n) / (fact(x) * fact(n-x))

let pbinom(x:int, n:int, p:float) =        
    (comb(n, x) |>float) * (p**float(x)) * ((1.0-p)**(n-x |>float))

let input = Console.ReadLine().Split ' '
let p = Convert.ToDouble(input.[0])/100.0
let n = Convert.ToInt32(input.[1])
let atmost2 = [ 0;1;2 ] |> List.map (fun k -> pbinom(k, n, p)) |> List.sum 
printfn "%.3f" (atmost2)
let atleast2 = [ 2..10 ] |> List.map (fun k -> pbinom(k, n, p)) |> List.sum 
printfn "%.3f" (atleast2)