using System;
using System.Collections.Generic;
using System.Text;

namespace Extension
{
  
    public static class ExtensionClass
    {
        public static string ToCurrency(this string str)
        {
            try
            {
                int isNumber = Convert.ToInt32(str);
                string outputString = "$" + isNumber;
                return outputString;
            }
            catch(Exception)
            {
                throw;
            }
        }
       
    }

}
