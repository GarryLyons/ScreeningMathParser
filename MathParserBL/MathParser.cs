using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MathParserBL
{
    public class MathParser
    {
        public MPReturnObject Calculate(string Value)
        {

            MPReturnObject ro = new MPReturnObject();
            try
            {
                string CalculatedVal = RecursiveCalculate(Value);
                ro.IsValid = true;
                ro.Answer = Convert.ToDecimal(CalculatedVal);
                ro.Description = "Successfull parsed";
            }
            catch (Exception ex)
            {
                ro.IsValid = false;
                ro.Answer = -1;
                ro.Description = ex.Message;
            }
            return ro; 
        }

        private string RecursiveCalculate(string Value)
        {
            string returnVal = "";
            Regex Brackets = new Regex(@"e\w*f");

            Regex SumIt = new Regex(@"\d*[c|a|d|b]\d*");
            if (Brackets.IsMatch(Value))
            {
                Match m = Brackets.Match(Value);
                string pumpin = m.Value.Substring(1, m.Value.Length - 2);// m.Value.Replace("e", "").Replace("f", "");
                Value = Value.Replace(m.Value, RecursiveCalculate(pumpin));
            }
            
            if (SumIt.IsMatch(Value))
            {
                Match m = SumIt.Match(Value);
                Value = Value.Replace(m.Value, CalcString(m.Value));
                Value = RecursiveCalculate(Value);
            }
            //else
            //{
                returnVal = Value;
            //}
            
            return returnVal;
        }



        private string CalcString(string Value)
        {
            decimal calV = 0;  
            if (Value.Contains("a"))
            {
                List<string> vals = Value.Split('a').ToList();
                calV = Convert.ToDecimal(vals[0]) + Convert.ToDecimal(vals[1]);
            }
            else if (Value.Contains("b"))
            {
                List<string> vals = Value.Split('b').ToList();
                calV = Convert.ToDecimal(vals[0]) - Convert.ToDecimal(vals[1]);
            }
            else if (Value.Contains("c"))
            {
                List<string> vals = Value.Split('c').ToList();
                calV = Convert.ToDecimal(vals[0]) * Convert.ToDecimal(vals[1]);
            }
            else if (Value.Contains("d"))
            {
                List<string> vals = Value.Split('d').ToList();
                calV = Convert.ToDecimal(vals[0]) / Convert.ToDecimal(vals[1]);
            }
            return calV.ToString();
            

            
        }
    }
}
