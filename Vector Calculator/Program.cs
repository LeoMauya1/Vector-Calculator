using System;

namespace Vector_Calculator
{
    class Program
    {


        static void Main(string[] args)
        {
            int UserInputX;
            int UserInputY;
            int UserInputZ;
            int User2InputX;
            int User2InputY;
            int User2InputZ;
            int User3InputX;
            int User3InputY;
            int User3InputZ;
            int User4InputX;
            int User4InputY;
            int User4InputZ;
            int User5InputX;
            int User5InputY;
            int User5InputZ;
            int UserScale;
            int User6InputX;
            int User6InputY;
            int User6InputZ;
            string UserNumber;
            int User7InputX;
            int User7InputY;
            int User7InputZ;
            int User8InputX;
            int User8InputY;
            int User8InputZ;
            int User9InputX;
            int User9InputY;
            int User9InputZ;
            int User10InputX;
            int User10InputY;
            int User10InputZ;
            int User11InputX;
            int User11InputY;
            int User11InputZ;
            int User12InputX;
            int User12InputY;
            int User12InputZ;
            int User13InputX;
            int User13InputY;
            int User13InputZ;




            Console.WriteLine(" TO ADD, PICK THE X VALUE FOR YOUR FIRST VECTOR.");
            UserNumber = Console.ReadLine();
            UserInputX = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Y");
            UserNumber = Console.ReadLine();
            UserInputY = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Z");
            UserNumber = Console.ReadLine();
            UserInputZ = Convert.ToInt32(UserNumber);
            Vector test1 = new Vector(UserInputX, UserInputY, UserInputZ);
            Console.WriteLine("NOW PICK THE NEXT VALUES FOR THE SECOND VECTOR, STARTING WITH X");
            UserNumber = Console.ReadLine();
            User2InputX = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Y");
            UserNumber = Console.ReadLine();
            User2InputY = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Z");
            UserNumber = Console.ReadLine();
            User2InputZ = Convert.ToInt32(UserNumber);
            Vector test2 = new Vector(User2InputX, User2InputY, User2InputZ);
            System.Threading.Thread.Sleep(1000);
            Console.Write("CUh-");
            System.Threading.Thread.Sleep(500); Console.WriteLine("CALCULATING-");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(".");
            Console.WriteLine(Vector.Add(test1, test2));
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(" PICK TWO VECTORS TO SUBTRACT. OR REMAIN WITH THE ONES YOU HAVE PICKED.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(" REMAIN?| NEW NUMBER");

            string UserResponse = Console.ReadLine();
            if (UserResponse == "REMAIN")
            {
                Console.WriteLine(Vector.Subtract(test1, test2));
            }
            else if (UserResponse == "NEW NUMBER")
            {
                Console.WriteLine(" OKAY BUD, PICK YOUR FIRST X VALUE");
                UserNumber = Console.ReadLine();
                UserInputX = Convert.ToInt32(UserNumber);
                Console.WriteLine("THE Y");
                UserNumber = Console.ReadLine();
                UserInputY = Convert.ToInt32(UserNumber);
                Console.WriteLine("THE Z");
                UserNumber = Console.ReadLine();
                UserInputZ = Convert.ToInt32(UserNumber);
                Vector test3 = new Vector(UserInputX, UserInputY, UserInputZ);
                Console.WriteLine("NOW PICK THE NEXT VALUES FOR THE SECOND VECTOR, STARTING WITH X");
                UserNumber = Console.ReadLine();
                User2InputX = Convert.ToInt32(UserNumber);
                Console.WriteLine("THE Y");
                UserNumber = Console.ReadLine();
                User2InputY = Convert.ToInt32(UserNumber);
                Console.WriteLine("THE Z");
                UserNumber = Console.ReadLine();
                User2InputZ = Convert.ToInt32(UserNumber);
                Vector test4 = new Vector(User2InputX, User2InputY, User2InputZ);
                System.Threading.Thread.Sleep(1000);
                Console.Write("SU-");
                System.Threading.Thread.Sleep(500); Console.WriteLine("SUBTRACTING-");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(".");
                Console.WriteLine(Vector.Subtract(test3, test4));

            }
            else
            {

                Console.Write("you probably made a spelling mistake, here let me prompt the options again ( last chance.)");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(".");
                Console.WriteLine("REMAIN?| NEW NUMBER");
                UserResponse = Console.ReadLine();

                if (UserResponse == "REMAIN")
                {
                    Console.WriteLine(Vector.Subtract(test1, test2));
                }


               if (UserResponse == "NEW NUMBER")
               {
                    Console.WriteLine(" OKAY BUD, PICK YOUR FIRST X VALUE");
                    UserNumber = Console.ReadLine();
                    UserInputX = Convert.ToInt32(UserNumber);
                    Console.WriteLine("THE Y");
                    UserNumber = Console.ReadLine();
                    UserInputY = Convert.ToInt32(UserNumber);
                    Console.WriteLine("THE Z");
                    UserNumber = Console.ReadLine();
                    UserInputZ = Convert.ToInt32(UserNumber);
                    Vector test3 = new Vector(UserInputX, UserInputY, UserInputZ);
                    Console.WriteLine("NOW PICK THE NEXT VALUES FOR THE SECOND VECTOR, STARTING WITH X");
                    UserNumber = Console.ReadLine();
                    User2InputX = Convert.ToInt32(UserNumber);
                    Console.WriteLine("THE Y");
                    UserNumber = Console.ReadLine();
                    User2InputY = Convert.ToInt32(UserNumber);
                    Console.WriteLine("THE Z");
                    UserNumber = Console.ReadLine();
                    User2InputZ = Convert.ToInt32(UserNumber);
                    Vector test4 = new Vector(User2InputX, User2InputY, User2InputZ);
                    System.Threading.Thread.Sleep(1000);
                    Console.Write("SU-");
                    System.Threading.Thread.Sleep(500); Console.WriteLine("SUBTRACTING-");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine(".");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine(".");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine(".");
                    Console.WriteLine(Vector.Subtract(test3, test4));

                }

            }

            


           

            




            Console.WriteLine("PICK SOME NEW VECTOR VALUES TO NEGATE, STARTING WITH YOUR X.");
            UserNumber = Console.ReadLine();
            User3InputX = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Y");
            UserNumber = Console.ReadLine();
            User3InputY = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Z");
            UserNumber = Console.ReadLine();
            User3InputZ = Convert.ToInt32(UserNumber);
            Vector test5 = new Vector(User3InputX, User3InputY, User3InputZ);
            Console.WriteLine(Vector.Negate(test5));
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("PICK SOME NEW VECTOR VALUES TO FIND THE MAGNITUDE OF.");
            UserNumber = Console.ReadLine();
            User4InputX = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Y");
            UserNumber = Console.ReadLine();
            User4InputY = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Z");
            UserNumber = Console.ReadLine();
            User4InputZ = Convert.ToInt32(UserNumber);
            Vector test6 = new Vector(User4InputX, User4InputY, User4InputZ);
            Console.WriteLine(test6.GetMagnitude());



            Console.WriteLine("PICK SOME NEW VECTOR VALUES TO FIND THE DIRECTION OF.");

            UserNumber = Console.ReadLine();
            User5InputX = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Y");
            UserNumber = Console.ReadLine();
            User5InputY = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Z");
            UserNumber = Console.ReadLine();
            User5InputZ = Convert.ToInt32(UserNumber);
            Vector test7 = new Vector(User5InputX, User5InputY, User5InputZ);
            Console.WriteLine(test7.GetDirection());


            Console.WriteLine("PICK A NUMBER TO SCALE YOUR VECTOR BY.");
             UserNumber = Console.ReadLine();
             UserScale = Convert.ToInt32(UserNumber);

            Console.WriteLine("PICK SOME NEW VECTOR VALUES TO FIND THE SCALE OF");
            UserNumber = Console.ReadLine();
            User6InputX = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Y");
            UserNumber = Console.ReadLine();
            User6InputY = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Z");
            UserNumber = Console.ReadLine();
            User6InputZ = Convert.ToInt32(UserNumber);
            Vector test8 = new Vector(User6InputX, User6InputY, User6InputZ);
            Console.WriteLine(Vector.Scale(test8, UserScale));






            Console.WriteLine("PICK SOME NEW VECTOR VALUES TO NORMALIZE, STARTING WITH THE X");
            UserNumber = Console.ReadLine();
            User7InputX = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Y");
            UserNumber = Console.ReadLine();
            User7InputY = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Z");
            UserNumber = Console.ReadLine();
            User7InputZ = Convert.ToInt32(UserNumber);
            Vector test9 = new Vector(User7InputX, User7InputY, User7InputZ);
            Console.WriteLine(Vector.Normalize(test9));




            Console.WriteLine("PICK SOME NEW VECTOR VALUES TO GET THE DOT PRODUCT OF, STARTING WITH YOUR X");
            UserNumber = Console.ReadLine();
            User8InputX = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Y");
            UserNumber = Console.ReadLine();
            User8InputY = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Z");
            UserNumber = Console.ReadLine();
            User8InputZ = Convert.ToInt32(UserNumber);
            Vector test10 = new Vector(User8InputX, User8InputY, User8InputZ);
            Console.WriteLine(" YOUR NEXT VECTOR, STARTING WITH THE X");
            UserNumber = Console.ReadLine();
            User9InputX = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Y");
            UserNumber = Console.ReadLine();
            User9InputY = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Z");
            UserNumber = Console.ReadLine();
            User9InputZ = Convert.ToInt32(UserNumber);
            Vector test11 = new Vector(User9InputX, User9InputY, User9InputZ);
            Console.WriteLine(Vector.DotProduct(test11,test10));





            Console.WriteLine("PICK SOME NEW VECTOR VALUES TO GET THE CROSS PRODUCT OF, STARTING WITH YOUR X");
            UserNumber = Console.ReadLine();
            User10InputX = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Y");
            UserNumber = Console.ReadLine();
            User10InputY = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Z");
            UserNumber = Console.ReadLine();
            User10InputZ = Convert.ToInt32(UserNumber);
            Vector test12 = new Vector(User10InputX, User10InputY, User10InputZ);
            Console.WriteLine(" YOUR NEXT VECOTOR, STARTING WITH THE X");
            UserNumber = Console.ReadLine();
            User11InputX = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Y");
            UserNumber = Console.ReadLine();
            User11InputY = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Z");
            UserNumber = Console.ReadLine();
            User11InputZ = Convert.ToInt32(UserNumber);
            Vector test13 = new Vector(User11InputX, User11InputY, User11InputZ);
            Console.WriteLine(Vector.CrossProduct(test12, test13));




            Console.WriteLine("PICK SOME NEW VECTOR VALUES TO PROJECT ONTO. YOUR FIRST VECTOR WILL PROJECT ONTO THE NEXT, STARTING WITH THE X");
            UserNumber = Console.ReadLine();
            User12InputX = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Y");
            UserNumber = Console.ReadLine();
            User12InputY = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Z");
            UserNumber = Console.ReadLine();
            User12InputZ = Convert.ToInt32(UserNumber);
            Vector test14 = new Vector(User12InputX, User12InputY, User12InputZ);
            Console.WriteLine(" YOUR NEXT VECOTOR, STARTING WITH THE X");
            UserNumber = Console.ReadLine();
            User13InputX = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Y");
            UserNumber = Console.ReadLine();
            User13InputY = Convert.ToInt32(UserNumber);
            Console.WriteLine("THE Z");
            UserNumber = Console.ReadLine();
            User13InputZ = Convert.ToInt32(UserNumber);
            Vector test15 = new Vector(User13InputX, User13InputY, User13InputZ);
            Console.WriteLine(Vector.ProjectOnto(test14, test15));







        }
    }
}
