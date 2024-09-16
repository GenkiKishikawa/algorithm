// 指定された値の探索】指定された値の位置 3
// https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_value_boss
// 整数 n と、数列 a_1, ... , a_n と、整数 k が与えられます。
// 整数 k が数列の何番目にあるかを求めてください。最初の要素 (a_1) を 1 番目とします。
// 数列に整数 k が複数含まれている場合は、そのすべてについて何番目にあるかを求め、数列を先頭から見たときに現れる順にすべて出力してください。
// ただし、整数 k が数列に含まれていない場合は、何も出力しないでください。

using System;

class Paiza
{
  static void Main()
  {
    int n = int.Parse(Console.ReadLine());
    string[] array = Console.ReadLine().Split(' ');
    int k = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
      int tmpNum = int.Parse(array[i]);

      if (tmpNum == k)
      {
        Console.WriteLine(i + 1);
      }
    }
  }
}