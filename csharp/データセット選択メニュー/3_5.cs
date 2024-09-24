// 商品の検索
// https://paiza.jp/works/mondai/data_structure/data_structure__dict_boss
// N 個の文字列 S_1, ... , S_N と、Q 個の文字列 T_1, ... , T_Q が与えられます。
// 各 T_i について、以下の処理を行ってください。
// ・ S_j == T_i を満たす最小の j を出力する。ただし、そのような j が存在しない場合は -1 を出力する。 

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    string[] inputs = Console.ReadLine().Split(' ');
    int N = int.Parse(inputs[0]);
    int Q = int.Parse(inputs[1]);

    List<string> A = Enumerable.Range(0, N).Select(_ => Console.ReadLine()).ToList();

    for (int i = 0; i < Q; i++)
    {
      string s = Console.ReadLine();
      Console.WriteLine(A.IndexOf(s) == -1 ? -1 : A.IndexOf(s) + 1);
    }
  }
}

// ----------------------------------

using System;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    // N: 文字列の数, Q: クエリの数
    string[] input = Console.ReadLine().Split();
    int N = int.Parse(input[0]);
    int Q = int.Parse(input[1]);

    // 文字列を保持する辞書を作成
    Dictionary<string, int> S = new Dictionary<string, int>();

    // N個の文字列を入力し、辞書に登録
    for (int i = 0; i < N; i++)
    {
      string s = Console.ReadLine();
      if (!S.ContainsKey(s))
      {
        S[s] = i + 1;  // Pythonでは1から始まっていたので、i + 1にする
      }
    }

    // Q個のクエリに対して辞書内を検索
    for (int i = 0; i < Q; i++)
    {
      string t = Console.ReadLine();
      if (S.ContainsKey(t))
      {
        Console.WriteLine(S[t]);
      }
      else
      {
        Console.WriteLine(-1);  // 辞書に存在しない場合は -1 を出力
      }
    }
  }
}
