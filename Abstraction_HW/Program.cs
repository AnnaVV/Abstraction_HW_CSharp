using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_HW
{
    class Program
    {
        public static AbstractHandler DocumentAnalyser(string inputDoc)
        {
            string[] parsedStringArray = inputDoc.Split('.');

            string docExtension = parsedStringArray[1];
                switch (docExtension)
                {
                    case "txt":
                        {
                            return new TXTHandler();                  
                            //break;                         
                        }
                    case "xml":
                        {
                           return new XMLHandler();
                            //break;
                        }
                    case "doc":
                        {
                            return  new DOCHandler();
                            //break;
                        }

                    default:
                        {
                            throw new Exception("There is no handler for the specified document type");
                        }
               
                }
        }
        
        static void Main(string[] args)
        {
            string documentName = "MyDocument.txt";
            var handler = DocumentAnalyser(documentName);
            handler.Create();
            handler.Open();
            handler.Change();
            handler.Save();

            Console.ReadLine();
            
        }

        
    }
}
