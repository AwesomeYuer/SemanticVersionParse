// See https://aka.ms/new-console-template for more information
using NuGet.Versioning;
using Semver;

Console.WriteLine($"using {nameof(NuGet)}.{nameof(NuGet.Versioning)}.{nameof(SemanticVersion)} and {nameof(Semver)}.{nameof(SemVersion)}");

var versions = new string[]
{
    "1.0.2"
    , "1.0.1"
    , "1.0.4"
    , "1.0.4-ztm.1"
    , "1.0.4-ztm8"
    , "1.0.4-ztm40"
    , "1.0.4-ztm.40"
    , "1.0.4-ztm.8"
    , "1.0.4-ztm"
    , "1.0.4-Atm4"
    , "1.0.4-Atm"
    , "1.0.4-pre-release"
    , "1.0.4-preview3.4.243"
    , "1.0.4-preview2.4.243"
    , "1.0.4-beta.4.243"
    , "1.0.1-alpha.4.243"
};

versions
    .Select
        (v => (SemanticVersion) NuGetVersion.Parse(v))
    .OrderBy
        (
            (x) =>
            {
                return x;
            }
        )
    .Zip
        (
            versions
                .Select
                    (v => SemVersion.Parse(v, SemVersionStyles.Any))
                .OrderBy
                    (
                        (x) =>
                        {
                            return x;
                        }
                    )
            , (v1, v2) =>
                {
                    return (v1, v2);
                }
        )
    .ForEach
        (
            (i, v) =>
            {
                var eq = v.v1.ToFullString () == v.v2.ToString ();
                Console.WriteLine($@"({i}): {nameof(SemanticVersion)}:""{v.v1}"" {(eq ? "==" : "!=")} {nameof(SemVersion)}:""{v.v2}""");
                return false;
            }
        )
;

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