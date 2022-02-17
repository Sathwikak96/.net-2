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
<br><br>
![image](https://user-images.githubusercontent.com/97940151/154411539-dfd58d8a-e107-4ac3-866e-26dc91fc0e8e.png)

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
using System;

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
![image](https://user-images.githubusercontent.com/97940151/154412894-5460e684-0e67-4f7b-970a-84a5611771d3.png)
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
        
        using System;<br>

namespace Exercise;<br>

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
![image](https://user-images.githubusercontent.com/97940151/154415649-6acd5ab3-1a3f-4dbb-aaec-95f264f07211.png)
    
