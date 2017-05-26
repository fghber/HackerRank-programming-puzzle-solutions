open System
(*Given an array x, of n integers, calculate and print the standard deviation.
Your answer should be in decimal form, rounded to a scale of 1 decimal place.*)
let n = Console.ReadLine() |> float
let arr = Console.ReadLine().Split ' ' |> Array.map float

let mean = arr |> Array.average
let variance = (Array.fold (fun acc e -> acc + (pown (e - mean) 2)) 0.0 arr) / n
//let variance = arr |> Array.map (fun i -> (i-mean) ** 2.0) |> Array.sum |> (/) <| n
let sd = sqrt variance
sd |> printfn "%.1f"
0