module EasyDashboard.Host.Entry

    open Microsoft.Extensions.Hosting
    
    [<EntryPoint>]
    let main argv =
        let hostBuilder = Host.CreateDefaultBuilder(argv)
        hostBuilder
            .Build()
            .Run()
        0