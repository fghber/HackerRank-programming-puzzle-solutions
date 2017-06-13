open System

let print charList =
    Console.Write( "{0} ", charList |> List.toArray |> (fun a -> String a) )

let rec rotate index remaining =
    match index with
    | 0 -> ()
    | _ -> 
        let x::xs = remaining
        let rotated = xs@[x]
        print rotated
        rotate (index-1) rotated

let rotateChars input =
    input 
    |> Seq.toList
    |> rotate (Seq.length input)


[1 .. int(Console.ReadLine())]
|> List.iter (fun _ ->
    rotateChars <| Console.ReadLine()
    printfn "")
	
(* precedural solution
let n = Convert.ToInt32(Console.ReadLine())
for i=1 to n do
    let input = Console.ReadLine()
    for j=1 to input.Length do
        for k=0 to input.Length-1 do
            Console.Write(input.[(k+j)%input.Length])
        Console.Write(" ")
    Console.WriteLine()
*)
