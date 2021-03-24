using System;
using System.Reflection;

namespace apptool
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"GetType().Assembly.GetName().Version: " +
                              $"{new Foo().GetAssemblyVersion()}");

            Console.WriteLine($"Assembly.GetEntryAssembly().GetName().Version: " +
                              $"{Assembly.GetEntryAssembly().GetName().Version}");

            Console.WriteLine($"Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyFileVersionAttribute>().Version:" +
                              $"{Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyFileVersionAttribute>().Version}");

            Console.WriteLine($"Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion:" +
                              $"{Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute> ().InformationalVersion}");

        }
    }

    class Foo
    {
        public string GetAssemblyVersion()
        {
            return GetType().Assembly.GetName().Version.ToString();
        }
    }
}
