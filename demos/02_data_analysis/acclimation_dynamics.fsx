#r "nuget: FSharp.Data"
#r "nuget: Deedle"
#r "nuget: FSharp.Stats"
#r "nuget: Plotly.NET, 2.0.0-preview.6"

open FSharp.Data
open Deedle
open FSharp.Stats
open Plotly.NET

let dataSource = "https://raw.githubusercontent.com/CSBiology/TMEA/main/tests/data/Highlight_LogFPKM.csv"

let df = 
    dataSource
    |> Http.RequestString 
    |> Frame.ReadCsvString
    |> Frame.indexRowsString "TranscriptIdentifier"

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
|> Array.skip 1
|> Array.take 3
|> Chart.Combine
|> Chart.withTemplate ChartTemplates.lightMirrored
|> Chart.withTitle "Main components dynamics"
|> Chart.Show


























// |> Chart.withTemplate ChartTemplates.lightMirrored
// |> Chart.withTitle "Surprisal Analysis results of high light time series"
// |> Chart.withX_AxisStyle "Timepoint"
// |> Chart.withY_AxisStyle "Potential"