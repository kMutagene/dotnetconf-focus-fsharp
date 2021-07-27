#r "nuget: Deedle"
#r "nuget: FSharp.Data"
#r "nuget: FSharp.Stats"
#r "nuget: Plotly.NET, 2.0.0-preview.6"

open Deedle
open FSharp.Data
open FSharp.Stats
open Plotly.NET

let df = 
    Http.RequestString "https://raw.githubusercontent.com/CSBiology/TMEA/main/tests/data/Highlight_LogFPKM.csv"
    |> Frame.ReadCsvString(rawData)
    |> Frame.indexRowsString "TranscriptIdentifier"

df.ColumnKeys
|> Seq.iter (printfn "%A")

// quite a large dataset
df.Print()
df.RowCount
df.ColumnCount

open FSharp.Stats.ML

Algebra.LinearAlgebra.Service() |> ignore

let surprisalResult = 
    df 
    |> Frame.toJaggedArray
    |> Matrix.ofJaggedArray
    |> SurprisalAnalysis.compute

surprisalResult.Potentials
|> Matrix.toJaggedArray
|> Array.mapi (fun i potential ->
    Chart.Line(
        xy = (potential |> Array.indexed),
        Name = $"λ<sup>{i}</sup>"
    )
)
|> Chart.Combine
|> Chart.withTemplate ChartTemplates.lightMirrored
|> Chart.Show