/*namespaces helps you to organize class files*/


namespace PointsAndLines
{

    class User
    {
        private string username;
        private int password;
        

        public string Username {
            get {
               

                return "The user name is : "+username;
                

            }

            set {
                if (value.Length >= 4 && value.Length <= 10)
                {
                    username = value;
                    
                }
                else
                {
                    System.Console.WriteLine("Oopsie!! This is not a valid username. Please enter a username of length between 4 to 10 characters");
                }
                

            }

        }

        public int Password
        {
            get
            {
                

                return password;

            }

            set
            {

                if (value >= 4 && value <= 10)
                {
                    password = value;

                }
                else
                {
                    System.Console.WriteLine("Oopsie!! This is not a valid Password. Please enter a password between values of 4 to 10");
                }
                

            }

        }


   
        public User(string username, int password)
        {

            this.username = username;
            this.password = password;
            //this.z = password;
        }

    // a constructor without parameters
    public User()
        {
         
        }
    }
}

