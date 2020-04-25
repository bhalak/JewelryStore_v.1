using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelry_Store
{
    internal class Constituents
    {
        internal static int numComponents = 1;
        internal Label componentLabel { get; set; }
        internal ComboBox comboBox { get; set; }
        internal Label massLabel { get; set; }
        internal TextBox textBox { get; set; }

        internal Constituents(Label componentL, ComboBox comboBox, Label massL, TextBox textBox)
        {
            this.componentLabel = componentL;
            this.comboBox = comboBox;
            this.massLabel = massL;
            this.textBox = textBox;
        }
        internal Constituents() { }
    }
}
