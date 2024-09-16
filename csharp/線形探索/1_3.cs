// 指定された値の位置 2
// https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_value_step2
// 整数 n と、数列 a_1, ... , a_n と、整数 k が与えられます。
// 整数 k が数列の何番目にあるかを求めてください。なお、最初の要素 (a_1) を 1 番目とします。
// ただし、数列に整数 k が含まれていない場合は、0 を出力してください。
// また、数列に整数 k が複数含まれている場合は、数列を先頭から順に見たときに最後に現れる k が数列の何番目にあるかを求めてください

using System;

class Paiza
{
  static void Main()
  {
    int n = int.Parse(Console.ReadLine());
    string[] array = Console.ReadLine().Split(' ');
    int k = int.Parse(Console.ReadLine());

    bool foundFlag = false;
    // ループで線形探索
    for (int i = n - 1; i >= 0; i--)
    {
      int tmpNum = int.Parse(array[i]);

      if (tmpNum == k)
      {
        Console.WriteLine(i + 1);
        foundFlag = true;
        break;
      }
    }

    // 数列中に k が一度も見つからなかった場合、0を出力
    if (foundFlag == false)
    {
      Console.WriteLine(0);
    }
  }
}