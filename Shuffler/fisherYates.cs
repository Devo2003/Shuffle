using System;
namespace Shuffler
{
	public static class fisherYates
	{
		private static Random rand = new Random();
        /* one way the code can be improved is the naming convetions of things
         * the person has some long naming for methods which at that point you should keep the 
         * original name and have a comment explnation of the methods purpose.
         */
        public static void ShuffleThem(this object[] objects)
		{
			for (int i = objects.Length - 1; i > 0; i--)
			{
				int j = GetNum(i);
                objects.SwapIndexPlacements(i,j);
			}
		}

        /* Another way I would improve this is by making all the methods be put in their own class 
         * because if I remember correctly I think they are breaking the Single Responsibilty priciple 
         * where the class should only have one purpose. Also the program class shouldnt include any code and should
         * only be used to call a method to print at the console.
        */
        public static void ShuffleThemdiffrently(this object[] objects)
        {
            for (int i = 0; i < objects.Length - 2; i++)
            {
                int j = GetNum((objects.Length - i)- 1);

                objects.SwapIndexPlacements(i, i + j);

            }
        }

        private static int GetNum(int i)
		{
            return rand.Next(i + 1);
        }
    }
}

