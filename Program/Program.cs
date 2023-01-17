/* Написать программу которая из имеющегося массива строк формирует массив строк, 
 длина которых меньше либо равна 3 символа. 
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
 Не рекомендуется пользоваться коллекциями.
*/


string[] text = {"Hello", "Hi", "Why?", "45869" ,"yes" , "23", "no" ,"2022", ":-)","35"};
string temp = string.Empty;

int count = 0;

for(int i = 0; i < text.Length; i++) 
{
   temp = Convert.ToString(text[i]);
   
   if(temp.Length < 4)
   {
    count++;
   }
}

string[] newText = new string[count]; 

PrintArray(text);
Console.WriteLine();
WriteArray(newText);
PrintArray(newText);

void WriteArray(string[] array) 
{
    int numbers = 0;

   for(int l = 0; l < text.Length; l++)
   {
    temp = Convert.ToString(text[l]);
  
        if(temp.Length < 4)
        {     
            newText[numbers] = Convert.ToString(temp);
            numbers++;
        }
    }
}

void PrintArray(string[] array) 
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");   
    }
    Console.Write($"{array[array.Length - 1]}");
}
