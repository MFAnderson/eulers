let isFizzBuzzy x = (x % 3 = 0) || ( x % 5 = 0)
let ns = {1..999}
let result = ns |> Seq.filter isFizzBuzzy |> Seq.sum
printfn "%i" result
