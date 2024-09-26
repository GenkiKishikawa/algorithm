// 配列のサイズの変更
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__resize
// 配列 A の要素数 N と新たに作成する配列のサイズ n , 配列 A の各要素 A_1 ... A_N が与えられるので、配列 A の先頭から n 要素を順に保持する配列を作成してください。
// 新たに作成する配列の要素数が A の要素数よりも大きい時は、サイズが合うように 0 を A の要素の末尾に追加してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    string[] inputs = Console.ReadLine().Split(' ');
    int N = int.Parse(inputs[0]);
    int n = int.Parse(inputs[1]);

    List<int> A = Enumerable.Range(0, N)
                            .Select(_ => int.Parse(Console.ReadLine()))
                            .ToList();

    List<int> ans = new List<int>();

    for (int i = 0; i < n; i++)
    {
      if (i < N)
      {
        ans.Add(A[i]);
      }
      else if (i >= N)
      {
        ans.Add(0);
      }
    }

    foreach (int a in ans)
    {
      Console.WriteLine(a);
    }
  }
}