// upper_bound
// https://paiza.jp/works/mondai/binary_search/binary_search__basic_step2
// n 人の生徒が受けた、10^9 点満点のテストの採点結果 A_1, A_2, ..., A_n があります。あなたは合格点を自由に設定することができます。
// 合格点が k 点のとき、k 点より大きい点数を取った生徒が合格で、k 点以下の点数を取った生徒が不合格です。
// q 個の整数 k_1, k_2, ..., k_q が与えられます。各 k_i について、合格点が k_i のときに合格する生徒の数を答えてください。

using System;

class Paiza
{
  static void Main()
  {
    // 生徒の人数 n
    int n = int.Parse(Console.ReadLine());

    // 採点結果 A_i 
    string[] inputs = Console.ReadLine().Split(' ');
    int[] scores = new int[n];
    for (int i = 0; i < n; i++)
    {
      scores[i] = int.Parse(inputs[i]);
    }

    // 合格点の候補数 q
    int q = int.Parse(Console.ReadLine());

    // 採点結果のソート
    Array.Sort(scores);

    // 2分探索
    for (int i = 0 ; i < q; i++)
    {
      int passScore = int.Parse(Console.ReadLine());
      int ans = binarySearch(scores, n, passScore);
      Console.WriteLine(n - ans);
    }
  }

  static int binarySearch(int[] A, int n, int k)
  {
    // 探索範囲 [left, right]
    int left = 0;
    int right = n;
    
    // 探索範囲を狭めていく
    while (left < right)
    {
      // 探索範囲の中央
      int mid = (left + right) / 2;

      if (A[mid] <= k)
      {
        // A[0] ~ A[mid] は k 未満なので調べる必要が無い
        left = mid+1;
      }
      else
      {
        right = mid;
      }
    }
    return right;
  }
}