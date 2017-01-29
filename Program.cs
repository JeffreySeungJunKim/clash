using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC
{
/*army camp Troop Capacity  Barracks
 * 1        20              1
 * 2        30              2
 * 3        35              3
 * 4        40              4
 * 5        45              5
 * 6        50              6
 * 7        55              7
 * 8        60              8
 *                          9
 *                          10
 *                          11
 *                          12
 * 
 * 
 */                         
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
