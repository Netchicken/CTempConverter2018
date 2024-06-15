using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Windows.Forms.Tools;

namespace CTempConverter2018.Business
{
    public class TempCalc
    {

        //fields
        //Properties  propfull   prop

        //public string Fah { get; set; }
        //public string Cel { get; set; }

        public string Name { get; set; }

        //Methods
        public String ConvertFahToCel(string Fah)
        {
            Single Fahrenheit = Convert.ToSingle(Fah);
            Single Celsius = (float)((5.0 / 9.0) * (Fahrenheit - 32.0));
            return Celsius.ToString();
        }

        public string CeToFah(string cel)
        {
            // Input Cell and Fah
            Single Celsius = Convert.ToSingle(cel);
            //work out the fahrenheit
            Single Fahrenheit = (float)(Celsius * (9.0 / 5.0) + 32);
            //show the fahrenheit on the form
            return Convert.ToString(Fahrenheit);

        }



    }
}
