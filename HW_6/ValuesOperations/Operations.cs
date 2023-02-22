using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6.ValuesOperations
{
    internal class Operations
    {
        public void Swap(ref int a, ref int b)
        {
            int temp=a; 
            a=b;
            b=temp;
        }
        public void CountFigures(int a,out int amount)
        {
            amount = 0;
            
            for(int i=0;i<a.ToString().Length;i++)
            {
                amount++;
            }
            
        }
        public void ReturnSymbol(string str,int d,out string symbol)
        {
            symbol=string.Empty;
            for(int i=0;i<str.Length;i++)
            {
                if(i==d)
                    symbol = str[i].ToString();
            }
        }
    }
}
