using System;
namespace LearnToFly.SolidPrinciples
{
    // class(module) should be open for extension but close for modification
    public class OpenClose
    {
        public OpenClose()
        {
        }

        public void Main(string[] args)
        {
            InvoiceOC FInvoice = new FinalInvoice();
            InvoiceOC PInvoice = new ProposedInvoice();
            InvoiceOC RInvoice = new RecurringInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.ReadKey();
        }
    }

    public class InvoiceOC
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
    }

    public class FinalInvoice : InvoiceOC
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }
    public class ProposedInvoice : InvoiceOC
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }
    public class RecurringInvoice : InvoiceOC
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }
}
