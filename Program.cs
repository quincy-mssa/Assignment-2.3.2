namespace Assignment_2._3._2
{
    internal class Program
    {
    static void Main()
        {
            //Enter bill total
            Console.Write("Enter your bill total: $");
            double billTotal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the percentage of tip you would like to add: ");
            double tipPercentage = Convert.ToDouble(Console.ReadLine());

            //Enter taxes
            Console.Write("Enter taxes: ");
            double taxes = Convert.ToDouble(Console.ReadLine());

            //Calculate tip amount and grand total
            double tipAmount = Math.Round(billTotal * (tipPercentage / 100), 2);
            double taxAmount = billTotal * (taxes / 100);
            double grandTotal = billTotal + tipAmount + taxAmount;

            //Display bill 
            Console.WriteLine($"\nBill Total: {billTotal:F2}");
            Console.WriteLine($"Tip ({tipPercentage}): {tipAmount:F2}");
            Console.WriteLine($"Grand Total: {grandTotal:F2}");
        }
    }
}
