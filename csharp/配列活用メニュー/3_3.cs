// queue (9) 係
// https://paiza.jp/works/mondai/array_utilization_primer/array_utilization_primer__queue
// データ構造の queue と同様の働きをするロボットがあります。ロボットは指示に応じて配列 A に対して 2 種類の仕事を行います、仕事の内容は以下の通りです。
// ・in n と指示された場合、A の末尾に n を追加してください。
// ・out と指示された場合、A の先頭の要素を削除してください。ただし、A が既に空の場合、何も行わないでください。
// ロボットに与えられる指示の回数 N と、各指示の内容 S_i が与えられるので、ロボットが全ての処理を順に行った後の A の各要素を出力してください。
// なお、初め配列 A は空であるものとします。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());

    List<int> S = new List<int>();

    for (int i = 0; i < N; i++)
    {
      string[] inputs = Console.ReadLine().Split(' ');

      if (inputs[0] == "in")
      {
        int num = int.Parse(inputs[1]);
        S.Add(num);
      }
      else if (inputs[0] == "out" && S.Count() >= 1)
      {
        S.RemoveAt(0);
      }
    }

    foreach (int s in S)
    {
      Console.WriteLine(s);
    }
  }
}

// ---------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main()
  {
    Queue a = new Queue();
    IEnumerable<string> cs = Enumerable.Range(0, int.Parse(Console.ReadLine()))
                                       .Select(x => Console.ReadLine());

    foreach (string c in cs)
    {
      string[] s = c.Split(' ');
      switch (s[0])
      {
        case "in":
          a.Enqueue(s[1]);
          break;
        case "out":
          if (a.Count > 0)
          {
            a.Dequeue();
          }
          break;
        default:
          break;
      }
    }

    while (a.Count > 0)
    {
      Console.WriteLine(a.Dequeue());
    }
  }
}