void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    for (int k = 0; k < matrix.GetLength(2); ++k)
                        Console.Write("{0} ( {1}, {2}, {3} )  ", matrix[j, k, i], j, k, i);
                    Console.WriteLine();
                }
        }
}

void MatrixInitialization(ref int[,,] matrix)
{
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
            for (int k = 0; k < matrix.GetLength(2); ++k)
                matrix[i, j, k] = rnd.Next(10, 99);
                
        
}


int m = 2;
int n = 2;
int k = 2;

int[,,] matrix1 = new int[m,n,k];

MatrixInitialization(ref matrix1);

Console.WriteLine("\nМатрица 1");
PrintMatrix(matrix1);