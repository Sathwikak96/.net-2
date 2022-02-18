0.//C# program to print the message "Hello"?<br>
<br>
<br>
using System;<br>
namespace Exercises<br>
{<br>
    class Hello<br>
    {<br>
        static void Main(string[] args)<br>
        {<br>
            Console.WriteLine("Hello World!");<br><br>
        }<br>
    }<br>
}
<br>
![image](https://user-images.githubusercontent.com/97940151/154411539-dfd58d8a-e107-4ac3-866e-26dc91fc0e8e.png)
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
1.//C# program to print Binary Triangle?<br>
<br>
<br>
using System;<br>
namespace Exercises<br>
{<br>
    class BinaryTriangle<br>
    {<br>
        static void Main(string[] args)<br>
        {<br>
            int number,digit = 1;<br>
            Console.Write("\n enter the number of lines:");<br>
            number = Convert.ToInt32(Console.ReadLine());<br>
            for (int i = 1; i <= number; i++)<br>
            {<br>
                for (int space = number - i; space > 0; space--)<br>
                {<br>
                    Console.Write(" ");<br>
                }<br>
                for (int j = 0; j < i; j++)<br>
                {<br>
                    Console.Write(digit + " ");<br>
                    digit = (digit == 1) ? 0 : 1;<br>
                }<br>
                Console.Write("\n");<br>
            }<br>
        }<br>
    }<br>
}<br>
![image](https://user-images.githubusercontent.com/97940151/154412318-6b99905d-72dd-4a6d-91db-ba19106e7508.png)
<br>
<br>
<br>
<br>
<br>
<br>
<br>
2.//C# program to check whether the entered number is an Amicable number or not?<br>
using System;<br>
namespace Exercises<br>
{<br>
    class AmicableNumber<br>
    {<br>
        static void Main(string[] args)<br>
        {<br>
            int num1, num2, sum1 = 0, sum2 = 0;<br>
            Console.WriteLine("\n--------AMICABLE NUMBERS-----------\n");<br>
            Console.Write("\nEnter the first number: ");<br>
            num1 = Convert.ToInt32(Console.ReadLine());<br>
            Console.Write("\nEnter the second number: ");<br>
            num2 = Convert.ToInt32(Console.ReadLine());<br>
            for (int i = 1; i < num1; i++)<br>
            {<br>
                if (num1 % i == 0)<br>
                {<br>
                    sum1 += i;<br>
                }<br>
            }<br>
            for (int i = 1; i < num2; i++)<br>
            {<br>
                if (num2 % i == 0)<br>
                {<br>
                    sum2 += i;<br>
                }<br>
            }<br>
            if (sum1 == num2 && sum2 == num1)<br>
            {<br>
                Console.WriteLine("\nThe numbers {0} and {1} are amiciable.", num1, num2);<br>
            }<br>
            else<br>
            {<br>
                Console.WriteLine("\nThe numbers {0} and {1} are not amiciable.", num1, num2);<br>
            }<br>
        }<br>
    }<br>
}<br>
<br>
<br>
![image](https://user-images.githubusercontent.com/97940151/154628940-a3073499-ebd6-4d4b-9dbe-7a3b11b7ad6f.png)
<br>
![image](https://user-images.githubusercontent.com/97940151/154629167-d9e8b9b2-fc4e-41b6-b426-f653ab5c3467.png)
<br>
<br>
<br>
<br>
<br>
3.//C# program to illustrate Multilevel Inheritance with Virtual methods?<br>
<br>
<br>
using System;<br>
namespace Exercises<br>
{<br>
    class PersonalDetails<br>
    {<br>
        string name;<br>
        int age;<br>
        string gender;<br>
        public PersonalDetails(string name, int age, string gender)<br>
        {<br>
            this.name = name;<br>
            this.age = age;<br>
            this.gender = gender;<br>
        }<br>
        public virtual void Display()<br>
        {<br>
            Console.WriteLine("\n-----------PERSONAL DETAILS-----------\n");<br>
            Console.WriteLine("Name :" + name);<br>
            Console.WriteLine("Age :" + age);<br>
            Console.WriteLine("Gender :" + gender);<br>
        }<br>
    }<br>
    class CourseDetails : PersonalDetails<br>
    {<br>
        int regNo;<br>
        string course;<br>
        int semester;<br>
        public CourseDetails(string name, int age, string gender, int regNo, string course, int semester) : base(name, age, gender)<br>
        {<br>
            this.regNo = regNo;<br>
            this.course = course;<br>
            this.semester = semester;<br>
        }<br>
    public override void Display()<br>
        {<br>
            base.Display();<br>
            Console.WriteLine("/n-------------CourseDetails-----------\n");<br>
            Console.WriteLine("Register Number:" + regNo);<br>
            Console.WriteLine("Course:" + course);<br>
            Console.WriteLine("Semester:" + semester);<br>
        }<br>
    }<br>
    class MarksDetails : CourseDetails<br>
    {<br>
        int[] marks = new int[5];<br>
        int total;<br>
        float average;<br>
        string grade;<br>
        int flagFail;<br>
        public MarksDetails(string name, int age, string gender, int regNo, string course, int semester, int[] marks) : base(name, age, gender, regNo, course, semester)<br>
        {<br>
            total = 0;<br>
            for (int i = 0; i < 5; i++)<br>
            {<br>
                this.marks[i] = marks[i];<br>
                total += marks[i];<br>
                if (marks[i] < 35)<br>
                {<br>
                    flagFail = 1;<br>
                }<br>
            }<br>
            Calculate();<br>
        }<br>
        private void Calculate()<br>
        {<br>
       average = total / 5;<br>
            if (flagFail == 1 || average < 40)<br>
                grade = "Fail";<br>
            else if (average >= 70)<br>
                grade = "Distinction";<br>
            else if (average >= 60)<br>
                grade = "First class";<br>
            else if (average >= 50)<br>
                grade = "Second class";<br>
            else<br>
                grade = "Pass class";<br>
        }<br>
        public override void Display()<br>
        {<br>
            base.Display();<br>
            Console.WriteLine("\n---------------Marks Details--------------\n");<br>
            Console.WriteLine("Marks in 5 subjects:");<br>
            for (int i = 0; i < 5; i++)<br>
                Console.Write(marks[i] + "");<br>
            Console.WriteLine();<br>
            Console.WriteLine("Total:" + total);<br>
            Console.WriteLine("Average:" + average);<br>
            Console.WriteLine("Grade:" + grade);<br>
        }<br>
    }<br>
    class Multilevel<br>
    {<br>
        public static void Main(string[] args)<br>
        {<br>
            MarksDetails student1 = new MarksDetails("Abhijith", 22, "Male", 2019001, "MCA", 5, new int[] { 77, 80, 98, 95, 90 });<br>
            student1.Display();<br>
        }<br>
    }<br>
}<br>
<br>
![image](https://user-images.githubusercontent.com/97940151/154413794-b7fc60f0-3f12-4ee8-ade4-d730ca08516f.png)
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
4.//C# program to create a Gray code?<br>
<br>
<br>
using System;<br>
namespace Exercises<br>
{<br>
    class GrayCode<br>
    {<br>
        static int getGray(int n)<br>
        {<br>
            return n ^ (n >> 1);<br>
        }<br>
        static void Main(string[] args)<br>
        {<br>
            int InputNum, GrayNum;<br>
            Console.Write("\nEnter the decimal number:");<br>
            InputNum = Convert.ToInt32(Console.ReadLine());<br>
            Console.WriteLine("\nBinary equivalent of {0}:{1}", InputNum, Convert.ToString(InputNum, 2));<br>
            GrayNum = getGray(InputNum);<br>
            Console.WriteLine("\nGray code equivalent of {0}:{1}", InputNum, Convert.ToString(GrayNum, 2));<br>
        }<br>
    }<br>
}<br>
<br>
![image](https://user-images.githubusercontent.com/97940151/154629926-2bc7de64-4cf7-4ba5-9dc0-87d83a48fabb.png)
<br>
<br>
<br>
<br>
<br>
5.//C# program to calculate volume of two boxes and find the resultant volume after addition of 2 boxes by implementing operator overloading?<br>
<br>
<br>
using System;<br>
namespace Exercises<br>
{<br>
    class Box<br>
    {<br>
        float width;<br>
        float height;<br>
        float length;<br>
        public float Volume<br>
        {<br>
            get { return width * height * length;}<br>
        }<br>
        public Box(float width,float height,float length)<br>
        {<br>
            this.width = width;<br>
            this.height = height;<br>
            this.length = length;<br>
        }<br>
        public static float operator+(Box box1,Box box2)<br>
        {<br>
            return box1.Volume + box2.Volume;<br>
        }<br>
        public override string ToString()<br>
        {<br>
            return "box with width" + width + ",height" + height + "and length" + length;<br>
        }<br>
    }<br>
     class Operatoroverloading<br>
    {<br>
        public static void Main()<br>
        {<br>
            Box box1 = new Box(10, 20, 30);<br>
            Box box2 = new Box(20, 25, 15);<br>
            Console.WriteLine("Volume of {0} is:{1}", box1, box1.Volume);<br>
            Console.WriteLine("Volume of {0} is:{1}", box2, box2.Volume);<br>
            Console.WriteLine("Volume after adding boxes:{0}", box1 + box2);<br>
            
          
        }<br>
    }<br>
}<br>
<br>
![image](https://user-images.githubusercontent.com/97940151/154414276-fe74b294-cf98-4534-8ce3-3890673eaa70.png)
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
6.//C# program to implement principles of delegates?<br>
<br>
<br>
using System;<br>
namespace Exercises<br>
{<br>
    class Delegates<br>
    {<br>
        delegate string UppercaseDelegate(string input);<br>
        static string UppercaseFirst(string input)<br>
        {<br>
            char[]buffer = input.ToCharArray();<br>
            buffer[0] = char.ToUpper(buffer[0]);<br>
            return new string(buffer);<br>
        }<br>
        static string UppercaseLast(string input)<br>
        {<br>
            char[] buffer = input.ToCharArray();<br>
            buffer[buffer.Length - 1] = Char.ToUpper(buffer[buffer.Length - 1]);<br>
            return new string(buffer);<br>
        }<br>
        static string UppercaseAll(string input)<br>
        {<br>
            return input.ToUpper();<br>
        }<br>
        static void WriteOutput(string input,UppercaseDelegate del)<br>
        {<br>
            Console.WriteLine("Input string:{0}", input);<br>
            Console.WriteLine("Output string:{0}", del(input));<br>
        }<br>
        static void Main()<br>
        {<br>
            WriteOutput("tom", new UppercaseDelegate(UppercaseFirst));<br>
            WriteOutput("tom", new UppercaseDelegate(UppercaseLast));<br>
            WriteOutput("tom", new UppercaseDelegate(UppercaseAll));<br>
            Console.ReadLine();<br>
        }<br>
    }<br>
}<br>
<br>
![image](https://user-images.githubusercontent.com/97940151/154414812-25dc4920-2b96-44b7-8c0d-bb2a619bfebb.png)
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
7.//C# program to generate Register Number automatically for 100 students using static constructor?<br>
<br>
<br>
using System;<br>
namespace Exercises<br>
{<br>
    class RegisterNum<br>
    {<br>
        int regNo;<br>
        static int StartNum;<br>
        static RegisterNum()<br>
        {<br>
            StartNum = 20210000;<br>
        }<br>
        RegisterNum()<br>
        {<br>
            regNo = ++StartNum;<br>
        }<br>
        public static void Main(string[] args)<br>
        {<br>
            for (int i = 0; i < 100; i++)<br>
            {<br>
                RegisterNum Student = new RegisterNum();<br>
                Console.WriteLine("Student {0}:{1}", i + 1, Student.regNo);<br>
            }<br>
        }<br>
    }<br>
}<br>
<br>
<br>

![image](https://user-images.githubusercontent.com/97940151/154630844-280c8f10-7a3a-4810-98a2-be53b2e435f0.png)
![image](https://user-images.githubusercontent.com/97940151/154415649-6acd5ab3-1a3f-4dbb-aaec-95f264f07211.png)
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
    <br>
 8.//C# program to find the frequency of the word "is" in a given sentence?<br>
 <br>
 <br>
 using System;<br>
namespace Exercises<br>
{<br>
    class FrequencyIS<br>
    {<br>
        static void Main(string[] args)<br>
        {<br>
            int count = 0;<br>
            string inputString;<br>
            Console.WriteLine("\n------------Frequency of word 'is'------------");<br>
            Console.WriteLine("\n Enter the input string:");<br>
            inputString = Console.ReadLine();<br>
            char[] seperator = { ',', ' ', '.', '!', '\n' };<br>
            string testString = inputString.ToLower();<br>
            string[] outcomes = testString.Split(seperator);<br>
            foreach(String S in outcomes)<br>
            {<br>
                Console.WriteLine(S);<br>
                if (S == "is")<br>
                    count++;<br>
            }<br>
            Console.WriteLine("\n Number of 'is' in" + inputString + "is:" + count);<br>
        }<br>
    }<br>
}<br>
<br>
<br>
![image](https://user-images.githubusercontent.com/97940151/154416363-07aa2577-2001-435f-99db-092d63892304.png)
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
9.//C# program of benchmark 2D,jagged array allocation?<br>
<br>
<br>
using System;<br>
using System.Diagnostics;<br>
namespace Exercises<br>
{<br>
    class BenchmarkAllocation<br>
    {<br>
        const int max = 100000;<br>
        static void Main(string[] args)<br>
        {<br>
            var Arr2D = new int[100, 100];<br>
            var ArrJagged = new int[100][];<br>
            for (int i = 0; i < 100; i++)<br>
            {<br>
                ArrJagged[i] = new int[100];<br>
            }<br>
            var Stopwatch2D = Stopwatch.StartNew();<br>
            for (int i = 0; i<=max;i++)<br>
            {<br>
                for (int j = 0; j < 100; j++)<br>
                {<br>
                    for (int k = 0; k < 100; k++)<br>
                    {<br>
                        Arr2D[j, k] = k;<br>
                    }<br>
                }<br>
            }<br>
            Stopwatch2D.Stop();<br>
            var StopwatchJagged = Stopwatch.StartNew();<br>
            for(int i=0;i<=max;i++)<br>
            {<br>
                for(int j=0;j<100;j++)<br>
                {<br>
                    for(int k=0;k<100;k++)<br>
                    {<br>
                        ArrJagged[j][k] = k;<br>
                    }<br>
                }<br>
            }<br>
            StopwatchJagged.Stop();
            Console.WriteLine("\n Time taken for allocation in case of 2D array:");<br>
            Console.WriteLine(Stopwatch2D.Elapsed.TotalMilliseconds + "milliseconds");<br>
            Console.WriteLine("\n Time taken for the allocation in case of Jagged array:");<br>
            Console.WriteLine(StopwatchJagged.Elapsed.TotalMilliseconds + "milliseconds");<br>

        }<br>
   }<br>
}<br>
<br>
<br>
![image](https://user-images.githubusercontent.com/97940151/154417009-ada14e22-9dc3-4e7f-8ddf-10ccec34c3cf.png)
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
10.C# program to find the sum of the values on Diagonal of the matrix?<br>
<br>
<br>
using System;<br>
namespace Exercises<br>
{ <br>
    class SumOfDiagonals<br>
    {<br>
        static void Main(string[] args)<br>
        {<br>
            int MaxRow, MaxCol, Sum = 0;<br>
            int[,] Matrix;<br>
            Console.WriteLine("\n--------------SUM OF DIAGONAL OF A MATRIX--------------\n");<br>
            Console.WriteLine("\n Enter the number of rows:");<br>
            MaxRow = Convert.ToInt32(Console.ReadLine());<br><br>
            Console.WriteLine("\n Enter the number of columns:");<br>
            MaxCol = Convert.ToInt32(Console.ReadLine());<br>
            if (MaxRow != MaxCol)<br>
            {<br>
                Console.WriteLine("\n the dimension entered are not of square Matrix");<br>
                Console.WriteLine("\n exiting the Program-----");<br>
                return;<br>
            }<br>
            Matrix = new int[MaxRow, MaxCol];<br>
            for (int i = 0; i < MaxRow; i++)<br>
            {<br>
                for (int j = 0; j < MaxCol; j++)<br>
                {<br>
                    Console.Write("\n enter the {0},{1} the element of the matrix:", (i + 1), (j + 1));<br>
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());<br>
              }<br>
            }<br>
            Console.WriteLine("\n the entered Matrix is:");<br>
            for (int i = 0; i < MaxRow; i++)<br>
            {<br>
                for (int j = 0; j < MaxCol; j++)<br>
                {<br>
                    Console.Write(" " + Matrix[i, j]);<br>
                    if (i == j)<br>
                    {<br>
                        Sum += Matrix[i, j];<br>
                    }<br>
                }<br>
                Console.WriteLine();<br>
            }<br>
            Console.WriteLine("\n the sum of diagonal is" + Sum);<br>
        }<br>
    }<br>
}<br>
<br>
<br>
![image](https://user-images.githubusercontent.com/97940151/154418078-93b9d426-43fe-423a-a34e-c10c98857069.png)
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
11.//C# program to create a file,check the existence of file and read the contents of the file?<br>
<br>
<br>
using System;<br>
using System.IO;<br>
namespace FileRead<br>
{<br>
    class FileRead<br>
    {<br>
        public static void Main()<br>
        {<br>
            string fileName;<br>
            while (true)<br>
            {<br>
                Console.WriteLine("\n-----------MENU-------------\n");<br>
                Console.WriteLine("\n 1.Create a File");<br>
                Console.WriteLine("\n 2.Existence of the File");<br>
                Console.WriteLine("\n 3. Read the content of file");<br>
                Console.WriteLine("\n 4. Exit");<br>
                Console.WriteLine("\n Enter your choice:");<br>
                int ch = int.Parse(Console.ReadLine());<br>
                switch (ch)<br>
                {<br>
                    case 1:<br>
                          Console.Write("\n Enter the filename to create:");<br>
                          fileName = Console.ReadLine();<br>
                          Console.WriteLine("\n Write the contents to the File:\n");<br>
                          string r = Console.ReadLine();<br>
                          using (StreamWriter fileStr = File.CreateText(fileName))<br>
                          {<br>
                             fileStr.WriteLine(r);<br>
                          }<br>
                          Console.WriteLine("File is Crreated------");<br>
                          break;<br>
                   case 2:<br>
                          Console.Write("\n Enter the filename:");<br>
                          fileName = Console.ReadLine();<br>
                          if (File.Exists(fileName))<br>
                          {<br>
                            Console.WriteLine("File exists----");<br>
                          }<br>
                         else<br>
                         {<br>
                          Console.WriteLine("File does not exist in the current directory!");<br>
                         }<br>
                         break;<br>
                   case 3:<br>
                          Console.WriteLine("Enter the file name to read the contents:\n");<br>
                          fileName = Console.ReadLine();<br>
                          if (File.Exists(fileName))<br>
                          {<br>
                            using (StreamReader sr = File.OpenText(fileName))<br>
                            {<br>
                              string S = " ";<br>
                              Console.WriteLine("Here is the content of the file:");<br>
                              while ((S = sr.ReadLine()) != null)<br>
                              {<br>
                                 Console.WriteLine(S);<br>
                              }<br>
                                  Console.WriteLine(" ");<br>
                            }<br>
                          }<br>
                          else<br>
                          {<br>
                              Console.WriteLine("File does not exists");<br>
                          }<br>
                           break;<br>
                  case 4:<br>
                        Console.WriteLine("\n Exiting-----");<br>
                        return;<br>
                  default :<br>
                        Console.WriteLine("\n Invalid choice");<br>
                         break;<br>
                     }<br>
                   }<br>
        }<br>
    }<br>
}<br>
<br>
<br>
![image](https://user-images.githubusercontent.com/97940151/154419235-f1d25ea4-7e19-43ce-bf8e-c1c464ec2fd1.png)
<br>
![image](https://user-images.githubusercontent.com/97940151/154419416-6ebe1682-ae54-4ee6-9b3b-cfe9a0fd1ed7.png)
<br>
![image](https://user-images.githubusercontent.com/97940151/154419576-91e88eca-ede2-464f-900f-9d26f5fc9a7b.png)
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
12.//C# program to perform file comparision?<br>
<br>
<br>
using System;<br>
using System.IO;<br>
namespace Exercise<br>
{<br>
    class FileRead12<br>
    {<br>
        public static void Main()<br>
        {<br>
            string file1;<br>
            string file2;<br>
            Console.Write("Enter the First file path:");<br>
            file1 = Console.ReadLine();<br>
            Console.Write("Enter the Second file path:");<br>
            file2 = Console.ReadLine();<br>
            if(!File.Exists(file1))<br>
            {<br>
                Console.WriteLine("First file does not exists!");<br>
            }<br>
            else if(!File.Exists(file2))<br>
            {<br>
                Console.WriteLine("Second file does not exists!");<br>
            }<br>
            else if(File.ReadAllText(file1)==File.ReadAllText(file2))<br>
            {<br>
                Console.WriteLine("Both files contains the same content");<br>
            }<br>
            else<br>
            {<br>
                Console.WriteLine("Contents of files are not same");<br>
            }<br>
        }<br>
    }<br>
}<br>
<br>
<br>
![image](https://user-images.githubusercontent.com/97940151/154420600-dd213929-5bfe-44a4-83ba-f69f7516a2ee.png)
<br>
![image](https://user-images.githubusercontent.com/97940151/154420967-e199661b-67bc-4809-bcba-59f7448e80de.png)
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
13.//C# program to implement IComparable Interface?<br>
<br>
<br>
using System;<br>
namespace Exercises<br>
{<br>
    class Fraction : IComparable<br>
    {<br>
        int z, n;<br>
        public Fraction(int z, int n)<br>
        {<br>
            this.z = z;<br>
            this.n = n;<br>
        }<br>
        public static Fraction operator +(Fraction a, Fraction b)<br>
        {<br>
            return new Fraction(a.z * b.n + a.n * b.z, a.n * b.n);<br>
        }<br>
        public static Fraction operator *(Fraction a, Fraction b)<br>
        {<br>
            return new Fraction(a.z * b.z, a.n * b.n);<br>
        }<br>
        public int CompareTo(object obj)<br>
        {<br>
            Fraction f = (Fraction)obj;<br>
            if ((float)z / n < (float)f.z / f.n)<br>
                return -1;<br>
            else if ((float)z / n > (float)f.z / f.n)<br>
                return 1;<br>
            else<br>
                return 0;<br>
        }<br>
        public override string ToString()<br>
        {<br>
            return z + "/" + n;<br>
        }<br>
    }<br>
    class ICompInterface<br>
    {<br>
        public static void Main()<br>
        {<br>
            Fraction[] a =<br>
            {<br>
                     new Fraction(5,2),<br>
                      new Fraction(29, 6),<br>
                       new Fraction(4, 5),<br>
                      new Fraction(10, 8),<br>
                      new Fraction(34, 7)<br>
            };<br>
              Array.Sort(a);  <br>
              Console.WriteLine("Implementing the IComparable Interface in "+" Displaying Fraction:");<br>
            foreach(Fraction f in a)<br>
            {<br>
                 Console.WriteLine(f +" ");<br>
            }<br>
                 Console.WriteLine();<br>
        }<br>
       }<br>
     }<br>
<br>
(https://user-images.githubusercontent.com/97940151/154422326-62a23a05-af53-45f2-a97c-58c66f07e9e6.png)
<br>
<br>
<br>
<br>
<br>
<br>
<br>
