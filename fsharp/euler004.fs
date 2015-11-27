let isPalindrome x =
    let arr = x.ToString().ToCharArray()
    Array.rev arr |> Seq.compareWith Operators.compare arr |> (=) 0

let ns = {100..999}
let cross x = Seq.map ((*) x) ns
let result = ns |> Seq.collect cross |> Seq.filter isPalindrome |> Seq.max
printf "%i" result
