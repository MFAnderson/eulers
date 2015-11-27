let fib = Seq.unfold (fun (a, b) -> Some(a+b, (b, a+b))) (0,1)
let evenFib = Seq.filter (fun x -> x%2 = 0) fib
let sum = evenFib |> Seq.takeWhile (fun x -> x < 4000000) |> Seq.sum
printfn "%i" sum
