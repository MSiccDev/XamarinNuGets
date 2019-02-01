using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinNugets
{
    public static partial class Hello
    {
        public static string Name { get; set; }

        public static string Platform { get; set; }

        public static void Print()
        {
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Platform))
                System.Diagnostics.Debug.WriteLine($"Hello {Name} from {Platform}");
            else
                System.Diagnostics.Debug.WriteLine($"Hello unkown person from {Device.iOS}");
        }
    }
}
