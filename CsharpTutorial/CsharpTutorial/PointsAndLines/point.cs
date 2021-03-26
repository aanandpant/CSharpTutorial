/*namespaces helps you to organize class files*/

namespace PointsAndLines
{

    class point
    {
        //the below variables are known as field variables and have to be in lowercase(It could be in uppercase, but we use lowercase just for convention purposes)
        public int x;
        public int y;
        public int z;
        //public int X;
        //public int Y;

        //a constructor expecting parameters
        public point(int x, int y)
        {
            //this keyword allows you to access the field variables/variables declared in the class.
            //this keyword is only used to avoid the conflict of variable names. Always use the keyword this to show that you are pointing a member from your class if there is a name conflict. 
            //use based on your personal preference or company standards. 'this' keyword is optional to use.
            //'this' provides no benefits, performance. It's just a syntactic sugar.
            this.x = x;
            this.y = y;
            this.z = y;
        }
        // a constructor without parameters
        public point()
        {
         
        }
    }
}

