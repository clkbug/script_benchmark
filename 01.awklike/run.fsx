open System
open System.IO

[<EntryPoint>]
let main argv =
    if argv.Length < 1 then
        printfn "Usage: <program> <filename>"
        1
    else
        let filename = argv.[0]
        let mutable sum = 0

        try
            use reader = new StreamReader(filename)
            let mutable lineNumber = 0

            while not reader.EndOfStream do
                let line = reader.ReadLine()

                if lineNumber > 0 then
                    let numbers = line.Split('\t') |> Array.map int
                    sum <- sum + (Array.sum numbers)

                lineNumber <- lineNumber + 1

            printfn "%d" sum
            0
        with
        | :? FileNotFoundException ->
            printfn "File not found: %s" filename
            1
        | ex ->
            printfn "An error occurred: %s" (ex.Message)
            1
