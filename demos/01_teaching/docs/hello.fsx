#r "nuget: Plotly.NET, 2.0.0-preview.6" 
#r "nuget: Plotly.NET.Interactive, 2.0.0-preview.6" 

open Plotly.NET

let myChart =
    Chart.Point([(1,2)])
    |> Chart.withTitle "Hello .NET Conf from Plotly.NET!"

(***hide***)
myChart |> GenericChart.toChartHTML
(***include-it-raw***)

// notebook example: https://csbiology.github.io/BIO-BTE-12-V-4/tasks/english/wpb-task-01.html