open System
let p:float = Console.ReadLine().Split ' ' |> Seq.map float  |> Seq.reduce (fun acc x -> acc / x)
let q = 1.0-p
let n = Console.ReadLine() |> float
let geo = 1.0 - q**(n)
printf "%.3f" geo