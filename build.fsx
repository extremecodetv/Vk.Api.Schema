// include Fake lib
#r "packages/FAKE/tools/FakeLib.dll"
open Fake

// Properties
let buildDir = FullName "./build/"

let apikey = getBuildParam "apikey"
let version = getBuildParam "version"

Target "Clean" (fun _ ->
   CleanDir buildDir
)

Target "Build" (fun _ -> 
   XMLHelper.XmlPokeInnerText "./src/Vk.Api.Schema/Vk.Api.Schema.csproj" "/Project/PropertyGroup/Version" version

   DotNetCli.Restore (fun p -> p)

   DotNetCli.Build (fun p -> 
   { p with
      Project = "./src/Vk.Api.Schema/Vk.Api.Schema.csproj"
      Configuration = "Release"
   })

   ()

   DotNetCli.Pack (fun p -> 
   { p with
      OutputPath = buildDir
      Project = "./src/Vk.Api.Schema/Vk.Api.Schema.csproj"
   })
)

Target "PublishNuget" (fun _ -> 
   Paket.Push (fun nugetParams -> 
    { nugetParams with
        ApiKey = apikey
        WorkingDir = buildDir
    }
   )
)

Target "Default" (fun _ ->
   trace "Hello World from FAKE"
)

// Dependencies
"Clean"
   ==> "Build"
   //==> "PublishNuget"
   ==> "Default"

// start build
RunTargetOrDefault "Default"