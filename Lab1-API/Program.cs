
using System.Text;

String Concatenation(string wordArg, int numberArg)
{
    StringBuilder sb = new StringBuilder();

 for(int j = 0; j < numberArg; j++)
    {
        sb.Append(wordArg);
    }

    return sb.ToString();
}

string mystring = "I have a Phobia from a Spider";

stringDelegate mydel = new stringDelegate(Concatenation);
Console.WriteLine(mydel(mystring, 3));//returning string thrice


mydel = (string wordArg, int numberArg) =>
{
    //remove 8 charac

    string removewrds = wordArg.Substring(0, wordArg.Length - numberArg);

    return removewrds ;
};

Console.WriteLine(mydel("PHOTOELECTRIC", 8));

delegate string stringDelegate(string wordArg, int numberArg);


