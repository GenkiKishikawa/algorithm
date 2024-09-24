// 文字列の出現率
// https://paiza.jp/works/mondai/data_structure/data_structure__dict_step3
// 文字列が N 個与えられます。各文字列の出現回数を文字列の辞書順に出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());

    Dictionary<char, int> cc = new Dictionary<char, int>();

    List<string> ss = Enumerable.Range(0, N).Select(_ => Console.ReadLine()).ToList();

    foreach (IGrouping<string, string> s in ss.GroupBy(x => x).OrderBy(x => x.Key))
    {
      Console.WriteLine($"{s.Key} {s.Count()}");
    }
  }
}