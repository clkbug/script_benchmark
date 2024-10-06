open System
open System.IO
open System.Text.RegularExpressions

let argv = fsi.CommandLineArgs

if argv.Length = 0 then
    printfn "Usage: <script> <filename>"
    1
else
    let filePath = argv.[1]
    let pattern = @"A(\d+)"
    let regex = Regex(pattern)
    let lines = File.ReadLines(filePath)

    let sum =
        lines
        |> Seq.fold
            (fun acc line ->
                match regex.Match(line) with
                | m when m.Success ->
                    let x = m.Groups.[1].Value |> int64
                    acc + x
                | _ -> acc)
            (int64 0)

    printfn "%A" sum
    0
