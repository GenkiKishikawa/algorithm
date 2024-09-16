// 【最大最小】n 変数の最大最小
// https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_minmax_boss
// 整数 n と、数列 a_1, ... , a_n が与えられます。
// 数列の最大値と最小値をこの順に半角スペース区切りで出力してください。

using System;

class Paiza
{
  static void Main()
  {
    int n = int.Parse(Console.ReadLine());
    string[] array = Console.ReadLine().Split(' ');

    int max = int.Parse(array[0]);
    int min = int.Parse(array[0]);
    for (int i = 0; i < n; i++)
    {
      int tmpNum = int.Parse(array[i]);
      if (max < tmpNum)
      {
        max = tmpNum;
      }
      if (tmpNum < min)
      {
        min = tmpNum;
      }
    }
    Console.WriteLine($"{max} {min}");
  }
}