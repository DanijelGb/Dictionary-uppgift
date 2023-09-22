using System.Collections;
using System.Collections.Generic;

string[] fil = File.ReadAllLines("/Users/DaciBaci/Desktop/hundnamn-ålder.txt");

Dictionary<string, int> djur = new Dictionary<string, int>();

foreach (var item in fil)
{
    string[] word = item.Split(",");

    if (int.TryParse(word[1], out int age))
    {
        djur.Add(word[0], age);
    }
}

List<string> print = new List<string>();

foreach (KeyValuePair<string, int> item in djur.OrderBy(key => key.Value))
{
    print.Add(item.Key + " " + item.Value);
}


File.WriteAllLines("/Users/DaciBaci/source/repos/Projekt/Dictionary uppgift/implement.txt", print);

