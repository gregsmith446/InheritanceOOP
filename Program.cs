using System;

/* You are given two classes, Person and Student, where Person is the base class and Student is the derived class. 
 * Completed code for Person and a declaration for Student are provided for you in the editor.
 * Observe that Student inherits all the properties of Person.
 */

namespace _12Inheritance
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

     /*Complete the Student class by writing the following:
      * A Student class constructor, which has 4 parameters:
      * A string, firstName.
      * A string, lastName.
      * An integer, id.
      * An integer array (or vector) of test scores, scores.
      * A char calculate() method that calculates a Student object's average and returns the grade character representative of their calculated average:
      */

    class Student : Person
    {
        private int[] testScores;

        // begin constructor: construct a student based on the parent --> Person class
        public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
        {
            testScores = scores;
        }

        // calcuates student's average + returns respective grade char
        public char Calculate()
        {
            int sum = 0;
            char ch = 'O';

            for (int i = 0; i < testScores.Length; i++)
            {
                sum = sum + testScores[i];
            }

            int total = (sum / testScores.Length);

            if (total <= 100 && total >= 90)
                ch = 'O';
            else if (total < 90 && total >= 80)
                ch = 'E';
            else if (total < 80 && total >= 70)
                ch = 'A';
            else if (total < 70 && total >= 55)
                ch = 'P';
            else if (total < 55 && total >= 40)
                ch = 'D';
            else if (total < 40)
                ch = 'T';
            return ch;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Provide First Name, Last Name, Student ID #");
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            Console.WriteLine("Total # of Scores");
            int numScores = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} Space Separated Grades", numScores);
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            Console.WriteLine("\nRESULTS");
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            /* The locked stub code in your editor calls your Student class constructor and passes it the necessary arguments. 
             * It also calls the calculate method (which takes no arguments).
             */
            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
}
 
 