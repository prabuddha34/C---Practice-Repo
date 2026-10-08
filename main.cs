using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine(1+2);
        //this is a comment in c#
        string name = "Praxy";
        Console.WriteLine(name);
        const int intVal=14;
        //intVal = 234; we cannot chnage the value !
        Console.WriteLine(intVal);
        Console.WriteLine(name+" "+"pal");
        int x = 7, y = 9, z = 1;
        Console.WriteLine(x+y+z);
        double d = Math.PI;
        Console.WriteLine(d);
        Console.WriteLine((int)d); //type casting that i am doing !
        
        //Now we have to get the user input from the user !
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("The age of my user is :"+" "+age);
        //displaying the value !
        int x1 = 145 + 35;
        Console.WriteLine(x1); //i am using the plus operator here !
        
        //now the math functions !
        Console.WriteLine("The max value between 3 and 5 is "+" "+Math.Max(3,5)); //getting the max value !

        string abs = "Hello World!";
        Console.WriteLine(abs.ToUpper()); //getting the upper value !
        Console.WriteLine(abs.ToLower()); //getting the lower value !
        
        //string concatenation !
        string a = "abc";
        string b = "cde";
        Console.WriteLine(a+b); //displaying the value !
        
        Console.WriteLine("abc".IndexOf('c')); //output will be 2 
        bool isOnline = true;
        Console.WriteLine("Online status:-"+" "+isOnline); //displays the value of the boolean algebra !
        
        //boolean part of it !
        //grind it hard
        Console.WriteLine(10>9); //shows the true or the false value of it !
        //check for the equality of it !
        Console.WriteLine(10 ==10 ); //so checks if 10 == 10 or not ! andd here it is showing true !
        
        //check your voting age 
        Console.WriteLine("Enter the age of the user to see your criteria:");
        int userAge=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("So the status of the user to vote is :"+" "+(userAge>18)); //so i am just making the code short!
        
        //now i am going to have the 'if' statements of it !
        if(1>19)
        {
            Console.WriteLine("So the status of the user is that they can vote !");
        }
        else
        {
            Console.WriteLine("The user cannot vote !"); //here this statement will be run !
        }
        //lets make a if else ladder i know it is easy but still ! we can do this !

        int timeA = Convert.ToInt32(Console.ReadLine());
        if (timeA <= 12)
        {
            Console.WriteLine("It is morning !");
        }
        else if (timeA > 12 || timeA < 16)
        {
            Console.WriteLine("It is noon !");
        }
        else if (timeA>16 ||timeA<19)
        {
            Console.WriteLine("It is everning !");
        }
        else
        {
            Console.WriteLine("It is deep night !");
        }
        //now go for the switch statements!
        
        Console.WriteLine("Enter your choice!");
        int choice = Convert.ToInt32(Console.ReadLine());
        int a11=Convert.ToInt32(Console.ReadLine());
        int b11=Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                int result=a11+b11;
                Console.WriteLine(result);
                break;
            case 2:
                int result2=a11*b11;
                Console.WriteLine(result2);
                break;
            case 3:
                int result3=a11/b11;
                Console.WriteLine(result3);
                break;
            case 4:
                int result4=a11%b11;
                Console.WriteLine(result4);
                break;
            default:
                Console.WriteLine("Please enter a valid choice!");
                break;
            
        }
        //now lets go for the looping part of it !
        //display 1->5 using a while loop god damn it !

        int i = 0;
        while (i<5)
        {
            Console.WriteLine(i+1); //um i am a 0- index based guy so that's why i am taking i+1 for it !
            i++;
        }
        //now do the same job using a for loop !
        
        
        Console.WriteLine("The values from 1->5 by using a for loop are:-");
        for (int i1 = 0; i1 < 5; i1++)
        {
            Console.WriteLine(i1+1); //again +1 as i am a 0 index guy !
        }
        
        //now for each loop
        Console.WriteLine("The car names ! are as follows !");
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        foreach (string i111 in cars) 
        {
            Console.WriteLine(i111);
        }
        //so yeah now i am going for the arrays rn ! ok? :)
        int[] number_Array = { 10, 2, 3, 4, 5 };
        
        //display them
        foreach (int j in  number_Array)
        {
            Console.WriteLine("The number here is "+" "+" "+"is"+j); //shows the vals !
            
        }
        //so now i will continue my work !
        //what about displaying the values of the index value of it !and then help it !
        
        Console.WriteLine("The Element at the 0th index is "+" "+number_Array[0]); //should give 10
        //lets ovverride an element with  a new value !
        number_Array[0] = 11;
        //print the updated value !
        foreach (int j in number_Array)
            {
            Console.WriteLine("The number here is "+" "+" "+"is"+j);
            }
        //what about the length of the arrays that we can find ? use use .length to find it !
        //so find the length of it !
        Console.WriteLine("The length of the array of it is !+"+" "+number_Array.Length); //displays the value !
        
        //make a normal loop so that we can loop through the entire array !
        for (int i1= 0; i1 < number_Array.Length; i1++)
        {
            Console.WriteLine(number_Array[i1]); //SHOWS the values !
        }
        //let's sort rthe array that is given to us !
        Array.Sort(number_Array); //it is getting sorted!

        foreach (int j in number_Array)
        {
            Console.WriteLine("The sorted here is "+" "+" "+"is"+j); //and this it is been showing in it !
        }
        //imported the values here we and this it can make it and find the max,min values!
        
        Console.WriteLine(number_Array.Max()); //gettting the max value !
        Console.WriteLine(number_Array.Min()); //getting the min value !
        Console.WriteLine(number_Array.Sum());//finding the sum
        //getting the 2d array!
        int[,] numbers = { {1, 4, 2}, {3, 6, 8} }; //getting the 2d array!
        //change a value of it [0,0] and give some value of it !
        numbers[0, 0] = 420; //see value will ve chnaged
        Console.WriteLine(numbers[0, 0]); //shows the print the values!
        //loop through the entire values! 2D arrays!
        foreach (int k in numbers)
        {
            Console.WriteLine(k);
        }
        //making the value of it !
        //so i want to learn about functions !
        //so call this printVals() function !
        
        printVals(); //here the output will be shown here !
        //calling this function again and again !
        printVals();
        printVals();
        printVals();
        
        //total 4 outputs will be shown !
        
        //now pass the strings in it !
        stringVal("Sara");
        stringVal("Praxy");
        stringVal("Homie");
        //this should be vals !
        
        
    }

    static void printVals()
    {
        Console.WriteLine("Hey youre are my dancing queen !");
    }
    //lets add some parameters and thus we can do something in it !
    static void stringVal(string s)
    {
        Console.WriteLine("THE STRING IS :"+" "+s);
    }
    //get some multiple parameters on this dope !
    
}

