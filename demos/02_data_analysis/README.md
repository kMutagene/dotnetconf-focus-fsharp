In this demo, i introduced [FsLab](fslab.org), a data science package collection and project incubation space for F#.

I performed a complex analysis of a large dataset with [FsLab-endorsed packages](https://fslab.org/packages.html):
- [FSharp.Data](https://fsprojects.github.io/FSharp.Data/) to download a csv data source via Http
- [Deedle](https://fslab.org/Deedle) as the central data frame library in F# for data access and manipulation
- [FSharp.Stats](https://fslab.org/FSharp.Stats), a multipurpose library forstatistical testing, linear algebra, machine learning, fitting and signal processing in F#.
- [Plotly.NET](https://plotly.net), a mature .NET interface for the powerful plotly.js visualization library

I performed the following steps:
1. I used FSharp.Data to download a large transcriptomics (RNA sequencing time series) dataset
2. I used Deedle to read and index the data source as a dataframe
3. I used FSharp.Stats to perform surprisal analysis (a meta analysis that shows prominent, time resolved patterns in the dataset) on the time series data
4. Finally, i used Plotly.NET to visualize the result

## Additional Links:

- A more detailed guide on getting started with data analysis with FsLab: https://fslab.org/content/tutorials/4_getting-started.html
- FsLab endorsed packages: https://fslab.org/packages.html
