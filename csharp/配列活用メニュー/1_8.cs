//【配列を参照する操作】全ての要素に対する操作
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__map
// 配列 A の要素数 N と整数 K, 配列 A の各要素 A_1, A_2, ..., A_N が与えられるので、配列 A の全ての要素を + K した後の A の各要素を出力してください。

using System;

class Paiza
{
  static void Main()
  {
    string[] inputs = Console.ReadLine().Split(' ');
    int N = int.Parse(inputs[0]);
    int K = int.Parse(inputs[1]);

    for (int i = 0; i < N; i++)
    {
      int nums = int.Parse(Console.WriteLine());
      Console.WriteLine(nums + K);
    }
  }
}