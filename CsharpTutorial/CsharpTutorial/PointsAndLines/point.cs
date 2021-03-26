/*namespaces helps you to organize class files*/

namespace PointsAndLines
{

    class point
    {
        //the below variables are known as field variables and have to be in lowercase(It could be in uppercase, but we use lowercase just for convention purposes)
        // the access modifiers of the field variables is usually private and are not directly exposed to the 'outside world'. Their values can only be accessed via a property or some other logic in the class
        private int x;
        private int y;
        private int z;
        //public int X;
        //public int Y;

        //creating a property with get and set block of a variable 
        //a property of a variable is written to access the private members of the class outside of the class

            //start of the property block
        public int X {
            get {
                // will do some logic below as soon as the value of the variable is set

                return x;

            }

            set {
                //the value keyword sets the 'value' of the given property when the object of this class is called example 'obj.X=5'
                x = value;

            }

        }

        public int Y
        {
            get
            {
                // will do some logic below as soon as the value of the variable is set

                return y;

            }

            set
            {   //you can set your own logic below like y=value+1
                //the value keyword sets the 'value' of the given property when the object of this class is called example 'obj.X=5'
                y = value;

            }

        }

        //end of the property block with get and set blocks


        //a constructor expecting parameters
        public point(int x, int y)
        {
            //this keyword allows you to access the field variables/variables declared in the class.
            //this keyword is only used to avoid the conflict of variable names. always use the keyword this to show that you are pointing a member from your class if there is a name conflict. 
            //use based on your personal preference or company standards. 'this' keyword is optional to use.
            //'this' provides no benefits, performance. it's just a syntactic sugar.
            this.x = x;
            this.y = y;
            //this.z = y;
        }

    // a constructor without parameters
    public point()
        {
         
        }
    }
}

