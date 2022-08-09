namespace threeDimensionalArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArray = new int[3, 3, 3]
            {
                { {0,0,2}, {0,2,0}, {2,0,2} },
                { {0,0,2}, {0,2,0}, {2,0,0} },
                { {0,0,2}, {0,2,0}, {2,0,0} }
            };

            int[,,] arrayTwo = new int[3, 3, 3]
            {
                { {0,0,2}, {0,2,0}, {2,0,0} },
                { {0,0,2}, {0,2,0}, {2,0,0} },
                { {0,0,2}, {0,2,0}, {2,0,0} }

            };
            int[,,] result = new int[3, 3, 3];

            for (int x = 0; x < myArray.GetLength(0); x++)
            {
                for (int y = 0; y < myArray.GetLength(1); y++)
                {
                    for (int z = 0; z < myArray.GetLength(2); z++)
                    {
                        result[x, y, z] += myArray[x, y, z] * arrayTwo[x, y, z];
                        Console.WriteLine(result[x, y, z]);

                    }
                }
            }

           
        }
    }
}