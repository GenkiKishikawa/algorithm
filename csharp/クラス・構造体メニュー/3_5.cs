// ロボットの暴走
// https://paiza.jp/works/mondai/class_primer/class_primer__robot_move
// paiza 株式会社では、物品の管理のために上の図のような座標系の広さが無限大のマスの工場 で 番号 1 〜 N が割り当てられた N 台のロボットを運用していました。ところがある日、全てのロボットが暴走してしまいました。各ロボットは性能ごとにレベル分けされており、次の通り移動距離が決まっています。

// Lv1 : 特定の方角に 1 マス進む
// Lv2 : 特定の方角に 2 マス進む
// Lv3 : 特定の方角に 5 マス進む
// Lv4 : 特定の方角に 10 マス進む

// また、工場のマスのうち 10 マスには工具箱が置かれており、移動後にそのマスにロボットがぴったり止まっていた場合、そのロボットのレベルが 1 上がってしまいます（最大レベルは 4)。
// レベル l のロボットの初期位置が工具箱の置かれているマスであったとしても、そのロボットのレベルは l で始まることに気をつけてください。

// 幸い、初めにロボットがいる範囲や工具箱の置かれているマス、各ロボットの位置とレベル、また、どのロボットがどのような順番でどの方角に移動するかの情報はわかっているので、ロボットの移動が K 回終わったときの各ロボットの位置とレベルを推定してください。

using System;

class Robot
{
  // ステップの静的フィールド
  public static int[] Step = { 0, 1, 2, 5, 10 };

  public int X { get; private set; }
  public int Y { get; private set; }
  public int L { get; private set; }

  public Robot(int x, int y, int l)
  {
    X = x;
    Y = y;
    L = l;
  }

  public void Move(char direction)
  {
    if (direction == 'N')
    {
      Y -= Step[L];
    }
    else if (direction == 'S')
    {
      Y += Step[L];
    }
    else if (direction == 'E')
    {
      X += Step[L];
    }
    else if (direction == 'W')
    {
      X -= Step[L];
    }
  }

  public void LevelUp()
  {
    L++;
  }

  public override string ToString()
  {
    return $"{X} {Y} {L}";
  }
}

class Program
{
  static void Main()
  {
    // 入力の処理
    string[] inputs = Console.ReadLine().Split(' ');
    int h = int.Parse(inputs[0]);
    int w = int.Parse(inputs[1]);
    int n = int.Parse(inputs[2]);
    int k = int.Parse(inputs[3]);

    int[] lx = new int[10];
    int[] ly = new int[10];
    for (int i = 0; i < 10; i++)
    {
      string[] boxInput = Console.ReadLine().Split(' ');
      lx[i] = int.Parse(boxInput[0]);
      ly[i] = int.Parse(boxInput[1]);
    }

    Robot[] robots = new Robot[n];
    for (int i = 0; i < n; i++)
    {
      string[] robotInput = Console.ReadLine().Split(' ');
      int x = int.Parse(robotInput[0]);
      int y = int.Parse(robotInput[1]);
      int l = int.Parse(robotInput[2]);
      robots[i] = new Robot(x, y, l);
    }

    for (int i = 0; i < k; i++)
    {
      string[] commandInput = Console.ReadLine().Split(' ');
      int r = int.Parse(commandInput[0]) - 1;
      char d = commandInput[1][0];

      robots[r].Move(d);

      bool levelUp = false;
      for (int j = 0; j < 10; j++)
      {
        if (robots[r].X == lx[j] && robots[r].Y == ly[j])
        {
          levelUp = true;
          break;
        }
      }

      if (levelUp)
      {
        robots[r].LevelUp();
      }
    }

    foreach (Robot robot in robots)
    {
      Console.WriteLine(robot);
    }
  }
}
