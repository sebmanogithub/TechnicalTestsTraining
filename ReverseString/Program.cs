
using System.Text;

static string ReverseString(string str)
{
    //var toto = str
    //            .Reverse();
    //string totostr = new string(toto.ToArray());

    //char[] buffer = new char[str.Length];

    //for (int i = 0; i < str.Length; i++)
    //{
    //    buffer[i] = str[str.Length - 1 - i];
    //}

    //return new string(buffer);

    StringBuilder sb = new StringBuilder();
    int i = str.Length - 1;

    while (i >= 0)
    {
        sb.Append(str[i--]);
    }

    return sb.ToString();
}