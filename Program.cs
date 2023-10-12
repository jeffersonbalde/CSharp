namespace app;
class Program
{
    //UserInput ui = new UserInput();
    static void Main(string[] args)
    {
        UserInput ui = new UserInput();
        //ui.ReadLineDemo();
        //ui.ReadDemo();
        //ui.ReadKeyDemo();

        OddOrEven oe = new OddOrEven();
        //oe.OddOrEvenP();
        ASCIIArt asc = new ASCIIArt();
        asc.ASCIIArtD();
    }
}