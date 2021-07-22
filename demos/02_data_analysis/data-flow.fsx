//The fslab toolbox: https://fslab.org/packages

#r "nuget: Deedle"
#r "nuget: Plotly.NET, 2.0.0-preview.6"
#r "nuget: FSharpAux"

open Deedle
open Plotly.NET
open FSharpAux

Frame.ReadCsv($"{__SOURCE_DIRECTORY__}/data.csv")
|> Frame.indexRowsInt "Key"
|> Frame.fillMissingWith 0.5
|> Frame.toArray2D
|> Array2D.toJaggedArray
|> fun data -> Chart.Heatmap(data,Colorscale=StyleParam.Colorscale.Electric)
|> Chart.withTitle "A true statement"
|> Chart.Show
