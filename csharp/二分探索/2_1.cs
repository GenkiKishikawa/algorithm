// パイプを切り出そう
// https://paiza.jp/works/mondai/binary_search/binary_search__application_step0
// n 本のパイプがあり、長さはそれぞれ A_1, A_2, ..., A_n です。今、n 本のパイプから k 本の同じ長さのパイプを切り出すことを考えます。
// パイプを切って分割することはできますが、つなげることはできません。
// パイプの切り方を工夫した結果、切り出すことができるパイプの長さの最大値を答えてください。
// 答えは整数になるとは限りません。相対誤差または絶対誤差が 10^-6 (0.000001) 以下であれば正解とみなされます。

using System;

class Paiza
{
  static void Main()
  {
    string[] inputs = Console.ReadLine().Split(' ');
    // パイプの本数n
    int n = int.Parse(inputs[0]);
    // 同じ長さのパイプの本数k
    int k = int.Parse(inputs[1]);

    // 各ハイプの長さの数列
    string[] buffer = Console.ReadLine().Split(' ');
    int[] pipes = new int[n];
    for (int i = 0; i < n; i++)
    {
      pipes[i] = int.Parse(buffer[i]);
    }

    // 二分探索
    double left = 0.0, right = 10001.0;
    for (int i = 0; i < 100; i++) {
        double mid = (left + right) / 2;
        int num_of_pipes = 0;
        foreach (int pipe in pipes) {
            num_of_pipes += (int)(pipe / mid);
        }

        // Console.WriteLine($"num_of_pipes: {num_of_pipes}, left: {left}, right: {right}");

        if (num_of_pipes < k) {
            right = mid;
        } else {
            left = mid;
        }
    }

    Console.WriteLine($"{left:F10}");
  }
}