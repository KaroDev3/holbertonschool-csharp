using System;

class Program
{
	static void Main(string[] args)
	{
		double[,] matrix, res;

		// example 1
		matrix = new double[2, 2] { { 1, 2 }, { 3, 4 } };
		res = MatrixMath.Shear2D(matrix, 'x', 2); // (5, 2) (11, 4)
		PrintMatrix(res);

		// example 2
		matrix = new double[2, 2] { { 1, 2 }, { 3, 4 } };
		res = MatrixMath.Shear2D(matrix, 'y', 2); // (1, 4) (3, 10)
		PrintMatrix(res);

		// example 3
		matrix = new double[2, 2] { { 1, 2 }, { 3, 4 } };
		res = MatrixMath.Shear2D(matrix, 'd', 2); // (-1)
		PrintMatrix(res);
	}

	static void PrintMatrix(double[,] matrix)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				if (j == 0)
					Console.Write("(");

				Console.Write($"{matrix[i, j]}");

				if (j == matrix.GetLength(1) - 1)
					Console.WriteLine(")");
				else
					Console.Write(", ");
			}
		}
		Console.WriteLine();
	}
}
