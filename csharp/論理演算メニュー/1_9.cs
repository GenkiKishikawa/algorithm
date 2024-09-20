// 全加算器
// https://paiza.jp/works/mondai/logical_operation/logical_operation__basic_step9
// 京子ちゃんは 二進数 の整数同士で足し算をするプログラムを作成したいと思っています。
// 二進数の足し算において、下から 1 けた目の計算は半加算器でできることを知り、 2 けた目の計算も同じように足し算ができないかと考えています。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    List<int> inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
    int A = inputs[0];
    int B = inputs[1];
    int C1 = inputs[2];

    int Cx = A & B;
    int Sy = A ^ B;

    int Cy = Sy & C1;
    int S = Sy ^ C1;

    int C2 = Cx ^ Cy;

    Console.WriteLine($"{C2} {S}");
  }
}

// ----------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main()
  {
    List<bool> vs = Console.ReadLine()
                           .Split(' ')
                           .Select(x => int.Parse(x))
                           .Select(x => Convert.ToBoolean(x))
                           .ToList();
    bool a = vs[0];
    bool b = vs[1];
    bool c1 = vs[2];

    HalfAdder(a, b, out bool cx, out bool sy);
    HalfAdder(sy, c1, out bool cy, out bool s);
    bool c2 = cx || cy;

    Console.WriteLine($"{Convert.ToByte(c2)} {Convert.ToByte(s)}");
  }

  static void HalfAdder(bool a, bool b, out bool c, out bool s)
  {
    c = a && b;
    s = a ^ b;
  }
}