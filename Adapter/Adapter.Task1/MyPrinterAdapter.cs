namespace Adapter.Task1
{
    internal class MyPrinterAdapter : IMyPrinter
    {
        private readonly Printer _printer;

        public MyPrinterAdapter(Printer printer)
        {
            _printer = printer;
        }

        public void Print<T>(IElements<T> elements)
        {
            _printer.Print(new Container<T>(elements.GetElements()));
        }
    }
}