using Shuffler;
using MyShuffle;
namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            FileShuffle fs = new FileShuffle();
            string[] letters = { "A","B","C","D","E" };
            //letters.ShuffleThem();
            
            letters.ShuffleThemdiffrently();
            
            foreach (string letter in letters)
            {
                //Console.WriteLine(letter + "");
            }
            fs.fileMissing();
            fs.shuffleNums();
            
            Console.ReadKey();
        }
    }
}
