// 数値の出現率
// https://paiza.jp/works/mondai/data_structure/data_structure__dict_step1
// 0 以上 9 以下の整数が N 個与えられます。
// 各数値の出現回数を求め、「0」の出現回数、「1」の出現回数、...「9」の出現回数、をこの順に半角スペース区切りで1行に出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());

    int[] counts = new int[10];

    List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

    foreach (int number in numbers)
    {
      counts[number]++;
    }

    Console.WriteLine(string.Join(" ", counts));
  }
}