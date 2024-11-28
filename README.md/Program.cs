using System;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            // Bước 1: Hiển thị menu
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle (4 corners)");
            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            // Lấy lựa chọn từ người dùng
            string choice = Console.ReadLine();

            // Xử lý lựa chọn
            switch (choice)
            {
                case "1":
                    PrintRectangle();
                    break;
                case "2":
                    PrintSquareTriangle();
                    break;
                case "3":
                    PrintIsoscelesTriangle();
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Bước 2: Hàm in hình chữ nhật
    static void PrintRectangle()
    {
        Console.WriteLine("Enter width: ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("\nRectangle:");
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    // Bước 3: Hàm in tam giác vuông với 4 góc khác nhau
    static void PrintSquareTriangle()
    {
        Console.WriteLine("Choose corner:");
        Console.WriteLine("1. Bottom-left");
        Console.WriteLine("2. Bottom-right");
        Console.WriteLine("3. Top-left");
        Console.WriteLine("4. Top-right");
        Console.Write("Enter your choice: ");
        string corner = Console.ReadLine();

        Console.WriteLine("Enter size of the triangle: ");
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine("\nSquare Triangle:");
        switch (corner)
        {
            case "1": // Bottom-left
                for (int i = 1; i <= size; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                break;

            case "2": // Bottom-right
                for (int i = 1; i <= size; i++)
                {
                    for (int j = 1; j <= size; j++)
                    {
                        Console.Write(j < size - i + 1 ? " " : "*");
                    }
                    Console.WriteLine();
                }
                break;

            case "3": // Top-left
                for (int i = size; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                break;

            case "4": // Top-right
                for (int i = size; i >= 1; i--)
                {
                    for (int j = 1; j <= size; j++)
                    {
                        Console.Write(j < size - i + 1 ? " " : "*");
                    }
                    Console.WriteLine();
                }
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    // Bước 4: Hàm in tam giác cân
    static void PrintIsoscelesTriangle()
    {
        Console.WriteLine("Enter height of the triangle: ");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("\nIsosceles Triangle:");
        for (int i = 1; i <= height; i++)
        {
            // In khoảng trắng
            for (int j = 1; j <= height - i; j++)
            {
                Console.Write(" ");
            }
            // In dấu *
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
