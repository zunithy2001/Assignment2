namespace Assignment2___4D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            double mathMark, phyMark, chemMark;

            Console.Write("Enter Student Name: ");
            studentName = Console.ReadLine();


            Console.Write("Enter Your Maths Mark: ");
            while (!double.TryParse(Console.ReadLine(), out mathMark))
            {
                if (mathMark < 0 || mathMark <= 100)
                {
                    Console.WriteLine("Mark Should be a positive integer!! Enter your Maths Mark: ");
                }
            }

            Console.Write("Enter Your Physics Mark: ");
            while (!double.TryParse(Console.ReadLine(), out phyMark))
            {
                if (phyMark < 0 || phyMark <= 100)
                {
                    Console.WriteLine("Mark Should be a positive integer!! Enter your Maths Mark: ");
                }
            }

            Console.Write("Enter Your Chemstry Mark: ");
            while (!double.TryParse(Console.ReadLine(), out chemMark))
            {
                if (chemMark < 0 || chemMark <= 100)
                {
                    Console.WriteLine("Mark Should be a positive integer!! Enter your Maths Mark: ");

                }
            }

            //calculating marks
            double totalMark1 = mathMark + phyMark + chemMark;
            double totalMark2 = mathMark + phyMark;

            //checking eligibility
            if ((mathMark >= 65 && phyMark >= 55 && chemMark >= 50) || (totalMark1 >= 180 || totalMark2 >= 140))
            {
                Console.WriteLine($"Congratulations {studentName}!! You are Eligible to get Admission");
            }
            else
            {
                Console.WriteLine($"Sorry {studentName}!! You are not Eligible");
            }
        }
    }
}
