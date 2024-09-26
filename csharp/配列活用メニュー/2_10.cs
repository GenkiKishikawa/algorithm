// 重複要素の削除
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__unique
// 配列 A の要素数 N と配列 A の各要素 A_1, A_2, ..., A_N が与えられるので、同じ値の要素が 2 つ以上含まれないように A を加工した新たな配列 B を作成してください。
// ただし、 A に同じ値の要素が 2 つ以上あった場合、それらのうち先頭の要素を B に採用するものとします。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());

    List<int> A = Enumerable.Range(0, N)
                            .Select(_ => int.Parse(Console.ReadLine()))
                            .Distinct()
                            .ToList();

    foreach (int a in A)
    {
      Console.WriteLine(a);
    }
  }
}