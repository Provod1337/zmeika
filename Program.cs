int N = int.Parse(File.ReadAllText("INPUT.TXT"));

        int[,] matrix = new int[N, N];
        int num = 1;

        for (int col = 0; col < N; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < N; row++)
                {
                    matrix[row, col] = num++;
                }
            }
            else
            {
                for (int row = N - 1; row >= 0; row--)
                {
                    matrix[row, col] = num++;
                }
            }
        }


using (StreamWriter sw = new StreamWriter("OUTPUT.TXT"))
{
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            sw.Write(matrix[i, j] + " ");
        }
        sw.WriteLine();
    }
}