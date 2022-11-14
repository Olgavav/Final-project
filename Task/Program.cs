int LenElem = 3;
string[] GetElems()
{
Console.WriteLine("Введите значения через запятую : ");
return Console.ReadLine().Split(",");

}

int GetLength(string[] arr, int n)
{
int len = 0;
for (int i = 0; i < arr.Length; i++)
{
if (arr[i].Length <= n)
len++;
}
return len;
}

string[] FindElem(string[] OriginArr, int n)
{
string[] result = new string[GetLength(OriginArr, n)];
for (int i = 0, j = 0; i < OriginArr.Length; i++)
{
if (OriginArr[i].Length <= n)
{
result[j] = OriginArr[i];
j++;
}
}
return result;
}

string[] inputArr = GetElems();
string[] outputArr = FindElem(inputArr, LenElem);

Console.WriteLine($"{string.Join(", ", inputArr)} -> {string.Join(", ", outputArr)}");
