// 指定要素があるかの判定
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__exist
// 配列 A の要素数 N と整数 K , 配列 A の各要素 A_1, A_2, ..., A_N が与えられるので、A に K が 1 つでも含まれている場合は Yes を、含まれていない場合は No を出力してください。

using System;

class Paiza
{
  static void Main()
  {
    string[] inputs = Console.ReadLine().Split(' ');
    int N = int.Parse(inputs[0]);
    int K = int.Parse(inputs[1]);

    bool flag = false;
    for (int i = 0; i < N; i++)
    {
      int num = int.Parse(Console.ReadLine());

      if (num == K)
      {
        flag = true;
      }
    }

    Console.WriteLine(flag ? "Yes" : "No");
  }
}

// -------------------------------------------------

using System;
using System.Linq;

class Program
{
  static void Main()
  {
    int[] nk = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    int[] a = Enumerable.Range(0, nk[0])
                        .Select(_ => int.Parse(Console.ReadLine()))
                        .ToArray();
    Console.WriteLine(a.Any(x => x == nk[1]) ? "Yes" : "No");
  }
}