/*namespaces helps you to organize class files*/


namespace PointsAndLines
{

    class User
    {
        private string username;
        private int password;

        /*static keyword is used to call a variable/method before/without class instantiation, which means that you can access a valute of a variable, or call a function without creating the object of that class.*/
        public static int currentID;

        //There are two types of constants, const and readonly
        //const=The value of the variable is constant throughout the class
        //readOnly=The value of the variable can't be set outside of the class

        public readonly int id;
        public const int WEIGHT = 40;


        //We are gonna make our Username readOnly using the get and set the value of the username using the constructor
        public string Username {
            get {
               

                return "The user name is : "+username;
                

            }

  

        }

        //We are gonna make our Password WriteOnly using set 
        public int Password
        {


            set
            {

                if (value >= 4 && value <= 10)
                {
                    password = value;

                }
                else
                {
                    System.Console.WriteLine("Oopsie!! This is not a valid Password. Please enter a password between values of 4 and 10");
                }
                

            }

        }


   
        public User(string username)
        {
            currentID++;
            id = currentID;
            this.username = username;           
            
        }

    // a constructor without parameters
    public User()
        {
            currentID++;
            id = currentID;
        }
    }
}

