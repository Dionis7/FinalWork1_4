string[] arrayLine = { "Hello", "2", "world", ":-)" };
string[] arrayNumbersLine = new string[GetStrings(arrayLine)];
FillArray(arrayLine, arrayNumbersLine);
System.Console.WriteLine("'{0}'", string.Join("', '", arrayNumbersLine));

int GetStrings(string[] arrayString)
{
    int arrayLength = 0;
    for (int i = 0; i < arrayString.Length; i++)
        if (arrayString[i].Length <= 3) arrayLength++;
    return arrayLength;
}

void FillArray(string[] arrayLine, string[] arrayNumbersLine)
{
    int j = 0;

    for (int i = 0; i < arrayLine.Length; i++)
    {
        if (arrayLine[i].Length <= 3)
        {
            arrayNumbersLine[j] = arrayLine[i];
            j++;
        }
    }
}
