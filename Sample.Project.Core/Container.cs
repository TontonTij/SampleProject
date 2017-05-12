using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Composition.Hosting;
using System.Runtime.Loader;

namespace Sample.Project.Core
{
    public static class Container
    {
        public static void MefInitialization()
        {
            var assemblies = Directory
                         .GetFiles(".", "*.dll", SearchOption.AllDirectories)
                         .Select(AssemblyLoadContext.GetAssemblyName)
                         .Select(Assembly.Load)
                         .ToList();

            var containerConfig = new ContainerConfiguration().WithAssemblies(assemblies);

        }
    }
}
