let ns = {1..100}
let sumsquares = ns |> Seq.map (fun x -> x*x) |> Seq.sum
let squaresum = ns |> Seq.sum |> (fun x -> x*x)
let result = squaresum - sumsquares
printf "%i" result
