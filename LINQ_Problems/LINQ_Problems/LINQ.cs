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
            foreach(var nam in removedNames)
            {
                newNames.Add(nam);
            }
            return newNames;
        }
    }
}
