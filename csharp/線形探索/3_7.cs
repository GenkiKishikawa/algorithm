// 成績優秀者の列挙 1
// https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_condition_step6
// n 人の生徒がテストを受けました。このテストで k 点以上の点数を取った人が合格です。
// n 人の各生徒について、その人の名前とその人が取った点数が入力として与えられるので、このテストに合格した人の名前をすべて、入力された順に改行区切りで出力してください。
// なお、合格者が一人もいない場合は、何も出力しないでください。

using System;

class Paiza
{
  static void Main()
  {
    // 生徒数n
    int n = int.Parse(Console.ReadLine());

    // n 人の各生徒について、その人の名前とその人が取った点数
    string[] name = new string[n];
    int[] score = new int[n];
    for (int i = 0; i < n; i++)
    {
      string[] inputs = Console.ReadLine().Split(' ');
      name[i] = inputs[0];
      score[i] = int.Parse(inputs[1]);
    }

    // 合格点k
    int k = int.Parse(Console.ReadLine());

    // ループで線形探索
    for (int i = 0; i < n; i++)
    {
      if (k <= score[i])
      {
        Console.WriteLine(name[i]);
      }
    }
  }
}