// See https://aka.ms/new-console-template for more information
using NuGet.Versioning;
using Semver;

Console.WriteLine($"using {nameof(NuGet)}.{nameof(NuGet.Versioning)}");

new SemanticVersion[]
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
    )
.ForEach
    (
        (i, x) =>
        {
            Console.WriteLine($"({i}): {x}");
            return false;
        }
    );

Console.WriteLine($"using {nameof(Semver)}");
new SemVersion[]
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
    )
.ForEach
    (
        (i, x) =>
        {
            Console.WriteLine($"({i}): {x}");
            return false;
        }
    );

Console.WriteLine("Hello, World!");
Console.ReadLine();


public static class LinqHelper
{
    public static void ForEach<T>(this IEnumerable<T> @this, Func<int, T, bool> processFunc)
    {
        var i = 0;
        foreach (T x in @this)
        {
            i ++;
            if (processFunc(i, x))
            {
                break;
            }
        }
    }
}