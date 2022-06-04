using System;
namespace RecursiveQuickSort_String
{
	public class ReadAndSort
	{
        public List<string> QuickSort(List<string> Names)
        {
            if (Names.Count <= 1)
                return Names;

            Random random = new Random();

            int pivot = random.Next(0, Names.Count - 1);

            List<string> LesserSide = new List<string>();
            List<string> GreaterSide = new List<string>();

            for (int i = 0; i < Names.Count; i++)
            {
                if (i != pivot)
                {
                    if (Names[i].CompareTo(Names[pivot]) <= 0)
                    {
                        LesserSide.Add(Names[i]);
                    }
                    else
                    {
                        GreaterSide.Add(Names[i]);

                    }
                }
            }


            LesserSide = QuickSort(LesserSide);
            GreaterSide = QuickSort(GreaterSide);


            List<string> sortedNames = new List<string>();

            sortedNames.AddRange(LesserSide);
            sortedNames.Add(Names[pivot]);
            sortedNames.AddRange(GreaterSide);

            return sortedNames;

        }

        public List<string> ReadListOfStrings(string path)
        {
            string[] readText = File.ReadAllLines(path);

            return readText.ToList();
        }
    }
}

