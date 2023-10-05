//namespace app;
class UserInput{
    public void ReadLineDemo() {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Good Morning " + name + "! ");
    }

    public void ReadDemo() {
        Console.Write("Enter a letter ");
        int n =  Console.Read();
        Console.Write(n);
    }

    public void ReadKeyDemo() {
        Console.Write("Do you wish you continue ");
        char choice = Console.ReadKey().KeyChar;

        if(choice == 'y') {
            Console.Write("\nYou win");
        }else {
            Console.Write("\nYou lose");
        }
    }
 }