//The fslab toolbox: https://fslab.org/packages

#r "nuget: Deedle"
#r "nuget: Plotly.NET, 2.0.0-preview.6"
#r "nuget: FSharpAux"

open Deedle
open Plotly.NET
open FSharpAux

let df = Frame.ReadCsv($"{__SOURCE_DIRECTORY__}/data.csv")

df.Print()

df
|> Frame.indexRowsInt "Key"
|> Frame.toArray2D
|> Array2D.toJaggedArray
|> Chart.Heatmap
|> Chart.Show

df
|> Frame.indexRowsInt "Key"
|> Frame.fillMissingWith 0.5
|> Frame.toArray2D
|> Array2D.toJaggedArray
|> fun data -> Chart.Heatmap(data,Colorscale = StyleParam.Colorscale.Electric)
|> Chart.withTitle "a function call that returns the truth"
|> Chart.Show

// less of a toy example: https://fslab.org/content/tutorials/4_getting-started.html
