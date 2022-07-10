using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            //Console.WriteLine(CanConstruct("skateboardwasaaaaaaaaaaaaaaaaaaaaaaaaaaaaaawaaaaaaaawaaaaaawwwww", new List<string>() { "w" , "wa" , "sa" , "a" ,"sk" , "bo" , "ard" ,"ate" }));


            Console.WriteLine(HowManyCanConstruct("skateboardwasaawwwwwwwwwwwwaaaaaaaasaaaaaaaaasa", new List<string>() { "w", "wa", "sa", "a", "sk", "bo", "ard", "ate" }));



        }

        public static bool CanConstruct(string TargetWord, List<string> Source, Dictionary<string, bool> Memo = null)
        {
            if (TargetWord.Count() == 0) return true;

            if(Memo == null)
            {
                Memo = new Dictionary<string, bool>();
            }
            if (Memo.ContainsKey(TargetWord))
            {
                return Memo[TargetWord];
            }

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
                        currentState = CanConstruct(newTarget, Source, Memo);
                    }

                    string lastPartOfTheWord = TargetWord.Substring(TargetWord.Count() - lenght, lenght);

                    if (lastPartOfTheWord == word)
                    {

                        string newTarget = TargetWord.Substring(0, TargetWord.Count() - lenght);
                        Console.WriteLine(newTarget);

                        currentState = CanConstruct(newTarget, Source,Memo);


                    }
                }
                else
                {

                }


                if (currentState == true)
                {
                    return currentState;
                }

            }

            Memo.Add(TargetWord, currentState);



            return currentState;
        }

        public static int HowManyCanConstruct(string TargetWord, List<string> Source, Dictionary<string, int> Memo = null)
        {
            if (TargetWord.Count() == 0) return 1;

            if (Memo == null)
            {
                Memo = new Dictionary<string, int>();
            }
            if (Memo.ContainsKey(TargetWord))
            {
                return Memo[TargetWord];
            }
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

                        int result = HowManyCanConstruct(newTarget, Source, Memo);
                        if (result > 0)
                            trueStateCounter += result;

                    }

                    string lastPartOfTheWord = TargetWord.Substring(TargetWord.Count() - lenght, lenght);

                    if (lastPartOfTheWord == word)
                    {

                        string newTarget = TargetWord.Substring(0, TargetWord.Count() - lenght);
                        Console.WriteLine(newTarget);

                        int result = HowManyCanConstruct(newTarget, Source , Memo);
                        if (result > 0)
                            trueStateCounter += result;
                    }
                }
                else
                {

                }


               

            }

            Memo.Add(TargetWord, trueStateCounter);


            return trueStateCounter;
        }
    }




}

