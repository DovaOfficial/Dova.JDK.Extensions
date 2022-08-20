using System.Reflection;

namespace Dova.JDK.Extensions;

public static class AssemblyExtensions
{
    public static IEnumerable<string> ExtractResourceFiles(this Assembly assembly)
    {
        var tmpPath = Path.GetTempPath();

        foreach (var embeddedResourcesName in assembly.GetManifestResourceNames())
        {
            byte[] fileContent;
            
            using (var stream = assembly.GetManifestResourceStream(embeddedResourcesName))
            {
                if (stream is null)
                {
                    continue;
                }
                
                using (var reader = new BinaryReader(stream))
                {
                    fileContent = reader.ReadBytes((int)stream.Length);
                }
            }
            
            var outputJarPath = Path.Combine(tmpPath, embeddedResourcesName);
            
            File.WriteAllBytes(outputJarPath, fileContent);
            
            yield return outputJarPath;
        }
    }
}