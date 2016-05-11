using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calculatrice.Extension_Classes
{
    public static class TextBoxExtension
    {
        public static bool IsTextBoxEmpty(this TextBox textbox)
        {
            return textbox.Text.Trim() == "";
        }
    }
}
