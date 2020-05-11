using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class LINQ
    {
       public List<string> wordlist = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
       public List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
        public List<string> grades = new List<string>()
        {
         "80,100,92,89,65",
         "93,81,78,84,69",
         "73,88,83,99,64",
         "98,100,66,74,55" 
        };
                                                        
        public void WordsWithTh(List<string> words)
        {
            var word = words;
            var thWord = word.Where(w => w.Contains("th"));
            foreach(var wor in thWord)
            {
                Console.WriteLine(wor); 
            }  
        }

        public List<string> RemoveDuplicate(List<string> name)
        {
            List<string> newNames = new List<string>();
            var names = name;
            var removedNames = names.Distinct();
            foreach (var nam in removedNames)
            {
                newNames.Add(nam);
            }
            return newNames;
        }

        public double AverageGrade(List<string> classGrades)
        {
            var grades = classGrades;
            var listOne = new List<int>();
            var listTwo = new List<int>();
            var listThree = new List<int>();
            var listFour = new List<int>();
            int i = 0;

            var splitList = grades.SelectMany(g => g.Split(','));
            var intGrade = grades.Select(s => Int32.Parse(s));

            foreach(var grade in intGrade)
            {
                while(i < grades.Count)
                {
                    if(i < 5)
                    {
                        listOne.Add(grade);
                        i++;
                        break;
                    }
                    else if(i >= 5 && i < 10)
                    {
                        listTwo.Add(grade);
                        i++;
                        break;
                    }
                    else if (i >= 10 && i < 15)
                    {
                        listThree.Add(grade);
                        i++;
                        break;
                    }
                    else if(i >= 15 && i <= 20)
                    {
                        listFour.Add(grade);
                        i++;
                        break;
                    }
                }

            }

            var sOne = listOne.OrderBy(s => s).Skip(1).Average();
            var sTwo = listTwo.OrderBy(s => s).Skip(1).Average();
            var sThree = listThree.OrderBy(s => s).Skip(1).Average();
            var sFour = listFour.OrderBy(s => s).Skip(1).Average();

            var classAverage = (sOne + sTwo + sThree + sFour) / 4;
            return classAverage;
        }
    }
}
