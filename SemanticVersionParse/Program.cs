// See https://aka.ms/new-console-template for more information
using NuGet.Versioning;
using Semver;

Console.WriteLine($"using {nameof(NuGet)}.{nameof(NuGet.Versioning)}");
var query1 = new SemanticVersion[]
{
      NuGetVersion.Parse("1.0.2")
    , NuGetVersion.Parse("1.0.1")
    , NuGetVersion.Parse("1.0.4")
    , NuGetVersion.Parse("1.0.4-ztm.1")
    , NuGetVersion.Parse("1.0.4-ztm8")
    , NuGetVersion.Parse("1.0.4-ztm40")
    , NuGetVersion.Parse("1.0.4-ztm.40")
    , NuGetVersion.Parse("1.0.4-ztm.8")
    , NuGetVersion.Parse("1.0.4-ztm")
    , NuGetVersion.Parse("1.0.4-Atm4")
    , NuGetVersion.Parse("1.0.4-Atm")
    , NuGetVersion.Parse("1.0.4-pre-release")
    , NuGetVersion.Parse("1.0.4-preview3.4.243")
    , NuGetVersion.Parse("1.0.4-preview2.4.243")
    , NuGetVersion.Parse("1.0.4-beta.4.243")
    , NuGetVersion.Parse("1.0.1-alpha.4.243")
}
.OrderBy
    (
        (x) =>
        {
            return x;
        }
    );

foreach (var x in query1)
{
    Console.WriteLine(x);
}

Console.WriteLine($"using {nameof(Semver)}");
var query2 = new SemVersion[]
{
      SemVersion.Parse("1.0.2" ,SemVersionStyles.Any)
    , SemVersion.Parse("1.0.1" ,SemVersionStyles.Any)
    , SemVersion.Parse("1.0.4", SemVersionStyles.Any)
    , SemVersion.Parse("1.0.4-ztm.1", SemVersionStyles.Any)
    , SemVersion.Parse("1.0.4-ztm8", SemVersionStyles.Any)
    , SemVersion.Parse("1.0.4-ztm40", SemVersionStyles.Any)
    , SemVersion.Parse("1.0.4-ztm.40", SemVersionStyles.Any)
    , SemVersion.Parse("1.0.4-ztm.8", SemVersionStyles.Any)
    , SemVersion.Parse("1.0.4-ztm", SemVersionStyles.Any)
    , SemVersion.Parse("1.0.4-Atm3", SemVersionStyles.Any)
    , SemVersion.Parse("1.0.4-Atm", SemVersionStyles.Any)
    , SemVersion.Parse("1.0.4-pre-release", SemVersionStyles.Any)
    , SemVersion.Parse("1.0.4-preview3.4.243", SemVersionStyles.Any)
    , SemVersion.Parse("1.0.4-preview2.4.243", SemVersionStyles.Any)
    , SemVersion.Parse("1.0.4-beta.4.243", SemVersionStyles.Any)
    , SemVersion.Parse("1.0.1-alpha.4.243", SemVersionStyles.Any)

}
.OrderBy
    (
        (x) =>
        {
            return x;
        }
    );

foreach (var x in query1)
{
    Console.WriteLine(x);
}

Console.WriteLine("Hello, World!");
Console.ReadLine();
