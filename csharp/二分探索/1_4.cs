// ある範囲に含まれている整数の個数
// https://paiza.jp/works/mondai/binary_search/binary_search__basic_boss
// 数列 A = (A_1, A_2, ..., A_n) と、整数の組 (l_1, r_1), (l_2, r_2), ..., (l_q, r_q) が与えられます。
// 各組 (l_i, r_i) について、数列 A に含まれる値のうち l_i 以上 r_i 以下であるものの個数を求めてください。

using System;

class Paiza
{
  static void Main()
  {
    // 数列の要素数 n
    int n = int.Parse(Console.ReadLine());

    // 数列
    string[] inputs = Console.ReadLine().Split(' ');
    int[] scores = new int[n];
    for (int i = 0; i < n; i++)
    {
      scores[i] = int.Parse(inputs[i]);
    }

    // 与えられる整数の組の個数 q
    int q = int.Parse(Console.ReadLine());

    // 数列を昇順にソート
    Array.Sort(scores);

    // 二分探索
    for (int i = 0; i < q; i++)
    {
      string[] borderScores = Console.ReadLine().Split(' ');
      int lowerBorderScore = int.Parse(borderScores[0]);
      int upperBorderScore = int.Parse(borderScores[1]);

      int lowerBorder = binarySearch(scores, n, lowerBorderScore);
      int upperBorder = binarySearch(scores, n, upperBorderScore + 1);

      int ans = upperBorder - lowerBorder;
      Console.WriteLine(ans);
    }
  }

  static int binarySearch(int[] A, int n, int k)
  {
    int left = 0;
    int right = n;

    while (left < right)
    {
      int mid = (left + right) / 2;

      if ( A[mid] < k )
      {
        left = mid + 1;
      }
      else
      {
        right = mid;
      }
    }
    return right;
  }
}