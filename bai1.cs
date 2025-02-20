using System;

class BMIModel
{
    public double Weight { get; set; }  // Cân nặng (kg)
    public double Height { get; set; }  // Chiều cao (m)

    // Constructor để khởi tạo giá trị
    public BMIModel(double weight, double height)
    {
        Weight = weight;
        Height = height;
    }

    // Phương thức tính BMI
    public double CalculateBMI()
    {
        return Weight / (Height * Height);
    }
}

class Program
{
    static void Main()
    {
        // Tạo đối tượng BMIModel với cân nặng 64kg, chiều cao 1m80
        BMIModel person = new BMIModel(64, 1.80);

        // Tính BMI và in kết quả
        double bmiValue = person.CalculateBMI();
        Console.WriteLine($"Chỉ số BMI của bạn là: {bmiValue:F2}");
    }
}
