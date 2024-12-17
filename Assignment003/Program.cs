namespace Assignment003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y;
            #region  Q1
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine($"The number that the user is entered {x}");

            #endregion
            #region Q2
            //string name = "Hussien";
            //int x = Convert.ToInt32(name);
            #endregion

            #region Q3
            // float y = 5.12f;
            // int x = 7;
            // float result= x+y;
            //  Console.WriteLine(result);

            #endregion

            #region Q4

            // string name = "Hussien";
            // string subname = name.Substring(2,3);
            // Console.WriteLine(subname);
            #endregion
            #region Q5

            //int x = 1;
            //int y = 2 ;
            //y = x;
            //x++;
            //Console.WriteLine(x);
            //Console.WriteLine(y); // will assign the first value of x in y before modification  
            #endregion

            // decimal x = 5.0089298M;
            // int y = (int)x;
            // Console.WriteLine(y); // lose od data

            // long z = 8956239845696;
            // int w = (int)z; 
            // Console.WriteLine(w); // overflow happened because W cannot take all of Z value and code crushes because it's not a protective code


            // long M = 894453757598432;
            //  if (M > int.MaxValue || M < int.MinValue)
            //{
            //    Console.WriteLine("Can't assign value of M in variable of type int ");
            //}
            // else
            // {
            //  int N = (int)M;
            //Console.WriteLine(N);

            // } 
            #region Q6 


            //Point P1 = new Point();
            //P1.X = 3;
            //Point P2 = new Point();
            //P2 = P1;
            //Console.WriteLine(P1.X);
            //Console.WriteLine(P2.X); // p2.x will take value of p1.x by reference and first location of p2 will be unreachable 



            #endregion



            #region Q7 

            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = x + y;
            //Console.WriteLine(z);


            #endregion

            //#region Q8
            //Console.Write("Enter the priciple : ");
            //int principle = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine(principle);
            //Console.Write("Enter the rate :");
            //float rate;
            //float.TryParse(Console.ReadLine(), out rate);
            //Console.Write("Enter the time :");
            //float time;
            //float.TryParse(Console.ReadLine(), out time);//Convert.ToSingle(Console.ReadLine());
            //Double interest = (principle * rate * time) / 100;
            //Console.WriteLine("The interest is {0}", interest);

            //#endregion


            #region Q9
            //Console.Write("Enter the weight in kg and height in meter :");
            //float weight, height;
            //float BMI;
            // float.TryParse(Console.ReadLine(), out weight);
            //float.TryParse(Console.ReadLine(), out height);
            //BMI = (weight) / (weight * height);
            // Console.WriteLine($"The BMI is {BMI}");

            #endregion


            #region Q10

            //Console.Write("Enter the degrees :");
            //int degrees = int.Parse(Console.ReadLine());
            //string weather = degrees > 10 ? (degrees > 30 ? "just hot" : "just good"):"just cold" ; 
            //Console.WriteLine(weather);
            #endregion



            #region Q11
            //Console.Write("Enter the date :");
            //int day, month, year ;
            //int.TryParse(Console.ReadLine(), out day);
            //int.TryParse(Console.ReadLine(), out month);
            //int.TryParse(Console.ReadLine(), out year);
            //Console.WriteLine($"The date today is {day},{month},{year} ");
            //Console.WriteLine($"The date today is {day}/{month}/{year} ");
            //Console.WriteLine($"The date today is {day}-{month}-{year} ");

            #endregion

            #region Q12

            //int x;
            //int.TryParse(Console.ReadLine(), out x);
            //if (x % 3 ==0 && x % 4==0 ) 
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            #endregion

            #region Q13

            //Console.Write("Enter the number :");
            //int x;
            //int.TryParse(Console.ReadLine(), out x);
            //if (x < 0 )
            //{
            //    Console.WriteLine("output : Negative ");

            //}
            //else
            //{
            //    Console.WriteLine("output : Positive");
            //}
            #endregion


            #region Q14

            //int x, y, z;
            //int.TryParse(Console.ReadLine(),out x);
            //int.TryParse(Console.ReadLine(),out y);
            //int.TryParse(Console.ReadLine(), out z);

            //if (x > y && x > z)
            //{
            //    if (y > z)
            //    {
            //        Console.WriteLine($"Max element = {x}");
            //        Console.WriteLine($"Min element = {z}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Max element = {x}");
            //        Console.WriteLine($"Min element = {y}");
            //    }
            //}
            //else if (y > x && y > z)
            //{
            //    if (x > z)
            //    {
            //        Console.WriteLine($"Max element = {y}");
            //        Console.WriteLine($"Min element = {z}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Max element = {y}");
            //        Console.WriteLine($"Min element = {x}");
            //    }
            //}
            //else if (z > x && z > y)
            //{
            //    if (x > y)
            //    {
            //        Console.WriteLine($"Max element = {z}");
            //        Console.WriteLine($"Min element = {y}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Max element = {z}");
            //        Console.WriteLine($"Min element = {x}");
            //    }
            //}

            #endregion

            #region Q15

            //int x;
            //int.TryParse(Console.ReadLine(), out x);
            //if(x%2==0)
            //{
            //    Console.WriteLine("The number is even ");

            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");
            //}
            #endregion
        }
    }
}
