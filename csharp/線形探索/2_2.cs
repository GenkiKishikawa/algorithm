// 10変数の最大最小
// https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_minmax_step1
// 10 個の整数 a_1, a_2, ... , a_10 が与えられます。
// これらの最大値と最小値をこの順に半角スペース区切りで出力してください。

using System;

class Paiza
{
  static void Main()
  {
    string[] array = Console.ReadLine().Split(' ');

    int max = 0;
    int min = int.Parse(array[0]);
    for (int i = 0; i < 10; i++)
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