open System

let factors x = [2L..int64(Math.Sqrt(double(x)))] |> Seq.filter (fun n -> x % n = 0L)

let isPrime n = factors n |> Seq.length = 0

let maxFactor n = factors n |> Seq.filter isPrime |> Seq.max

let result = maxFactor 600851475143L

printf "%i" result
