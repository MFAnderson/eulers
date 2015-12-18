
let isPrime n = [2..(int (sqrt (float n)))] |> Seq.forall (fun x -> (n % x) = 0)
let numgen (x,y) = Some(x+1, (x+1, y+x))
let primes = Seq.unfold numgen (1, 0) |> Seq.filter isPrime |> Seq.takeWhile (fun x -> x < 2000000)
let result = Seq.nth 100 primes
printfn "%i" result
