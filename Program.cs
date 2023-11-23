bool alfa = true;
string result = "";
while (alfa)
{
    Console.WriteLine("Zadejte slovo");
    var input2 = Console.ReadLine();
    
    if (string.IsNullOrWhiteSpace(input2))
    {
        alfa = false;
    }
    result += " ";
    result += input2;
}
Console.WriteLine(result);
