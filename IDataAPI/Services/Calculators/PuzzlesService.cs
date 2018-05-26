using IDataAPI.Interfaces.Calculators;

namespace IDataAPI.Services.Calculators
{
    public class PuzzlesService : IPuzzles
    {
        public int EggPuzzle()
        {
            int i = 1;
            while (i < System.Int32.MaxValue) {
                if (i % 1 == 0 
                    && i % 2 == 1
                    && i % 3 == 0
                    && i % 4 == 1
                    && i % 5 == 4
                    && i % 6 == 3
                    && i % 7 == 0
                    && i % 8 == 1
                    && i % 9 == 0
                    )
                {
                    break;
                }
                i++;
            }
            return i;
        }
    }
}
