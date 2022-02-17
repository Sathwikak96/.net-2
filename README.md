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
