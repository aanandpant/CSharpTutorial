/*namespaces helps you to organize class files*/


namespace PointsAndLines
{

    class User
    {
        private string username;
        private int password;
        
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

            this.username = username;           
            
        }

    // a constructor without parameters
    public User()
        {
         
        }
    }
}

