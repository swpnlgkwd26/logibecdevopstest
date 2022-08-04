
var basePath = MakeAbsolute(Directory(".")).ToString().Replace("/", "\\");
var buildOutputPath = basePath + "\\build_output";

Task("CleanBuildOutput")
    .Does(() =>
    {

    var outputPath = buildOutputPath + "\\R__05_01_Folders.sql";
    using (var writer = new StreamWriter(outputPath))
    {
        writer.Write("Hello World")
    }

    });