public class Program
    {
        /// <summary>
        /// This is the main program for the Assessment
        /// To run any of the assessment, comment others out and exclude the Method (for the Assessment) you want to run.
        /// Thank you.
        /// Fatimah Bello
        /// Today June 30th 2022
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Assessment1
            Assessment1_Result();

            //Assessment2
            Assessment2_Result();

            //Assessment3
            Assessment3_Result();

            //Assessment4
            Assessment4_Result();


            //Assessment5
            Assessment5_Result();

            //Assessment6
            Assessment6_Result();

            //Assessment7
            Assessment7_Result();


            //Assessment8
            Assessment8_Result();

            //Assessment9
            Assessment9_Result();

            //Assessment10
            Assessment10_Result();

            //Assessment11
            Assessment11_Result();

            //Assessment12
            Assessment12_Result();

            //Assessment13
            Assessment13_Result();

            //Assessment14
            Assessment14_Result();

            //Assessment15
            Assessment15_Result();

            //Assessment16
            Assessment16_Result();

            //Assessment17
            Assessment17_Result();

            //Assessment18
            Assessment18_Result();

            //Assessment19
            Assessment19_Result();

            //Assessment20
            Assessment20_Result();

        }

        private static void Assessment1_Result()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int countOfValidNumbers = 0;
            Console.WriteLine("Enter two whole numbers (integers) the smaller first:");
            Console.WriteLine("Enter first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    countOfValidNumbers++;
                }
            }

            Console.WriteLine($"Between {firstNumber} and {secondNumber}, there are {countOfValidNumbers} that are divisible by 5 (a.k.a factors of 5");

        }

        private static void Assessment2_Result()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = 100;
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }

        private static void Assessment3_Result()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = 100;
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }

        private static void Assessment4_Result()
        {
            int a, b, c;
            Console.Write("a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c : ");
            c = Convert.ToInt32(Console.ReadLine());

            SolveQuadraticEquation(a, b, c);
            Console.ReadKey();


        }

        private static void Assessment5_Result()
        {
            int score = 0;
            Console.WriteLine("Score Calculator");
            Console.WriteLine("Enter a score in the range 1-9");
            score = Convert.ToInt32(Console.ReadLine());

            switch (score)
            {
                case 0:
                    Console.WriteLine("Ooops! score is not withing the range.");
                    break;
                case 1:
                case 2:
                case 3:
                    score = score * 10;
                    break;

                case 4:
                case 5:
                case 6:
                    score = score * 100;
                    break;

                case 7:
                case 8:
                case 9:
                    score = score * 1000;
                    break;

                default:
                    Console.WriteLine("Ooops! score is not withing the range.");
                    break;

            }
            Console.WriteLine($"Score = {score}");


        }

        private static void Assessment6_Result()
        {
            int number = 0;
            Console.WriteLine("Non divisible by 3 and 7 calculator");
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Printing numbers between 1 and {number} that are neither factors of 3 nor of 7");

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.Write(i + " ");
                }
            }




        }

        private static void Assessment7_Result()
        {
            Console.WriteLine("These are all the 52 cards in a standard deck");

            //var spadesSymbol = '\u2660';
            //var heartsSymbol = '\u2665';
            //var diamondsSymbol = '\u2666';
            //var clubsSymbol = '\u2663';
            for (int i = 0; i < 13; i++)// "for" loop used to change the card
            {

                for (int j = 0; j < 4; j++) // "for" loop used to change the color of the card
                {
                    string color = "";
                    char[] colorSymbol = new char[4];
                    colorSymbol[0] = '\u2663';
                    colorSymbol[1] = '\u2666';
                    colorSymbol[2] = '\u2665';
                    colorSymbol[3] = '\u2660';
                    switch (j) // switch case used for the color of the card
                    {
                        case 0:
                            color = "Clubs";
                            Console.ResetColor();// reset the console color
                            break;
                        case 1:
                            color = "Diamonds";
                            Console.ForegroundColor = ConsoleColor.Red;// make the console color red

                            break;
                        case 2:
                            color = "Hearts";
                            Console.ForegroundColor = ConsoleColor.Red;// make the console color red

                            break;
                        case 3:
                            color = "Spades";
                            Console.ResetColor();// reset the console color

                            break;
                        default:
                            Console.WriteLine("There is a mistake!");
                            break;
                    }

                    switch (i) // switch case used for the card
                    {
                        case 0:
                            Console.WriteLine("2{0}: Two of {1}", colorSymbol[j], color);
                            break;
                        case 1:
                            Console.WriteLine("3{0}: Three of {1}", colorSymbol[j], color);
                            break;
                        case 2:
                            Console.WriteLine("4{0}: Four of {1}", colorSymbol[j], color);
                            break;
                        case 3:
                            Console.WriteLine("5{0}: Five of {1}", colorSymbol[j], color);
                            break;
                        case 4:
                            Console.WriteLine("6{0}: Six of {1}", colorSymbol[j], color);
                            break;
                        case 5:
                            Console.WriteLine("7{0}: Seven of {1}", colorSymbol[j], color);
                            break;
                        case 6:
                            Console.WriteLine("8{0}: Eight of {1}", colorSymbol[j], color);
                            break;
                        case 7:
                            Console.WriteLine("9{0}: Nine of {1}", colorSymbol[j], color);
                            break;
                        case 8:
                            Console.WriteLine("10{0}: Ten of {1}", colorSymbol[j], color);
                            break;
                        case 9:
                            Console.WriteLine("J{0}: Jack of {1}", colorSymbol[j], color);
                            break;
                        case 10:
                            Console.WriteLine("Q{0}: Queen of {1}", colorSymbol[j], color);
                            break;
                        case 11:
                            Console.WriteLine("K{0}: King of {1}", colorSymbol[j], color);
                            break;
                        case 12:
                            Console.WriteLine("A{0}: Ace of {1}", colorSymbol[j], color);
                            break;
                        default:
                            Console.WriteLine("There is a mistake!");
                            break;
                    }
                }
            }




        }

        private static void Assessment8_Result()
        {
            Console.WriteLine("This program prints the sum of the first nth Fibonnacci numbers that you enter in the console.");
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = CalculateFibonnacciSum(number);

            Console.WriteLine($"The sum of the first {number}th Fibonacci numbers is: {sum}");

        }
        private static void Assessment9_Result()
        {
            //Console.WriteLine("This program prints the sum of the first nth Fibonnacci numbers that you enter in the console.");
            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int sum = CalculateFibonnacciSum(number);

            //Console.WriteLine($"The sum of the first {number}th Fibonacci numbers is: {sum}");
            Console.WriteLine("Hello World!");

        }
        private static void Assessment10_Result()
        {
            int[] numberArray = new int[20];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = i * 5;
                Console.Write(numberArray[i] + ", ");
            }

            Console.WriteLine("Hello World!");

        }
        private static void Assessment11_Result()
        {
            Console.WriteLine("Enter the first array separated by an empty space - hit ENTER when you're done typing numbers in this first array");
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Enter the second array separated by an empty space - hit ENTER when you're done typing numbers in this second array");

            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool equals = array1.Intersect(array2).Count() == array1.Union(array2).Count();

            Console.WriteLine($"Both arrays are equal: {equals}");

        }

        private static void Assessment12_Result()
        {
            Console.WriteLine("Hello World!");

        }
        private static void Assessment13_Result()
        {
            Console.WriteLine("Enter the first array separated by an empty space - hit ENTER when you're done typing numbers in this first array");
            int[] numbersArray = new int[20];
            int mostFrequentNumber = MostFrequentNumberInArray(numbersArray);

            Console.WriteLine($"The most frequently occurring number in this array is: {mostFrequentNumber}");
        }

        private static void Assessment14_Result()
        {
            Console.Write("Enter the Decimal Number to be converted to binary: ");
            int number = int.Parse(Console.ReadLine());
            int i;
            int[] numberArray = new int[10];
            for (i = 0; number > 0; i++)
            {
                numberArray[i] = number % 2;
                number = number / 2;
            }
            Console.Write("Binary format of the given Number : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(numberArray[i]);
            }
            Console.ReadKey();

        }
        private static void Assessment15_Result()
        {
            Console.Write("Enter the Binary Number to be converted to decimal: ");
            string number = Console.ReadLine();
            var decimalFormat = BinaryToDecimalConverter(number);

            Console.WriteLine($"Binary Number: {number} in Decimal Format: {decimalFormat}");
            Console.ReadKey();

        }
        private static void Assessment16_Result()
        {
            Console.Write("Enter the Decimal Number to be converted to binary: ");
            decimal number = decimal.Parse(Console.ReadLine());
            var hexadecimalFormat = number.ToString("X");

            Console.WriteLine($"Decimal Number: {number} in Hexadecimal Format: {hexadecimalFormat}");
            Console.ReadKey();

        }

        private static void Assessment17_Result()
        {
            Console.Write("Enter the Hexadecimal Number to be converted to decimal: ");
            string hexNumber = Console.ReadLine();
            var decimalFormat = Convert.ToInt32(hexNumber, 16);

            Console.WriteLine($"Hexadecimal Number: {hexNumber} in decimal Format: {decimalFormat}");
            Console.ReadKey();

        }
        private static void Assessment18_Result()
        {
            Console.Write("Enter the Hexadecimal Number to be converted to binary: ");
            string hexNumber = Console.ReadLine();
            var binaryFormat = Convert.ToString(Convert.ToInt64(hexNumber, 16), 2);

            Console.WriteLine($"Hexadecimal Number: {hexNumber} in binary Format: {binaryFormat}");
            Console.ReadKey();

        }
        private static void Assessment19_Result()
        {
            Console.WriteLine("Hello World");

        }
        private static void Assessment20_Result()
        {
           Console.WriteLine("Hello World");

        }
        static int BinaryToDecimalConverter(string bin)
        {
            int res;
            char[] cArr = bin.ToCharArray();
            Array.Reverse(cArr); // Reverse binary string
            List<int> iArr = new List<int>();
            for (int i = bin.Length - 1; i > -1; i--) // Get the bits
                iArr.Add(Int16.Parse(cArr[i].ToString()) * (int)Math.Pow(2, i)); // Calculate each bits and add to an array
            res = iArr.ToArray().Sum(); // Calculate all the numbers and add to the final result
            return res;
        }
        static int MostFrequentNumberInArray(int[] array)
        {
            //int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 0;
            int longestOccurance = 0;
            int mostFrequentNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                counter = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        counter++;
                    }
                }

                if (counter > longestOccurance)
                {
                    longestOccurance = counter;
                    mostFrequentNumber = array[i];
                }
            }

            Console.WriteLine(mostFrequentNumber);

            return mostFrequentNumber;
        }
        static int CalculateFibonnacciSum(int n)
        {
            if (n <= 0)
                return 0;

            int[] fibo = new int[n + 1];
            fibo[0] = 0; fibo[1] = 1;

            // Initialize result
            int sum = fibo[0] + fibo[1];

            // Add remaining terms
            for (int i = 2; i <= n; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
                sum += fibo[i];
            }

            return sum;
        }
        public static void SolveQuadraticEquation(double a, double b, double c)

        {

            double sqrtpart = b * b - 4 * a * c;

            double x, x1, x2, img;

            if (sqrtpart > 0)

            {

                x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);

                x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);

                Console.WriteLine("Two Real Solutions: {0,8:f4} or  {1,8:f4}", x1, x2);
            }
            else if (sqrtpart < 0)
            {
                sqrtpart = -sqrtpart;
                x = -b / (2 * a);
                img = System.Math.Sqrt(sqrtpart) / (2 * a);
                Console.WriteLine("Two Imaginary Solutions: {0,8:f4} + {1,8:f4} i or {2,8:f4} + {3,8:f4} i", x, img, x, img);
            }
            else

            {
                x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine("One Real Solution: {0,8:f4}", x);
            }

        }

    }
