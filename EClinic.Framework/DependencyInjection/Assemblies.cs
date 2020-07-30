using EClinic.Framework.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace EClinic.Framework.DependencyInjection
{
    public static class Assemblies
    {
        public static Assembly[] Get()
        {
            /* "Framework": {
             *      "AssemblyPatterns": "ProjectName.*.dll"
             * }
             */

            string assemblyPatternsStr = (AppConfigs.Instance["Framework:AssemblyScanPattern"] ?? string.Empty).Trim();

            if (string.IsNullOrEmpty(assemblyPatternsStr))
                return null;

            string[] assemblyPatterns = assemblyPatternsStr.Contains(";") ? assemblyPatternsStr.Split(';') : new string[] { assemblyPatternsStr };
            string[] assemblyRemovePatterns = assemblyPatterns.Where(a => a.StartsWith("!")).Select(a => a.Replace("!", string.Empty).Trim()).ToArray();

            var assemblies = new List<Assembly>();

            foreach (var pattern in assemblyPatterns)
            {
                if (string.IsNullOrEmpty(pattern.Trim()))
                    continue;

                List<Assembly> matchedAssemblies = AppDomain.CurrentDomain.GetAssemblies().Where(a => Regex.IsMatch(a.ManifestModule.Name.ToLower(), pattern.ToLower())).ToList();

                if (matchedAssemblies?.Count > 0)
                    assemblies.AddRange(matchedAssemblies);
            }

            foreach (var pattern in assemblyRemovePatterns)
            {
                assemblies.RemoveAll(a => Regex.IsMatch(a.ManifestModule.Name.ToLower(), pattern.ToLower()));
            }

            return assemblies.ToArray();
        }
    }
}