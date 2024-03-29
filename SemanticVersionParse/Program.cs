﻿// See https://aka.ms/new-console-template for more information
using NuGet.Versioning;
using Semver;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine($"using {nameof(NuGet)}.{nameof(NuGet.Versioning)}.{nameof(SemanticVersion)} and {nameof(Semver)}.{nameof(SemVersion)}");

var versions = new string[]
{
    "1.0.2"
    , "1.0.4"
    , "1.0.4-ztm.1"
    , "1.0.4-ztm8"
    , "1.0.4-ztm40"
    , "1.0.4-ztm.40"
    , "1.0.4-ztm.8"
    , "1.0.4-ztm"
    , "1.0.4-Atm4"
    , "1.0.004-Atm"
    , "1.0.4-pre-release"
    , "1.0.4-preview3.4.243"
    , "1.0.4-preview2.4.243"
    , "1.0.4-beta.4.243"
    , "1.0.1-alpha.4.243"
    , "1.0.1"
    //, "1.0.1.900"
    , "1.01"
    , "1.001.01"

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
                var v1 = v.v1;
                var v2 = v.v2;
                var textEqual = v1.ToFullString () == v2.ToString ();

                Console.WriteLine($"{v1.GetType().Name}: {v1.Release}, {v1.IsPrerelease}" );
                Console.WriteLine($"{v2.GetType().Name}: {v2.Prerelease}, {v2.IsPrerelease}");

                if (!textEqual)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($@"({i}): {v1.GetType().Name}:""{v1}"" {(textEqual ? "==" : "!=")} {v2.GetType().Name}:""{v2}""");
                if (!textEqual)
                {
                    Console.ResetColor();
                }

                Console.WriteLine($"===================================");
                return false;
            }
        )
;

Console.ReadLine();

public static class LinqHelper
{
    public static void ForEach<T>(this IEnumerable<T> @this, Func<int, T, bool> eachProcessFunc)
    {
        var i = 0;
        foreach (T x in @this)
        {
            i ++;
            if (eachProcessFunc(i, x))
            {
                break;
            }
        }
    }
}