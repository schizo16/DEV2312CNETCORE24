using System.Text;

namespace Labguide05_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int rows = 4;
            int cols = 4;
            int[,] twoDimensionalArray = new int[rows, cols];

            // Khởi tạo giá trị cho mảng
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Gán giá trị tùy ý, ví dụ: i * 10 + j
                    twoDimensionalArray[i, j] = i * 10 + j;
                }
            }

            // In mảng để kiểm tra kết quả
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(twoDimensionalArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Tính tổng các phần tử mà có chỉ số hàng = chỉ số cột
            int diagonalSum = 0;
            for (int i = 0; i < rows; i++)
            {
                diagonalSum += twoDimensionalArray[i, i];
            }
            Console.WriteLine("Tổng các phần tử có chỉ số hàng = chỉ số cột: " + diagonalSum);
            // In ra các phần tử  nhỏ nhất trên cột
            Console.WriteLine("Phần tử nhỏ nhất trên mỗi cột:");
            for (int j = 0; j < cols; j++)
            {
                int minInColumn = twoDimensionalArray[0, j];
                for (int i = 1; i < rows; i++)
                {
                    minInColumn = Math.Min(minInColumn, twoDimensionalArray[i, j]);
                }
                Console.WriteLine("Cột " + j + ": " + minInColumn);
            }
            // Liệt kê các phần tử chia hết cho 7
            Console.WriteLine("Các phần tử chia hết cho 7:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (twoDimensionalArray[i, j] % 7 == 0)
                    {
                        Console.WriteLine("[" + i + ", " + j + "]: " + twoDimensionalArray[i, j]);
                    }
                }
            }
            // Tìm tổng các phần tử nằm trên đường viền của mảng
            int borderSum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                    {
                        borderSum += twoDimensionalArray[i, j];
                    }
                }
            }
            Console.WriteLine("Tổng các phần tử nằm trên đường viền của mảng: " + borderSum);
            // Chuyển thành mảng 1 chiều rồi sắp xếp tăng dần
            int[] oneDimensionalArray = new int[rows * cols];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    oneDimensionalArray[index++] = twoDimensionalArray[i, j];
                }
            }
            Array.Sort(oneDimensionalArray);

            // In mảng 1 chiều đã sắp xếp
            Console.WriteLine("Mảng 1 chiều đã sắp xếp tăng dần:");
            foreach (int element in oneDimensionalArray)
            {
                Console.Write(element + " ");
            }
        }
    }
}
