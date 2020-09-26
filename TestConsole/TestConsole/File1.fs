module File1

let prefix prefixStr baseStr =
    prefixStr + ", " + baseStr


let names = ["John"; "Reed"; "Franklin"]

let exclaim s =
    s + "!"

names
|> Seq.map (prefix "Hello")
|> Seq.map exclaim
|> Seq.sort
|> Seq.iter (printfn "%s")

