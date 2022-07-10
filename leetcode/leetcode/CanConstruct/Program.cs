using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine(CanConstruct("skateboardwasa", new List<string>() { "w" , "wa" , "sa" , "a" ,"sk" , "bo" , "ard" ,"ate" }));


            Console.WriteLine(HowManyCanConstruct("skateboardwasaaaaaaaaaaaaaaaaaaaaaaaaaaaa", new List<string>() { "w", "wa", "sa", "a", "sk", "bo", "ard", "ate" }));



        }

        public static bool CanConstruct(string TargetWord, List<string> Source, Dictionary<int, List<int>> Memo = null)
        {
            if (TargetWord.Count() == 0) return true;

            bool currentState = false;

            foreach (string word in Source)
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
                        Console.WriteLine(newTarget);
                        currentState = CanConstruct(newTarget, Source);

                    }

                    string lastPartOfTheWord = TargetWord.Substring(TargetWord.Count() - lenght, lenght);

                    if (lastPartOfTheWord == word)
                    {

                        string newTarget = TargetWord.Substring(0, TargetWord.Count() - lenght);
                        Console.WriteLine(newTarget);

                        currentState = CanConstruct(newTarget, Source);

                    }
                }
                else
                {

                }

               
                if(currentState == true)
                {
                    return currentState;
                }

            }


            return currentState;
        }

        public static int HowManyCanConstruct(string TargetWord, List<string> Source, Dictionary<int, List<int>> Memo = null)
        {
            if (TargetWord.Count() == 0) return 1;

            int trueStateCounter = 0;

            foreach (string word in Source)
            {
                // check if the word at the begining of the targetWord
                // get the new word call CanConstruct Again
                // check if the word at the end if the targetWord

                int lenght = word.Count();

                if (lenght > TargetWord.Count() != true)
                {
                    string firstPartOfTheWord = TargetWord.Substring(0, lenght);
                    if (firstPartOfTheWord == word)
                    {
                        string newTarget = TargetWord.Substring(lenght, TargetWord.Count() - lenght);
                        Console.WriteLine(newTarget);

                        int result = HowManyCanConstruct(newTarget, Source);
                        if (result > 0)
                            trueStateCounter += result;

                    }

                    string lastPartOfTheWord = TargetWord.Substring(TargetWord.Count() - lenght, lenght);

                    if (lastPartOfTheWord == word)
                    {

                        string newTarget = TargetWord.Substring(0, TargetWord.Count() - lenght);
                        Console.WriteLine(newTarget);

                        int result = HowManyCanConstruct(newTarget, Source);
                        if (result > 0)
                            trueStateCounter += result;
                    }
                }
                else
                {

                }


               

            }


            return trueStateCounter;
        }
    }




}

