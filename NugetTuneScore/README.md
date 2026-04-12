# NugetTuneScore

Shared **constants**, **DTOs**, and **helpers** for the TuneScore ecosystem. C# namespaces are `TuneScore.*` so your app code stays consistent.

- **Source:** [github.com/AlvaroCascoV/NugetTuneScore](https://github.com/AlvaroCascoV/NugetTuneScore)
- **Main app:** [TuneScore](https://github.com/AlvaroCascoV/TuneScore)

This package does not include EF Core entities, SQL Server sequence names, or other persistence-only constants—those belong in the API (next to `DbContext`). It does not include ASP.NET-specific types. Use the same JSON shapes as reference for front-end TypeScript or OpenAPI-generated clients.

## Install

```xml
<PackageReference Include="NugetTuneScore" Version="1.0.2" />
```

## Publish to nuget.org

From the repo root (after [creating an API key](https://www.nuget.org/account/apikeys)):

```bash
dotnet pack NugetTuneScore/NugetTuneScore.csproj -c Release -o out
dotnet nuget push out/*.nupkg out/*.snupkg --api-key YOUR_KEY --source https://api.nuget.org/v3/index.json
```

One `push` uploads both files: the **`.nupkg`** (the library, required) and the **`.snupkg`** (debug symbols for the NuGet symbol server, optional). If you do not want to publish symbols, push only `out/*.nupkg`.

Unsigned packages are normal for open-source uploads; nuget.org accepts them.

## License

Package metadata uses `MIT` ([SPDX](https://spdx.org/licenses/MIT.html)). See the `LICENSE` file in this repository.
