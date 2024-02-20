using Seminar2.Task1;

class Program
{
    static void Main()
    {
        Market magnit = new Market();
        Actor client1 = new OrdinaryClient("Nikolay");
        Actor client2 = new OrdinaryClient("Sofia");
        Actor client3 = new SpecialClient("Putin", 1);
        TaxInspector client4 = new TaxInspector();
        
        magnit.AcceptToMarket(client1);
        magnit.AcceptToMarket(client2);
        magnit.AcceptToMarket(client3);
        magnit.AcceptToMarket(client4);
        magnit.update();

    }
}