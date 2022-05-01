using System;
namespace LearnToFly.SolidPrinciples
{
    // Interface Segregation Principle states that client should not be forced to implement irrelevant methods.
    // Rather than one fat interface, multiple small interfaces are preffered based on group of relavant methods.
    public class InterfaceSegregation
    {
        public InterfaceSegregation()
        {
        }

        //Problem statement
        // we have an interface IprinterTasks, which has multiple methods
        // 1. print, 2. scan, 3. fax, 4. printDuplex
        // now lets say different Printer classes HPlaserJetPrinter and LiquidInkInjector implement this interface
        // they will have to implement all the methods provided in interface, even when few methods do not belong to them
        // as in LiquidInkInjector Printer does not have printDuplex functionality.


        //Solution
    }
    public interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }
    interface IFaxTasks
    {
        void Fax(string content);
    }
    interface IPrintDuplexTasks
    {
        void PrintDuplex(string content);
    }

    public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks,
                                     IPrintDuplexTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }
    }

    class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }
}
