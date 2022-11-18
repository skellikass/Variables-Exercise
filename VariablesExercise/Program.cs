namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        { string myName = "Kassandra Johnson";
          int myAge = 34;
          char myGrade = 'A';
          bool myTruth = true;
          double myGradePointAvg = 3.87;
          decimal myChanceOfFailure = 0.0000000000000001m;

            Console.WriteLine($"My name is {myName}, and I am {myAge} years old.  I have always been an {myGrade} student with a ~{myGradePointAvg} grade point average, this is {myTruth}.  Therefore, I believe my chance of failure for becoming a software engineer is {myChanceOfFailure}%.");
        }
    }
}
