#tool "nuget:?package=xunit.runner.console"
//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

var version = EnvironmentVariable ("APPVEYOR_BUILD_VERSION") ?? Argument("version", "0.0.9999");

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

// Define directories.
var artifactsDir  = Directory("./artifacts/");
var rootAbsoluteDir = MakeAbsolute(Directory("./")).FullPath;

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() =>
{
    CleanDirectory(artifactsDir);
});

Task("Restore-NuGet-Packages")
    .IsDependentOn("Clean")
    .Does(() =>
{
    NuGetRestore("./Vk.Api.Schema.sln");
});

Task("BuildPackages")
    .IsDependentOn("Restore-NuGet-Packages")
	.IsDependentOn("RunTests")
    .Does(() =>
{
    var nuGetPackSettings = new NuGetPackSettings
	{
		OutputDirectory = rootAbsoluteDir + @"\artifacts\",
		IncludeReferencedProjects = true,
		Version = version,
		Properties = new Dictionary<string, string>
		{
			{ "Configuration", "Release" }
		}
	};

	 MSBuild("./src/Vk.Api.Schema/Vk.Api.Schema.csproj", new MSBuildSettings().SetConfiguration("Release"));
     NuGetPack("./src/Vk.Api.Schema/Vk.Api.Schema.csproj", nuGetPackSettings);
});

Task("BuildTests")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() =>
{
	var parsedSolution = ParseSolution("./Vk.Api.Schema.sln");

	foreach(var project in parsedSolution.Projects)
	{
	
	if(project.Name.EndsWith(".Tests"))
		{
        Information("Start Building Test: " + project.Name);

        MSBuild(project.Path, new MSBuildSettings()
                .SetConfiguration("Debug")
                .SetMSBuildPlatform(MSBuildPlatform.Automatic)
                .SetVerbosity(Verbosity.Minimal)
                .WithProperty("SolutionDir", @".\")
                .WithProperty("OutDir", rootAbsoluteDir + @"\artifacts\_tests\" + project.Name + @"\"));
		}
	
	}    

});

Task("RunTests")
    .IsDependentOn("BuildTests")
    .Does(() =>
{
    Information("Start Running Tests");
    XUnit2("./artifacts/_tests/**/*.Tests.dll");
});

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("RunTests")
	.IsDependentOn("BuildPackages");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);