// 値の探索
// https://paiza.jp/works/mondai/binary_search/binary_search__basic_step0
// ソートされた数列 A = (A_1, A_2, ..., A_n) と、q 個の整数 k_1, k_2, ..., k_q が与えられます。各 k_i について、数列 A に含まれているなら Yes と、含まれていないなら No と出力してください。
// なお、n, q の最大値はいずれも 200,000 です。
// q 回線形探索を行うことで解けそうですが、制約を見ると数列 A のサイズは最大で 200,000 、q も最大で 200,000 ですから、最悪で 200,000 * 200,000 回処理をする必要があり、これでは到底処理が終わりません。何か工夫をする必要があります。
// A がソート済みであることに注目します。A の真ん中の要素が k 未満であれば、A の前半分の要素もすべて k 未満であることがわかります。つまり、A の前半分について探索する必要が無くなります。逆に、A の真ん中の要素が k より大きければ、A の後ろ半分の要素もすべて k より大きいので、A の後ろ半分について探索する必要が無くなります。
// つまり、「対象とする探索範囲の中央の値」と「探索したい値」を比較することで、探索範囲を半分にすることができます。このようなアプローチを 二分探索 と呼びます。
// 実装は、探索範囲の始点と終点を変数として持ち、探索範囲を半分にする処理を探索範囲が十分小さくなるまで繰り返すようにするとよいです。

using System;

class Paiza
{
  static void Main()
  {
    // 数列の要素数 n
    int n = int.Parse(Console.ReadLine());

    // ソートされた数列 A = (A_1, A_2, ..., A_n)
    string[] inputs = Console.ReadLine().Split(' ');
    int[] nums = new int[n];
    for (int i = 0; i < n; i++)
    {
      nums[i] = int.Parse(inputs[i]);
    }

    // 与えられる整数q個
    int q = int.Parse(Console.ReadLine());

    // 二分探索
    for (int i = 0; i < q; i++)
    {
      int target = int.Parse(Console.ReadLine());
      int left = 0;
      int right = n - 1;

      bool foundFlag = false;
      while (left <= right && !foundFlag)
      {
        int middle = (left + right) / 2;

        if (nums[middle] == target)
        {
          Console.WriteLine("Yes");
          foundFlag = true;
        }
        else if (nums[middle] <= target)
        {
          left = middle + 1;
        }
        else if (nums[middle] >= target)
        {
          right = middle - 1;
        }
      }

      if (!foundFlag)
      {
        Console.WriteLine("No");
      }
    }
  }
}
