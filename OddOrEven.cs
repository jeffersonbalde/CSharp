using System;

class OddOrEven {
    public void OddOrEvenP() {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        if(n % 2 == 0){
            Console.Write(n + " is even");
        }else {
            Console.Write(n + " is odd");
        }

    }        
}