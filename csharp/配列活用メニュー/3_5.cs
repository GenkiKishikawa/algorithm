// 場所取り
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__line_up
// 開店直後に店に入るために、番号 1 〜 N の N 人が開店前に店の前にブルーシートを合計 K 枚置きました。ブルーシートの先頭は A_1 , 最後尾は A_K です。しかし、店側は先頭から F 枚のブルーシートを撤去しました。

// 1 〜 N 番の人々は次のルールに従って店に並びます。
// ・自分のブルーシートが 1 枚以上残っているとき、自分のブルーシートのうち、最も先頭に近いブルーシートの位置に並ぶ。
// ・自分のブルーシートが 1 枚も残っていないとき、並ぶことなく帰宅する。

// 全員が並び終わった後に待機列にいる人の番号を先頭から順に答えてください。

// 例
// ・N = 3, K = 6, F = 3, A = [3, 2, 1, 2, 3, 2] のとき
// 撤去が行われる前と行われた後のブルーシートの様子は次の通りになります。




// 番号 1 の人のブルーシートは 1 枚も残っていないので並ぶことなく帰宅します。
// 番号 2 の人のブルーシートは 2 枚残っているので、最も先頭に近いブルーシートの位置に並びます。
// 番号 3 の人のブルーシートは 1 枚残っているので、そのブルーシートの位置に並びます。

// 最終的な待機列は次の通りになるので、期待する出力は

// 2
// 3

// となります。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    int[] inputs = Console.ReadLine()
                             .Split(' ')
                             .Select(x => int.Parse(x))
                             .ToArray();

    int N = inputs[0];
    int K = inputs[1];
    int F = inputs[2];

    List<int> A = Enumerable.Range(0, K)
                            .Select(_ => int.Parse(Console.ReadLine()))
                            .ToList();

    for (int i = 0; i < F; i++)
    {
      A.RemoveAt(0);
    }

    List<int> ans = A.Distinct()
                     .ToList();

    foreach (int a in ans)
    {
      Console.WriteLine(a);
    }
  }
}