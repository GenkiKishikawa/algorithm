// 出口のない迷路
// https://paiza.jp/works/mondai/class_primer/class_primer__closed_maze
// 洞窟を探検していたあなたは出口のない迷路に迷い込んでしまいました。
// 脱出するには、迷路の地点を与えられた指示通りに移動し、移動で訪れた（移動の開始・終了地点を含む）地点に置かれたアルファベットを
// つなげた文字列を呪文として唱える必要があります。
// 各頂点からは、他の頂点に向かって一方通行の 2 つの道が伸びています。
// 各ポイントの情報と移動の指示が与えられるので、呪文となる文字列を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Point
{
  public string Word { get; }
  public int PathA { get; }
  public int PathB { get; }

  public Point(string word, int pathA, int pathB)
  {
    Word = word;
    PathA = pathA;
    PathB = pathB;
  }

  public string GetWord()
  {
    return Word;
  }

  public int GetPath(int direction)
  {
    if (direction == 1)
    {
      return PathA;
    }
    else
    {
      return PathB;
    }
  }
}

class Paiza
{
  static void Main()
  {
    int[] inputs = Console.ReadLine()
                          .Split(' ')
                          .Select(x => int.Parse(x))
                          .ToArray();

    int N = inputs[0];
    int K = inputs[1];
    int S = inputs[2];

    Point[] maze = new Point[N];
    for (int i = 0; i < N; i++)
    {
      string[] values = Console.ReadLine().Split(' ');

      string word = values[0];
      int pathA = int.Parse(values[1]) - 1;
      int pathB = int.Parse(values[2]) - 1;

      maze[i] = new Point(word, pathA, pathB);
    }

    Point nowPoint = maze[S - 1];
    string ans = nowPoint.GetWord();

    for (int i = 0; i < K; i++)
    {
      int direction = int.Parse(Console.ReadLine());

      int to = nowPoint.GetPath(direction);
      nowPoint = maze[to];
      ans += nowPoint.GetWord();
    }

    Console.WriteLine(ans);
  }
}

