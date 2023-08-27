namespace OOP_in_C_
{
    internal class Student
    {
        private int roll_no;
        private string std_name;

        // ------ Data Encapsulation by data members / varaibles ------ 

        void Accept(int roll_no, string std_name)
        {
            this.roll_no = roll_no;
            this.std_name = std_name;
        }
        void display()
        {
            Console.WriteLine("Student roll no is {0} and name is {1}", roll_no, std_name);
        }
       

        // ------ Encapsulation by Constructure ------- 
        Student()
        {
            this.roll_no = 1001;
            this.std_name = "Ahsan";
            Console.WriteLine("Student roll no is {0} and name is {1}", roll_no, std_name);
        }

        Student(int r_no, string s_name)
        {
            this.roll_no = r_no;
            this.std_name = s_name;
            Console.WriteLine("Student roll no is {0} and name is {1}", roll_no, std_name);

        }

        static void Main(string[] args)
        {
            Student std = new Student();   // Non-Parameterized Constructore     
            std.Accept(1001, "Osama");
            std.display();


            Student std1 = new Student(2002, "Osama"); // Parameterized Constructore
            std1.Accept(2002, "Ahsan");
            std1.display();

        }
    }
}