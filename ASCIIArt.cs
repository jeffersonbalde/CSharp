using System;

class ASCIIArt {
   public void ASCIIArtD() {
      Console.Write("Enter a character: ");
      char c = (char)Console.Read();
      Console.WriteLine("ASCII art of " + c + ":");
      Console.WriteLine("   __" + c + "__");
      Console.WriteLine(@"  /     \");
      Console.WriteLine(" |   o   |");
      Console.WriteLine("(|  (_)  |)");
      Console.WriteLine(" |   |   |");
      Console.WriteLine(@" |  / \  |");
      Console.WriteLine(" |       |");
      Console.WriteLine(" |       |");
      Console.WriteLine(" |_______|");
   }
}