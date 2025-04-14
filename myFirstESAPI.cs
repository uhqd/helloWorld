using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

// TODO: Replace the following version attributes by creating AssemblyInfo.cs. You can do this in the properties of the Visual Studio project.
[assembly: AssemblyVersion("1.0.0.1")]
[assembly: AssemblyFileVersion("1.0.0.1")]
[assembly: AssemblyInformationalVersion("1.0")]

// TODO: Uncomment the following line if the script requires write access.
// [assembly: ESAPIScript(IsWriteable = true)]

namespace VMS.TPS
{
    public class Script
    {
        public Script()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Execute(VMS.TPS.Common.Model.API.ScriptContext context /*, System.Windows.Window window, ScriptEnvironment environment*/)
        {



            //   - - - - - - - - - - - - -    :-)      S T A R T     H E R E     Y O U R    F I R S T    CODE




            // This line will open a dialog box with a simple message
            MessageBox.Show("HELLO WORLD !!!");


            // This line will open a dialog box with a simple message and the patient ID
            if (context.PlanSetup != null)
            {
                MessageBox.Show("The following patient is open  " + context.Patient.Id);
            }




            //   - - - - - - - - - - - - -    :-)     END



        }
    }
}
