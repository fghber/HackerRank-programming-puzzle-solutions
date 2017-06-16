open System
(*Count the number of elements in an array without using count, size or length operators (or their equivalents).*)

let len arr = arr |> List.sumBy(fun x -> 1) (*sum up the elements mapped to 1*)

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr

let main =    
    let arr = read_and_parse()
    printf "%A" <| len arr