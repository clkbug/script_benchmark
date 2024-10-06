open System
open System.IO


let argv = fsi.CommandLineArgs

if argv.Length < 1 then
    printfn "Usage: <program> <filename>"
    1
else
    let filename = argv.[1]
    let mutable sum = int64 0

    try
        use reader = new StreamReader(filename)
        let mutable lineNumber = 0

        while not reader.EndOfStream do
            let line = reader.ReadLine()

            if lineNumber > 0 then
                let numbers = line.Split('\t') |> Array.map int64 |> Array.sum
                // let numbers = line.Split('\t') |> Array.fold (fun acc x -> acc + int64 x) (int64 0)
                sum <- sum + numbers

            lineNumber <- lineNumber + 1

        printfn "%A" sum
        0
    with
    | :? FileNotFoundException ->
        printfn "File not found: %s" filename
        1
    | ex ->
        printfn "An error occurred: %s" (ex.Message)
        1
