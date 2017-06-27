open System

let rec fibonacci(n) =
    match n with 
    | 1 -> 0
    | 2 -> 1
    | _ -> fibonacci(n-1) + fibonacci(n-2)

let n = Console.ReadLine() |> int
Console.WriteLine(fibonacci(n))