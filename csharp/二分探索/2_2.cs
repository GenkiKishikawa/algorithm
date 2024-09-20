// 効率よく盗もう
// https://paiza.jp/works/mondai/binary_search/binary_search__application_step1
// paiza 博物館に、n 個の財宝が展示されています。各財宝の価値は V_1, V_2, ..., V_n であり、重さは W_1, W_2, ..., W_n です。怪盗であるあなたは、paiza 博物館からちょうど k 個の財宝を盗み出そうとしています。
// k 個の財宝の平均価値を、(k 個の財宝の価値の和) ÷ (k 個の財宝の重さの和) で定義します。
// 盗み出す財宝を適切に選んだ結果、平均価値が最大でいくつになるかを答えてください。
// 答えは整数になるとは限りません。相対誤差または絶対誤差が 10^-6 (0.000001) 以下であれば正解とみなされます。

using System;

class Paiza
{
  static void Main()
  {
    string[] inputs = Console.ReadLine().Split(' ');
    // 財宝の数n
    int n = int.Parse(inputs[0]);
    // 盗み出す財宝の数k
    int k = int.Parse(inputs[1]);

    // 各財宝の重さW_1, W_2, ..., W_n
    string[] weight_inputs = Console.ReadLine().Split(' ');
    int[] weights = new int[n];
    for (int i = 0; i < n; i++) {
      weights[i] = int.Parse(weight_inputs[i]);
    }

    // 各財宝の価値V_1, V_2, ..., V_n
    string[] value_inputs = Console.ReadLine().Split(' ');
    int[] values = new int[n];
    for (int i = 0; i < n; i++) {
      values[i] = int.Parse(value_inputs[i]);
    }

    double l = 0.0;
    double r = 5001.0;
    for (int j = 0; j < 100; j++) {
      double mid = (l + r) / 2;

      double[] tmp = new double[n];
      for (int i = 0; i < n; i++) {
        // 各財宝の評価値を計算 mid = values / weightの逆算
        tmp[i] = values[i] - weights[i] * mid;
      }

      Array.Sort(tmp);
      Array.Reverse(tmp);

      double sum = 0;
      for (int i = 0; i < k; i++) {
        sum += tmp[i];
      }

      if (sum >= 0) {
        l = mid;
      } else {
        r = mid;
      }
    }
    Console.WriteLine($"{l:F10}");
  }
}