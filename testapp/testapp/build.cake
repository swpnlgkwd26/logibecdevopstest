 

Task("CleanBuildOutput")
    .Does(() =>
    {
    using (var writer = new StreamWriter("testapp/testapp/build.ps1"))
    {
        writer.WriteLine("Write-Host 'Swapnil Gaikwad Script Run 2.'");
    }

    });

RunTarget("CleanBuildOutput");
