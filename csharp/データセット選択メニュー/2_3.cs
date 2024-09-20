// 文字列の配列
// https://paiza.jp/works/mondai/data_structure/data_structure__string_boss
// 縦 H マス、横 W マスの H × W マスからなる迷路 S があります。
// 上から i 行目、左から j 列目のマス は S_ij とあらわされ、 S_ij が「#」のとき壁であり、「.」のとき道です。整数 r、c が与えられるので、S_rc が壁かどうか判定してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    List<int> inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
    int H = inputs[0];
    int W = inputs[1];
    int r = inputs[2];
    int c = inputs[3];

    List<string> maze = Enumerable.Range(0, H).Select(_ => Console.ReadLine()).ToList();

    Console.WriteLine(maze[r - 1][c - 1] == '#' ? "Yes" : "No");
  }
}