using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class TestXmas
    { 
        public string xx( DateTime dd)
        {
            if (dd.ToString("MM/dd")== "12/25")
                return "是聖誕節!!";
            else
                return "不是聖誕節!!";
            }
    }


    public class TestTotalArea
    {
        public string output(string Type,  int Len,  int Width,  int High,  int Radius,  int Botton)
        {
            string Msg=string.Empty;
            string ErrorMsg = "資料錯誤，無法計算面積";  
            switch (Type)
            { 
                case "Square":
                    if (Len != null && Len != 0)
                        Msg = Convert.ToString(Len * Len);
                    else
                        Msg = ErrorMsg;    
                    break;
                case "Rectangle":
                    if ( (Len != null && Len != 0) && (Width != null && Width != 0) )
                        Msg = Convert.ToString(Len * Width);
                    else
                        Msg = ErrorMsg;    
                    break;
                case "Circle":
                    if (Radius != null && Radius != 0)
                        Msg = Convert.ToString(Radius * 3.14);
                    else
                        Msg = ErrorMsg;    
                    break;
                case "Triangle":
                    if ((Len != null && Len != 0) && (Botton != null && Botton != 0))
                        Msg = Convert.ToString( (Len * Botton)/2 );
                    else
                        Msg = ErrorMsg;    
                    break;
                default :
                    Msg = "錯誤圖型";
                    break;
            }
            return Msg;
        
        }
    
    }
}
