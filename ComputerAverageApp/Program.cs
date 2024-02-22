namespace ComputerAverageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER 5 GRADES SEPARATED BY NEW LINE ");
            double sum = 0;
            for (int i = 0; i < 5; i++)

            {
               
                double grade = Convert.ToDouble(Console.ReadLine());
                sum += grade;
            }
            double average = sum / 5;

            double roundedAverage = Math.Round(average);
            Console.WriteLine("The average is: " + average + " and round off to " + roundedAverage);
        }
    }

}
