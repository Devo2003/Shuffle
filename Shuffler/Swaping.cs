using System;
namespace Shuffler
{
	public static class Swaping
	{

        public static void SwapIndexPlacements(this object[] objects, int i, int j)
        {
            object temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }
    }
}

