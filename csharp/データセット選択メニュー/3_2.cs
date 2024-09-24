// 英小文字の出現率
// https://paiza.jp/works/mondai/data_structure/data_structure__dict_step2
// 長さ N の文字列 S が与えられます。
// S に含まれている各文字の出現回数をそれぞれ求め、「a」の出現回数、「b」の出現回数、...、「z」の出現回数をこの順に半角スペース区切りで1行に出力してください。

using System;
using System.Collections.Generic;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());
    string S = Console.ReadLine();

    Dictionary<char, int> cc = new Dictionary<char, int>();
    for (char c = 'a'; c <= 'z'; c++)
    {
      cc.Add(c, 0);
    }

    foreach (char c in S)
    {
      cc[c]++;
    }

    Console.WriteLine(string.Join(" ", cc.Values));
  }
}