// Learn more about F# at http://fsharp.org

open System
open System.IO

let readLines filePath = File.ReadLines(filePath)

let calcFuel mass =
    (mass/3) - 2

(*
    Day 1 problem
*)
let sumFuelReqs =
    let inputs = readLines "C:\\Users\\d\\source\\repos\\AoC2019\\AoC2019\\day1-input.txt"
    let mutable total = 0
    for anInput in inputs do
        total <- total + calcFuel (anInput |> int)

    total

[<EntryPoint>]
let main argv =
    printfn "Advent of Code, 2019!"
    let day1answer = sumFuelReqs
    printfn "\tDay 1 anser: %i" day1answer
    0 // return an integer exit code
