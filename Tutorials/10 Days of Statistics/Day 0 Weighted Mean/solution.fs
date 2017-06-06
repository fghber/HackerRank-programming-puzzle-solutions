open System

let inline ZipMap f a b = Seq.zip a b |> Seq.map (fun (x,y) -> f x y)
let inline mult a b = ZipMap (*) a b
let weigtedMean(x, w) = (mult x w |> Seq.sum) / (w |> Seq.sum)   

// we could also use Array.fold2 or Seq.map2, ...
// let nom = Array.fold2 (fun acc x w -> acc + x * w) 0 X W
// let nom = Seq.map2 (fun x1 x2 -> (x1, x2)) X W |> Seq.map (fun (x, w) -> x * w) |> Seq.sum
// let denom = Array.sum W
// printf "%.1f" <| (float nom) / (float denom)


[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    let seqX = Console.ReadLine().Split ' ' |> Seq.map float
    let seqW = Console.ReadLine().Split ' ' |> Seq.map float
    
    let res : float = weigtedMean(seqX, seqW)
    printfn "%f" res
	0 // return integer exit code