using System;

namespace day1
{
    class program
    {
        //int x;
        static void Main()
        {
            #region variables 
            //Console.WriteLine("hello world");
            //Console.ReadKey();
            //variables
            //3+5=8 no flex
            //x+y=z felxiable
            //int x; // declare variable x
            //x = 4; //assign
            //int y = 5; // declare & assign
            //int _1;

            //short y = 123;
            //long z = 11551;
            //float x = 1.2F; //suffix 
            //float b = (float)1.2; //casting
            //double d = 1.2d; //suffix but in double not required
            //decimal s = 1.12345m; //suffix for decimal 

            //bool x = true;

            //int? x = null; //nullable type can take null
            //Nullable<int> y= null; // nullable type can take null
            #endregion
            #region conversion
            //implicit convert small to large 
            //int x = 5;
            //long y = x;

            //exceplicit
            //checked // to give error if overflow happen
            //{
            //    long x = 12344654661;
            //    int z = (int)x;
            //    Console.WriteLine(z);
            //}

            // helper class
            //String txt = "123";
            //int x=Convert.ToInt32(txt);
            //x++;
            //Console.WriteLine(x);


            //parse convert string to any data type
            //string txt = "1234";
            //int x= int.Parse(txt);  


            //tostring convert any datatypr into string
            //int x = 5;
            //string y=x.ToString();


            // special case
            //char c = 'A';
            //int x = c; // will convert char to ASC

            //int y = 65;
            //char a = y;// will conert asc to char


            #endregion
            #region write,String format, read
            //write 
            //Console.Write("helo wolrd");
            //Console.WriteLine("helo wolrd");

            //string format 

            //int id = 1;
            //String name = "ali hany ali";
            //int age = 22;

            ////concatenation
            //Console.WriteLine("id= "+id+ "name ="+name);

            ////string holders
            //Console.WriteLine("id={0},name={1},age{2}",id,name,age);//order reguired

            //string interploated
            //Console.WriteLine($"id={id},name={name},age={age}");

            // skip sequence
            //Console.WriteLine("ali \n hany");// skip line
            //Console.WriteLine("ali \t hany");// tab between words


            //skip parsing
            //any backword slash mean skip sequnce but what if you what to print it ?
            //1- add \ after the back slah
            //Console.WriteLine("ali \\ hany");
            //2- add @
            //Console.WriteLine(@"ali \ hany");


            //Read
            //string txt= Console.ReadLine();
            //Console.WriteLine($"my name is {txt}");
            //int x= int.Parse(Console.ReadLine());
            //x++;
            //Console.WriteLine(x);

            //Console.WriteLine("enter first number1");
            //int num1=int.Parse(Console.ReadLine());
            //Console.WriteLine("enter first number2");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"sum = {num1 + num2}");

            #endregion

        }
    }
}