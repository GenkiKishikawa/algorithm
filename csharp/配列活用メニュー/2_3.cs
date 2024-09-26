// 指定要素の入れ替え 
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__swap
// 配列 A の要素数 N と配列 A の各要素 A_1, A_2, ..., A_N , 交換する A の要素番号　X, Y が与えられるので、A_X と A_Y を入れ替えた後の A を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());

    int[] A = new int[N];
    for (int i = 0; i < N; i++)
    {
      A[i] = int.Parse(Console.ReadLine());
    }

    string[] inputs = Console.ReadLine().Split(' ');
    int X = int.Parse(inputs[0]) - 1;
    int Y = int.Parse(inputs[1]) - 1;

    int tmp = A[X];
    A[X] = A[Y];
    A[Y] = tmp;

    foreach (int a in A)
    {
      Console.WriteLine(a);
    }
  }
}