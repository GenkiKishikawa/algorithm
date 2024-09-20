// 太巻きを分けよう (おなかペコペコ)
// https://paiza.jp/works/mondai/binary_search/binary_search__application_step2
// 長さ L [cm] の太巻きがあり、これを n 人で分けようとしています。
// 太巻きにはあらかじめ k 個の切れ目が入っており、i 個目の切れ目は左端から A_i [cm] のところに入っています。
// あなたは、切れ目を n-1 個選んでそこで切ることにより、太巻きを n 分割しようとしています。n 人はみなお腹がすいているので、なるべくたくさん食べたいと思っています。切れ目の選び方を工夫したとき、最も短い太巻きの長さを最大でいくつにできるかを答えてください。

using System;

class Paiza {
  static void Main() {
    string[] inputs = Console.ReadLine().Split(' ');
    // 太巻きの長さL
    int L = int.Parse(inputs[0]);
    // 人数n
    int n = int.Parse(inputs[1]);
    // 切れ目の数k
    int k = int.Parse(inputs[2]);

    // 切れ目
    int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
  }
}