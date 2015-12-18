let isFizzBuzzy x = (x % 3 = 0) || ( x % 5 = 0)
let result = {1..999} |> Seq.filter isFizzBuzzy |> Seq.sum
printfn "%i" result
