class Program
{
    static void Main(string[] args)
    {
        /*  
        Create a console application that uses the Main() method to ask the user to input an integer
        and then calls a method called MultiplicatiobTable() to display the results of multiplying an integer 
        by each of the number 2 through 10
        */
        Console.WriteLine("We are going to creat a multiplication table,please enter a number");

       int number = int.Parse(Console.ReadLine());

        MultiplicationTable(number);
       
    }

    public static void MultiplicationTable(int number)
    {
            for (int i = 2; i < 11; i++)
            {
                int answer = number*i;
                    Console.WriteLine("{0,2} * {1,2} = {2,2}",i,number, answer);
            }
}
}
