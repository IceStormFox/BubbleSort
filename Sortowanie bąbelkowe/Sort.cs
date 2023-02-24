namespace BubbleSort
{
    public class Sort
    {
        public static void Sortuj(int[] sortowanie)
        {
            int n = sortowanie.Length;
            {
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - 1 - i; j++)
                    {
                        if (sortowanie[j] > sortowanie[j + 1])
                        {
                            int zmienna = sortowanie[j];
                            sortowanie[j] = sortowanie[j + 1];
                            sortowanie[j + 1] = zmienna;
                        }
                    }
                }
            }
        }
    }
}
