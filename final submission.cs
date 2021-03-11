using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string LineBase;
            string Entry;
            string[] tokens;
            int id = 1;
            int counter = 0;
            int[] ans = new int[20];
            int[] ques = new int[20] {01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20 };
            string sn = "Stu Num";
            string mark = "Mark";
            Console.WriteLine("***** MCQ Student Exam Report *****\n");
            Console.WriteLine("{0}\t\t{1}\n",sn,mark);
            try
            {
                StreamReader file = new StreamReader("exam.txt");
                LineBase = file.ReadLine();
                while (id != 0)
                {
                    int correct = 0;
                    int wrong = 0;
                    int noans = 0;
                    Entry = file.ReadLine();
                    tokens = Entry.Split();
                    id = Convert.ToInt32(tokens[0]);
                    for (int i = 0; i < tokens[2].Length; i++)
                    {
                        string t = Convert.ToString(tokens[2]);
                        if (t[i] == LineBase[i])
                        {
                            correct++;
                            ans[i]++;
                        }
                        if (t[i] == 'X')
                        {
                            noans++;
                        }
                        if (t[i] != LineBase[i] && t[i] != 'X')
                        {
                            wrong++;
                        }
                    }
                    counter++;
                    Console.WriteLine("{0}\t\t{1}", id, ((correct * 5) + (wrong * -1) + (noans * 0)));
                    Console.WriteLine("------------------------");
                }
            }
            catch
            {
            }
            finally
            {
            }
            Console.WriteLine();
            Console.WriteLine("The Total number of examinations is: {0} \n", counter);
            Console.WriteLine("Number of correct respoonses for each question: \n");
            Console.WriteLine("Questions    Correct Ans\n");
            for (int n = 0; n < 20; n++)
            {
                Console.WriteLine("{0}                {1}",ques[n],ans[n]);
                Console.WriteLine("--------------------------");
            }
            Console.ReadKey();
        }
    }
}
/*
The contetnt of the Text File:
ACADCEEBEADCCBCDDDEC
6741  ACADCEEBEADCCBCDDDEC
9444  ACAEAEEBEADCCDCDDDEC
6932  ACADCEBBEAACCBCEDDDC
8442  XABBACXBBBXAXDDDEDXX
7894  ACADCEEBEADCCBCDDDEC
6284  DDEEDBBBCDCDDXDCDXEB
5917  ACADCEEBEADCCBCDDDEC
9865  ECACAEEBEADCCBCDDDEC
5377  BCADCCEBEADCDBCDDEEC
4529  DAEDBXCAXBACBBABACCB
3619  ACXDCEEBEXDCCBCDDDEC
1516  AECACABXEEBBCEDXBACA
4233  AAEDEACAEDECBDDDCEEA
3714  ABAAEBCEEECEEDBCCDBB
4826  ACADCXEBEAACCBCDXDEC
5471  AEDDXDDBXADCBXEEXAXD
7939  ACADDEXBAADCCBCDDDEC
1448  AXEADDDXDCDEDDBXBBDC
9296  ACBDCECBEADACBBDDXEC
2199  ACACCEXBXADCCBCDBDEC
0
*/
