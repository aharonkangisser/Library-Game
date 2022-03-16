using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Prog7312POE
{
   public class DeweyDecimal
    {
        private string callNumber;
        private string definition;
        private string description;
        //constructors
        public DeweyDecimal()
        {
            this.callNumber = "";
            this.definition = "";
            this.description = "";
        }
        public DeweyDecimal(string callNumber, string definition,string description)
        {
            this.callNumber = callNumber;
            this.definition = definition;
            this.description = description;
        }
        //accessors
        public string getCallNumber()
        {
            return this.callNumber;
        }
        public string getDefinition()
        {
            return this.definition;
        }
        public string getDescription()
        {
            return this.description;
        }
        //mutators
        public void setCallNumber(string callNumber)
        {
             this.callNumber = callNumber;
        }
        public void setDefinition(string definition)
        {
             this.definition = definition;
        }
        public void setDescription(string description)
        {
             this.description = description;
        }

        public bool isFullCallNumberBigger(string callNumber)
        {
            //tier 1 sorting
            //only look at 1st 3 digits
            int cNumber1= int.Parse(this.callNumber.Substring(0,3));
            int cNumber2 = int.Parse(callNumber.Substring(0, 3));

            if(cNumber1 > cNumber2)
            {
                return false;
            }
            else if (cNumber1 < cNumber2)
            {
                return true;
            }
            else
            {
                //tier 2 sorting
                int cNumber3 = int.Parse(this.callNumber.Substring(4, 2));
                int cNumber4 = int.Parse(callNumber.Substring(4, 2));
                if (cNumber3 > cNumber4)
                {
                    return false;
                }
                else if (cNumber3 < cNumber4)
                {
                    return true;
                }
                else 
                {
                    //tier 3 sorting
                    //078.53 JAM
                    //01234567
                    string cNumber5 = this.callNumber.Substring(7, 3);
                    string cNumber6 = callNumber.Substring(7, 3);
                    if (cNumber5.CompareTo(cNumber6) > 0)
                    {
                        return false;
                    }
                    else 
                    {
                        return true;
                    }                    
                }
            }

        }
    }
}
