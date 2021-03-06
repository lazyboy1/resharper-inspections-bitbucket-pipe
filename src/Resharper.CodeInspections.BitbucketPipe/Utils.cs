﻿using System;

namespace Resharper.CodeInspections.BitbucketPipe
{
    internal static class Utils
    {
        public static string GetRequiredEnvironmentVariable(string variableName) =>
            Environment.GetEnvironmentVariable(variableName) ??
            throw new RequiredEnvironmentVariableNotFoundException(variableName);

        public static string GetFoundIssuesString(int numOfIssues) =>
            numOfIssues > 0 ? $"Found {numOfIssues} issue(s)" : "No issues found";

        public static string GetFoundIssuesString(int numOfIssues, string solutionName) =>
            $"{GetFoundIssuesString(numOfIssues)} in solution {solutionName}";



        public static string EnvironmentName { get; } = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT") ?? "Production";
        public static bool IsDevelopment { get; } = EnvironmentName.Equals("Development", StringComparison.OrdinalIgnoreCase);

    }
}
