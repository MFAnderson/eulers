open System

let factors x = [2L..int64(Math.Sqrt(double(x)))] |> Seq.filter (fun n -> x % n = 0L)

let isPrime n = factors n |> Seq.length = 0
let primes = Seq.unfold (fun (x,y) -> Some(x+1L, (x+1L, y+x))) (1L, 0L) |> Seq.filter isPrime 
let result = Seq.nth 10000 primes
printfn "%i" result
