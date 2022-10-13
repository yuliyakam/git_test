int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
   
    //Считываем число
    int x1= int.Parse(Console.ReadLine() ?? "0");    

    //Возвращаем значение
    return x1;  
}