using System;
using System.Collections.Generic;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;

public class FilePatternMatcher
{
    public static void Main(string[] args)
    {
        // Define the directory to search in and the patterns to match.
        var directoryPath = @"C:\path\to\your\directory";
        var includePatterns = new[] { "*.txt", "*.md" }; // Include all text and markdown files
        var excludePatterns = new[] { "secret-*" }; // Exclude any files starting with 'secret-'

        // Instantiate a Matcher with the specified patterns.
        var matcher = new Matcher();
        matcher.AddIncludePatterns(includePatterns);
        matcher.AddExcludePatterns(excludePatterns);

        // Execute the match operation on the specified directory.
        var directoryInfo = new DirectoryInfoWrapper(new DirectoryInfo(directoryPath));
        var matchedFiles = matcher.Execute(directoryInfo).Files;

        // Output the matched files.
        Console.WriteLine("Matched files:");
        foreach (var file in matchedFiles)
        {
            Console.WriteLine(file.Path);
        }
    }
}
