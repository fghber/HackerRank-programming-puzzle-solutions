let f arr = arr |> List.map(fun x -> abs x) (*Update the values of a list with their absolute values.*)

//----------------DON'T MODIFY---------------

let input = 
    stdin.ReadToEnd().Split '\n' 
    |> Array.map(fun x -> int(x)) 
    |> Array.toList
    
let print_out (data:int list) = List.iter (fun x -> printfn "%A" x) data

print_out (f(input))