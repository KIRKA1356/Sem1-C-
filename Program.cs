int num1, num2, quad;                       //Объявление необходиммых переменных

Console.Write("Imput first number: ");      //Предложение ко вводу первого числа
num1 = Convert.ToInt32(Console.ReadLine()); //Ввод первого числа с конвертацией

Console.Write("Imput second number: ");     //Предложение ко вводу второго числа
num2 = Convert.ToInt32(Console.ReadLine()); //Ввод второго числа

quad=num2*num2;                             //Условие

if (quad==num1)                             //Условный оператор, при котором будут выодиться ответы
{
    Console.WriteLine("Yes");           
}
else
{
        Console.WriteLine("No");
}