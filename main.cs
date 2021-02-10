using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter salesperson name:");
    string name = Console.ReadLine();

    Console.WriteLine ("Enter sales amount:");
    double sale = Convert.ToDouble(Console.ReadLine());

    double comm = 200+(0.09*sale);

    Console.WriteLine("Sales commision for " + name + " is $" +comm);

    if(sale<=2999)
    {
      Console.WriteLine("Performance is poor");
    }

    else if(sale>=3000 && sale<=4999)
    {
      Console.WriteLine("Performance is Average");
    }

    else if(sale>=5000 && sale<=9999)
    {
      Console.WriteLine("Performance is Good");
    }
    
    else if(sale>=10000 && sale<=14999)
    {
      Console.WriteLine("Performance is excellent");
    }

    else if(sale>=15000)
    {
      Console.WriteLine("Performance is outstanding");
    }

    






  }
}