﻿using System.Reflection;

[assembly: AssemblyProduct("Beds Protector")]
[assembly: AssemblyCompany("Bed")]
[assembly: AssemblyCopyright("Copyright (C) K019")]

#if DEBUG

[assembly: AssemblyConfiguration("Debug")]
#else

[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyVersion("1.1.2")]
[assembly: AssemblyFileVersion("1.1.2")]
[assembly: AssemblyInformationalVersion("v1.1.2 | Public Version")]