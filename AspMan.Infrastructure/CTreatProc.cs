using System;
using System.Collections.Generic;
using System.Text;
using AspMan.Infrastructure.Interfaces;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AspMan.Infrastructure
{
    public static class CTreatProc 
    {
        public static int ToDigit(object dump)
        {
            try
            {
                return Convert.ToInt32(dump.ToString());
            }
            catch
            {
                return -1;
            }
        }
    }
}
