using System;
using System.Xml.Linq;

namespace MyShuffle
{
	public class FileShuffle
	{
		public string fileDirectory;
		public string[] fileLines;
        public static Random rand = new Random();

        public FileShuffle()
		{
            //this line gives in the path of the file into a string
            fileDirectory = "/Users/devinsalgado35/Desktop/Shuffle/Algorithms/MyShuffle/Items.txt";
            //the file is then stored in an array and reads in the lines that are within the text file
            fileLines = File.ReadAllLines(fileDirectory);
        }

        //this checks if the file is not found, or unable to read a file in that directory
		public void fileMissing()
		{
            if (!File.Exists(fileDirectory))
            {
                Console.WriteLine("File not found");
            }
        }

        //this methods shuffles throught the indexes of the array 
		public void shuffleNums()
		{
            //the for statment locates the index sort of in the middle of the array 
            for (int i = fileLines.Length - 1; i > 0; i--)
            {
                //Gives J a random number
				int j = randomNum(i);
                //Here it takes the idex and the random number and interchages them and repeats this once it has gone through all 6 indexes
				string temp = fileLines[i];
				fileLines[i] = fileLines[j];
				fileLines[j] = temp;
            }
            //goes through the already shuffled array and prints every number there is within the array
            foreach (var item in fileLines)
            {
                Console.WriteLine(item);
            }
        }

		//this methods is suppose to act like an RNG
        public int randomNum(int i)
		{
			return rand.Next(i+1);
		}
	}
}

