open System

//recursive version
let rec reverse list =
    match list with
    | [] -> []
    | [x] -> [x]
    | head::tail -> reverse tail @ [head]

//even faster version with temp array
let rec rev list acc =
    match list with
    | [] -> acc
    | [x] -> x::acc
    | head::tail -> rev tail (head::acc)

let readInputArray()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null && buff <> "" do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr

[<EntryPoint>]
let main argv = 
    let arr = readInputArray()
    
    reverse arr |> ignore
    for i in arr do
        printfn "%d" i
        
    0 // return an integer exit code