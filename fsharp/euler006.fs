let ns = {1..100}
let square x = x * x
let sumsquares = ns |> Seq.map square |> Seq.sum
let squaresum = ns |> Seq.sum |> square
let result = squaresum - sumsquares
printf "%i" result
