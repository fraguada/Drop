using KangarooSolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropitlikeitshot
{
    /// <summary>
    /// Changing the access to this class to public confuses Rhino as to where the Kangaroo dll might be. Removing 'public' access modifier resolves this.
    /// Command line output below
    /// </summary>
    public class SampleGoal : GoalObject
    {
        public override void Calculate(List<Particle> p)
        {
            throw new NotImplementedException();
        }
    }
}

/*
Command: DropItLikeItsHot
System.IO.FileNotFoundException: Could not load file or assembly 'KangarooSolver, Version=2.4.2.0, Culture=neutral, PublicKeyToken=794d913993c0f82d' or one of its dependencies.The system cannot find the file specified.
File name: 'KangarooSolver, Version=2.4.2.0, Culture=neutral, PublicKeyToken=794d913993c0f82d'
   at System.Reflection.RuntimeAssembly.GetExportedTypes(RuntimeAssembly assembly, ObjectHandleOnStack retTypes)
   at System.Reflection.RuntimeAssembly.GetExportedTypes()
   at Rhino.PlugIns.PlugIn.CreateFromAssembly(Assembly pluginAssembly, Boolean displayDebugInfo, Boolean useRhinoDotNet)

=== Pre-bind state information ===
LOG: DisplayName = KangarooSolver, Version=2.4.2.0, Culture=neutral, PublicKeyToken=794d913993c0f82d
 (Fully-specified)
LOG: Appbase = file:///C:/Program Files/Rhino 6/System/
LOG: Initial PrivatePath = NULL
Calling assembly : dropitlikeitshot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null.
===
LOG: This bind starts in LoadFrom load context.
WRN: Native image will not be probed in LoadFrom context.Native image will only be probed in default load context, like with Assembly.Load().
LOG: Using application configuration file: C:\Program Files\Rhino 6\System\Rhino.exe.Config
LOG: Using host configuration file: 
LOG: Using machine configuration file from C:\Windows\Microsoft.NET\Framework64\v4.0.30319\config\machine.config.
LOG: Post-policy reference: KangarooSolver, Version= 2.4.2.0, Culture= neutral, PublicKeyToken= 794d913993c0f82d
LOG: Attempting download of new URL file:///C:/Program Files/Rhino 6/System/KangarooSolver.DLL.
LOG: Attempting download of new URL file:///C:/Program Files/Rhino 6/System/KangarooSolver/KangarooSolver.DLL.
LOG: Attempting download of new URL file:///C:/Program Files/Rhino 6/System/KangarooSolver.EXE.
LOG: Attempting download of new URL file:///C:/Program Files/Rhino 6/System/KangarooSolver/KangarooSolver.EXE.
LOG: Attempting download of new URL file:///C:/dev/Drop/bin/KangarooSolver.DLL.
LOG: Attempting download of new URL file:///C:/dev/Drop/bin/KangarooSolver/KangarooSolver.DLL.
LOG: Attempting download of new URL file:///C:/dev/Drop/bin/KangarooSolver.EXE.
LOG: Attempting download of new URL file:///C:/dev/Drop/bin/KangarooSolver/KangarooSolver.EXE.

Unable to load dropitlikeitshot.rhp plug-in: initialization failed.
Unknown command: DropItLikeItsHot
*/
