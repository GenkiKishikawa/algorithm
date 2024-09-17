// 点と点の距離
// https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_condition_step4
// 整数 n と、二次元平面上の点 1 ~ n の座標 (x_1, y_1), ... , (x_n, y_n), 整数 k が与えられます。
// n 個の点 (点 n 含む) のうち、点 n とのマンハッタン距離が k 以下であるような点の数を求めてください。
// なお、この問題において、2点間のマンハッタン距離とは、2点の各座標の差の絶対値の総和を指します。つまり、点 (x_i, y_i) と点 (x_j, y_j) のマンハッタン距離は、| x_i - x_j | + | y_i - y_j | です。

using System;

class Paiza
{
  static void Main()
  {
    int n = int.Parse(Console.ReadLine());

    int[] x = new int[n];
    int[] y = new int[n];
    for (int i = 0; i < n; i++)
    {
      string[] inputs = Console.ReadLine().Split(' ');
      x[i] = int.Parse(inputs[0]);
      y[i] = int.Parse(inputs[1]);
    }

    int k = int.Parse(Console.ReadLine());

    int ans = 0;
    // ループで線形探索
    for (int i = 0; i < n; i++)
    {
      // マンハッタン距離の計算
      int distance = Math.Abs(x[i] - x[n - 1]) + Math.Abs(y[i] - y[n - 1]);
      
      if (distance <= k)
      {
        ans++;
      }
    }
    Console.WriteLine(ans);
  }
}