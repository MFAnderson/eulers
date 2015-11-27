let x = [1 .. 999]
let sum = List.fold (fun acc x -> acc+x) 0 (List.filter (fun x -> (x % 3 = 0) || (x % 5 = 0)) x)
printfn "%i" sum
