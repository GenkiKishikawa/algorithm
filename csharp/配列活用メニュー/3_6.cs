// ボウリング
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__bowling
// あなたはボウリングをしています。フレームの 1 投目を投げ終わったあなたは、次に狙うピンの番号と残っているピンの本数を知りたくなりました。
// ピンの情報が与えられるので、狙うべきピンの番号と残っているピンの本数を求めてください。
// 狙うピンの決め方は次の通りとします。
// - 残っているピンのうち、先頭 (P_1側) のピンを狙います。ただし、同じ列に複数ピンがある場合は、それらのうちピン番号が最も小さいピンを狙います。

using System;
using System.Linq;

class Program
{
  static void Main()
  {
    var pins = Enumerable.Range(0, 4)
                               .Select(_ =>
                                    Console.ReadLine()
                                           .Split(' ')
                                           .Select(x => int.Parse(x))
                                )
                               .SelectMany(x => x)
                               .Reverse()
                               .Select((x, i) => new { x, i })
                               .Where(x => x.x != 0)
                               .ToList();

    Console.WriteLine(pins.Min(x => x.i) + 1);
    Console.WriteLine(pins.Count());
  }
}