let evenFib = Seq.unfold (fun (a, b) -> Some(a+b, (b, a+b))) (0,1) |> Seq.filter (fun x -> x % 2 = 0)

let sum = evenFib |> Seq.takeWhile (fun x -> x < 4000000) |> Seq.sum

printfn "%i" sum
