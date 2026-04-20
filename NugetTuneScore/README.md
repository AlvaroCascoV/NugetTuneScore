# NugetTuneScore

Shared **entities**, **DTOs**, **constants**, and **helpers** for the TuneScore ecosystem. C# namespaces are `NugetTuneScore.*`.

- **Source:** [github.com/AlvaroCascoV/NugetTuneScore](https://github.com/AlvaroCascoV/NugetTuneScore)
- **Main app:** [TuneScore](https://github.com/AlvaroCascoV/TuneScore)

This package is intended as a shared contract and utility layer between TuneScore services and .NET clients. It includes reusable entities and DTOs in `Models`, constants in `Constants`, and helper utilities in `Helpers` to keep behavior and data shapes consistent across projects.

It does not include ASP.NET host/runtime concerns (controllers, middleware, program startup, etc.).

## Install

```xml
<PackageReference Include="NugetTuneScore" Version="1.0.5" />
```

## Publish to nuget.org

From the repository root (after [creating an API key](https://www.nuget.org/account/apikeys)):

```bash
dotnet pack NugetTuneScore/NugetTuneScore.csproj -c Release -o out
dotnet nuget push out/*.nupkg out/*.snupkg --api-key YOUR_KEY --source https://api.nuget.org/v3/index.json
```

One `push` uploads both files: the **`.nupkg`** (library, required) and the **`.snupkg`** (debug symbols for the NuGet symbol server, optional). If you do not want to publish symbols, push only `out/*.nupkg`.

Unsigned packages are normal for open-source uploads; nuget.org accepts them.

## License

Package metadata uses `MIT` ([SPDX](https://spdx.org/licenses/MIT.html)). See the `LICENSE` file in this repository.
