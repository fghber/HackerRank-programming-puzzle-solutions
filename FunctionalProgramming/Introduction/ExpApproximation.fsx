open System

// calculates the factorial: n! = 1 * 2 * 3 * ... * n
let rec factorial n =
    match n with
    | 0 | 1 -> 1
    | _ -> n * factorial (n - 1)

let expApprox(x:float) =
    seq { for n in 0..9 do yield x**(n |>float)/(factorial(n) |>float) } |> Seq.sumBy (fun x -> x)
  
let solveInput =
    let n = Console.ReadLine() |> int
    let mutable key = Console.ReadLine()
    while not (key = null) do    
        printfn "%A" (expApprox (key |> float))
        key <- Console.ReadLine()

[<EntryPoint>]
let main argv = 
    solveInput |> ignore
    0