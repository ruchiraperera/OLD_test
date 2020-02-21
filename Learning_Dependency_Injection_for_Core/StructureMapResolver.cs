using StructureMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Dependency_Injection_for_Core
{
    public class StructureMapResolver : Registry
    {
        public StructureMapResolver()
        {
            Scan(_ =>
            {
                _.TheCallingAssembly();
                _.WithDefaultConventions();

            });
        }
    }
}
