string [] ArrayCreate(){
    string command = "y";
    string strWords = string.Empty;
    
    while (command == "y"){
        Console.Write("Введите слово: ");
        strWords += Console.ReadLine();
        Console.Write("Еще одно слово? (y/n): ");
        command = Console.ReadLine();
        if(command == "y") strWords += "_";
    }

    string[] arrWords = strWords.Split("_");
    return arrWords;

}
string[] ArrayFilter(string [] arr){
    string temp = string.Empty;
    for (int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= 3){
            temp += arr[i];
            temp += "_";
        }
    }
    temp = temp.Remove(temp.Length - 1);
    string[] newArr = temp.Split("_");
    return newArr;
}
void ArrayShow(string [] arr){
    for(int i = 0; i < arr.Length; i++){
        Console.Write($"| {arr[i]} |");
    }
    Console.WriteLine();
}

string [] tempArr = ArrayCreate();
Console.WriteLine("Исходный массив:");
ArrayShow(tempArr);
string[]finalArr = ArrayFilter(tempArr);
Console.WriteLine("Отфильтрованный массив:");
ArrayShow(finalArr);