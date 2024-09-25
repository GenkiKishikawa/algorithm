// 指定要素の先頭位置
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__find
// 配列 A の要素数 N と整数 K , 配列 A の各要素 A_1, A_2, ..., A_N が与えられるので、K であるような A の要素のうち、要素番号が最小のものを出力してください。
// A に K が含まれない場合は -1 を出力してください。

using System;

class Paiza
{
  static void Main()
  {
    string[] inputs = Console.ReadLine().Split(' ');
    int N = int.Parse(inputs[0]);
    int K = int.Parse(inputs[1]);

    int[] A = new int[N];
    for (int i = 0; i < N; i++)
    {
      A[i] = int.Parse(Console.ReadLine());
    }

    int ans = -1;
    for (int i = 0; i < N; i++)
    {
      if (A[i] == K)
      {
        ans = i + 1;
        break;
      }
    }
    Console.WriteLine(ans);
  }
}