using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Barangay_Clearance_System
{
    /* NOTE
        
        * PANGALANAN LAHAT NG TOOLS/COMPONENTS. GUMAMIT NG PascalCase PARA SA PANGALAN NG TOOLS

            Example:
                Sabihin nating gagawa kayo ng button. Pangalanan mo yung button base sa kung anong function nya.
                Halimbawa gagawa kayo ng button para sa pagprint. Ang ilalagay nyo sa name niya ay "PrintButton"

        * Sundin ang naming convention ng C# sa pagcode
        
            variables, fields, parameters = camelCase
            classes, functions, constants = PascalCase

        * Huwag kayong maglagay ng mga blank functions. Like pag ni-double click nyo yung label, automatically
        magcrecreate siya ng Label_Clicked na function. Kung wala namang ilalagay sa loob ng function na yun, tanggalin niyo nalang
        tas ayusin nyo yung designer after.

     */

    // Automated Barangay Clearance System
    // LSPU-SCC BSCS 3B-IS (BATCH 2024-2025)
    // An Automated Barangay Clearance System for Barangay Banago, created by the LSPU-SCC BSCS 3B-IS (BATCH 2024-2025)

    public class Main
    {
        public static readonly string databasePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "barangay_clearance.db"
        );

        public static readonly string connectionString = $@"Data Source={databasePath};Version=3;";
    }
}
