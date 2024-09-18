// lower_bound
// https://paiza.jp/works/mondai/binary_search/binary_search__basic_step1
// n 人の生徒が受けた、10^9 点満点のテストの採点結果 A_1, A_2, ..., A_n があります。あなたは合格点を自由に設定することができます。合格点が k 点のとき、k 点以上を取った生徒が合格で、k 点未満を取った生徒が不合格です。
// q 個の整数 k_1, k_2, ..., k_q が与えられます。各 k_i について、合格点が k_i のときに合格する生徒の人数を答えてください。
// なお、n, q の最大値はいずれも 200,000 です。
// 制約を見ると、生徒の人数 n は最大で 200,000 人で、与えられる合格点の候補 k の数は 200,000 です。k が与えられるたびに生徒ひとりひとりの点数を確認し、合格者数を求めるアプローチで解こうとすると、最悪で 200,000 * 200,000 回処理をする必要があり、これでは実行時間制限に間に合いません。
// 二分探索は、このような問題にも適用することができます。具体的には、単調性のある列の境界を求める状況に適用することができます。
// 以降では、簡単のために 0 始まりの添字で記述します。A_0, A_1, ..., A_{n-1} をソートします。すると、A_x >= k ならば、y >= x を満たすすべての y について A_y >= k であることから、A_i >= k を満たすような i の最小値 min_i がわかれば、合格者数の人数は n - min_i で求めることができます。ただし、A_i >= k を満たすような i がひとつも存在しない場合は、min_i を n とします。
// min_i は、以下のようにして求めることができます。

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

    // 探索対象の採点結果をソート
    Array.Sort(scores);

    // 二分探索
    for (int i = 0; i < q; i++)
    {
      int passScore = int.Parse(Console.ReadLine());
      int ans = binary_search(scores, n, passScore);
      Console.WriteLine(n - ans);
    }
  }

  static int binary_search(int[] A, int n, int k)
  {
    // 探索範囲 [left, right]
    int left = 0;
    int right = n;
    
    // 探索範囲を狭めていく
    while (left < right)
    {
      // 探索範囲の中央
      int mid = (left + right) / 2;

      if (A[mid] < k)
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