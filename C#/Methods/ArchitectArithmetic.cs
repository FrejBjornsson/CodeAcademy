using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public double length;
        public double width;
        public double bottom;
        public double height;
        public double rectArea;
        public double rectArea1;
        public double rectArea2;
        public double triArea;
        public double totalArea;
        public double totalCost;

        public static void CalculateTotalCost(string placeName)
        {

            switch (placeName)
            {


                case "TAJ MAHAL":
                    {
                        double length = 90.5;
                        double width = 90.5;
                        double bottom = 24;
                        double height = 24;
                        double rectArea = (length * width);
                        double triArea = (.05 * bottom * height);
                        double totalArea = (rectArea * triArea);
                        double totalCost = Math.Round(totalArea * 180);
                        Console.WriteLine($"The plan for the Taj Mahal would could {totalCost} pesos!");
                        break;
                    }

                case "MOSQUE":
                    {
                        double length1 = 284;
                        double width1 = 264;
                        double length2 = 106;
                        double width2 = 180;
                        double bottom = 264;
                        double height = 84;
                        double rectArea1 = (length1 * width1);
                        double rectArea2 = (length2 * width2);
                        double triArea = (0.5 * bottom * height);
                        double totalArea = (rectArea1 + rectArea2 + triArea);
                        double totalCost = Math.Round(totalArea * 180);
                        Console.WriteLine($"The total cost of constructing the Grand Mosque in the modern era is {totalCost} pesos");
                        break;
                    }

                case "TEOTIHUACAN":

                    {
                        double length = 2500;
                        double width = 1500;
                        double bottom = 750;
                        double height = 500;
                        double radius = 375;
                        double cirArea = Math.PI * Math.Pow(radius, 2);
                        double rectArea = (length * width);
                        double triArea = (.05 * bottom * height);
                        double totalArea = (rectArea + triArea + cirArea);
                        double totalCost = Math.Round(totalArea * 180);
                        Console.WriteLine($"The total cost of constructing Teotihuacan in the modern era is {totalCost} pesos");
                        break;
                    }

            }

        }

        public static void Main(string[] args)
        {


            string placeName;
            Console.WriteLine("Welcome to Architect Arithmetic.\n Type in the name of one of the following buildings to see the total build cost. \n \'TEOTIHUACAN', \'MOSQUE', \'TAJ MAHAL' ");
            placeName = Console.ReadLine();
            placeName = placeName.ToUpper();
            CalculateTotalCost(placeName);

        }
    }
}
