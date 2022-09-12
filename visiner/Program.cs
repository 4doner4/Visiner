using System.Text;

string word = "attackatdawn";
string key = "battle";

StringBuilder sbWord = new StringBuilder(word);
StringBuilder sbKey = new StringBuilder(key);
StringBuilder sbResult = new StringBuilder();

int wallForKey = 0;
int lengthSbKey = sbKey.Length;

if (sbWord.Length > sbKey.Length)
{
    for (int i = lengthSbKey; i < sbWord.Length; i++)
    {
        if (wallForKey >= lengthSbKey) wallForKey = 0;
        sbKey.Append(sbKey[wallForKey]);
        wallForKey++;
    }
}


for (int i = 0; i < sbWord.Length; i++)
{
    char modifiedChar;
    int delta = (int)sbKey[i] - (int)'a';

    if (delta + sbWord[i] > (int)'z')
    {
        modifiedChar = (char)(delta - ((int)'z' - (int)sbWord[i]) + (int)'a');
    }
    else modifiedChar = (char)((int)sbWord[i] + delta);

    sbResult.Append(modifiedChar);
}
Console.WriteLine(sbResult);