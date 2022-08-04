
var basePath = MakeAbsolute(Directory(".")).ToString().Replace("/", "\\");
var buildOutputPath = basePath + "\\build_output";

Task("CleanBuildOutput")
    .Does(() =>
    {
        // Delete build output folder
        if (DirectoryExists(buildOutputPath))
            CleanDirectory(buildOutputPath);
    });