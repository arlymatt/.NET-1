using System;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Adult[] Names = new Adult[2];
            Names[0] = new Adult();
            Names[1] = new Child();
            //Object[] Name = new Object[2];
            //Console.WriteLine("Printing");
            for (int i = 0; i < 2; i++)
            {
             
                Console.WriteLine(Names[i]);
            }

        }
    }

    public class Adult
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Adult()
        {
            FirstName = "Arly";
            LastName = "Mathew";
        }



    }
    public class Child :Adult
    {


        public Child()
        {
            FirstName = "Joshua";
            LastName = "Mathew";
        }


    }
}

