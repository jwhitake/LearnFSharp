﻿// Learn more about F# at http://fsharp.org

open System

let SayHello() =
    printfn("Hello")


[<EntryPoint>]
let main argv =
    SayHello()
    Console.ReadKey() |> ignore
    0 // return an integer exit code
