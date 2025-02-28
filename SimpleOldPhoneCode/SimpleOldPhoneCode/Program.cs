using System.Linq.Expressions;
using System.Text.RegularExpressions;

class OldPhone
{
    static string keys;
    static string outputkeys;
    static string finalOutput;
    static string prockey;
    static void input()
    {
         Console.WriteLine("input the following keys followed by # at the end");
         keys = Console.ReadLine(); //This is the code responsible for collecting data from the user
        //---------------------------------------------------------------------------------------------------//
        
        if (keys.Contains("*")) // This code is responsible for the backspace function
        {
            for (int i = 0; i < keys.Length - 1; i++)
            {
                if (keys[i] == '*')
                {
                    keys = keys.Remove(i - 1, 2);
                    i--;
                }
            }
        }
        //---------------------------------------------------------------------------------------------------------------------//
        if (!keys.Contains('#')) // This code is responsible for validation of data checking whether the input contains # or not.
        {
            Console.WriteLine("Your input is invalid, Please add # at the end");
            return;
        }
        else
        keys = hastagonchange(keys); // This code is responsible to execute the hastagonchange function.
        keys = keys.Replace(" ", "#"); // This code is responsible of replacing the " " with #.
        string[] PK = keys.Split("#"); // In this part of code the data of the keys variable will be inserted to the array PK.
        foreach(var IK in PK) // In this part the data from the PK variable is extracted and stored in the IK variable
            {
                if (string.IsNullOrEmpty(IK)) continue;

                string FK = IK + "#"; // In this code the data from IK will be extacted with # in the end
                if (FK == "q#") // This is for the quit to stop the while loop
                {
                    prockey = "q#";
                }

                prockey = FK; // here thi will stor the data from the FK to the prockey variable.

        

                switch (prockey) // Here this is where the program will process the data from numberkeys to their corresponding letters/ characters
                {
                    case "1#":
                        outputkeys = "&";
                        break;
                    case "11#":
                        outputkeys = "'";
                        break;
                    case "111#":
                        outputkeys = "(";
                        break;
                    case "2#":
                        outputkeys = "A";
                        break;
                    case "22#":
                        outputkeys = "B";
                        break;
                    case "222#":
                        outputkeys = "C";
                        break;
                    case "3#":
                        outputkeys = "D";
                        break;
                    case "33#":
                        outputkeys = "E";
                        break;
                    case "333#":
                        outputkeys = "F";
                        break;
                    case "4#":
                        outputkeys = "G";
                        break;
                    case "44#":
                        outputkeys = "H";
                        break;
                    case "444#":
                        outputkeys = "I";
                        break;
                    case "5#":
                        outputkeys = "J";
                        break;
                    case "55#":
                        outputkeys = "K";
                        break;
                    case "555#":
                        outputkeys = "L";
                        break;
                    case "6#":
                        outputkeys = "M";
                        break;
                    case "66#":
                        outputkeys = "N";
                        break;
                    case "666#":
                        outputkeys = "O";
                        break;
                    case "7#":
                        outputkeys = "P";
                        break;
                    case "77#":
                        outputkeys = "Q";
                        break;
                    case "777#":
                        outputkeys = "R";
                        break;
                    case "7777#":
                        outputkeys = "S";
                        break;
                    case "8#":
                        outputkeys = "T";
                        break;
                    case "88#":
                        outputkeys = "U";
                        break;
                    case "888#":
                        outputkeys = "V";
                        break;
                    case "9#":
                        outputkeys = "W";
                        break;
                    case "99#":
                        outputkeys = "X";
                        break;
                    case "999#":
                        outputkeys = "Y";
                        break;
                    case "9999#":
                        outputkeys = "Z";
                        break;
                    case "0#":
                        outputkeys = " ";
                        break;
                    case "q#":
                        outputkeys = "quit";
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        return;
                }
                finalOutput += outputkeys; // Here the data from the outputkeys variable will be stored in the finaloutput contiously
            }
    }
    static string hastagonchange(string keys) // this function will insert # everytime there will be a change on numberkeys
        {
            if (string.IsNullOrEmpty(keys) || keys.Length == 1)
                {
                    return keys;
                }
            string test = keys[0].ToString();
            for (int i = 1; i < keys.Length; i++)
                {
                    if (keys[i] != keys[i - 1])
                    {
                        test += "#";
                    }

                    test += keys[i];
                }
            return test;
        }
    static void output() // this code is the responsible for the output of the data from the finaloutput and the outputkeys
    {
        if (outputkeys != "quit")
            {
                Console.WriteLine(finalOutput);
            }
        else
            {
                Console.WriteLine(outputkeys);
            }

    }
    static void Main(string[] args) // Main
        {
            while (outputkeys != "quit")
                {
                    input();
                    if (input != null)
                        {

                            output();
                        }
                }
        } 

    // Thank you so much have a great day
}
