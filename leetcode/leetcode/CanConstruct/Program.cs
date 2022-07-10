using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine(CanConstruct("skateboardww", new List<string>() { "w" ,"sk" , "ate","bo" , "ard" }));



        }

        public static bool CanConstruct(string TargetWord, List<string> Source, Dictionary<int, List<int>> Memo = null)
        {
            if (TargetWord.Count() == 0) return true;

            foreach(string word in Source)
            {
                // check if the word at the begining of the targetWord
                // get the new word call CanConstruct Again
                // check if the word at the end if the targetWord
                
                int lenght = word.Count();

                if(lenght > TargetWord.Count() != true)
                {
                    string firstPartOfTheWord = TargetWord.Substring(0, lenght);
                    if (firstPartOfTheWord == word)
                    {
                        string newTarget = TargetWord.Substring(lenght, TargetWord.Count() - lenght);
                        return CanConstruct(newTarget, Source);

                    }

                    string lastPartOfTheWord = TargetWord.Substring(TargetWord.Count() - lenght, lenght);

                    if (lastPartOfTheWord == word)
                    {

                        string newTarget = TargetWord.Substring(0, TargetWord.Count() - lenght);
                        return CanConstruct(newTarget, Source);

                    }
                }

               
                

            }


            return false;
        }
    }




}

