// 格闘ゲーム
// https://paiza.jp/works/mondai/class_primer/class_primer__fighting_game
// 友達の家で N 人で遊んでいる paiza 君は格闘ゲームを遊ぶことにしました。
// 格闘ゲームのルールは次の通りです。

// ・ 各プレイヤーは 決まった hp と 3 種類の技を持っていて、技には強化系の技と攻撃の技があり、各攻撃技には技を出すための発生フレーム F とダメージ A が設定されている。

// ・ hp が 0 になったプレイヤーは退場となる。

// ・あるプレイヤー 1 が、他のプレイヤーにある技 T_1 (発生フレーム F_1 , 攻撃力 A_1) を使って攻撃した場合、攻撃を受けたプレイヤー 2 は反撃の技 T_2 (発生フレーム F_2 , 攻撃力 A_2) を選ぶ。その後、次のようなルールに従っていずれかのプレイヤーにダメージが入る。


// どちらか片方でもプレイヤーが退場している場合、互いに何も起こらない。


// 強化系の技を使った場合、使ったプレイヤーの他の全ての技の発生フレーム（最短 1 フレーム) を -3 , 攻撃力を +5 する。
// 相手が攻撃技を使っていた場合、その攻撃の攻撃力分 hp が減少する。


// 互いに攻撃技を使った場合
// ・ F_1 < F_2 のとき、プレイヤー 2 の hp が A_1 減る
// ・ F_1 > F_2 のとき、プレイヤー 1 の hp が A_2 減る
// ・ F_1 = F_2 のとき、何も起こらない


// 各プレイヤーの持っている技についての情報と、技が出された回数、使われた技の詳細が与えられるので、全ての技が使われた後に場に残っているプレイヤーの人数を答えてください。

using System;
using System.Collections.Generic;

class Player
{
  public int Hp { get; private set; }
  public int[] F { get; private set; }
  public int[] A { get; private set; }
  public bool Alive { get; private set; }

  public Player(int hp, int f1, int a1, int f2, int a2, int f3, int a3)
  {
    Hp = hp;
    F = new int[] { f1, f2, f3 };
    A = new int[] { a1, a2, a3 };
    Alive = true;
  }

  public void Enhance()
  {
    for (int i = 0; i < 3; i++)
    {
      if (F[i] == 0 && A[i] == 0)
      {
        continue;
      }

      F[i] = Math.Max(F[i] - 3, 1);
      A[i] += 5;
    }
  }

  public void CalcHp(int damage)
  {
    Hp -= damage;
    if (Hp <= 0)
    {
      Alive = false;
    }
  }

  public (int, int) GetStatus(int i)
  {
    return (F[i], A[i]);
  }

  public bool GetAlive()
  {
    return Alive;
  }
}

class Program
{
  static void Main()
  {
    // 入力処理
    string[] firstInput = Console.ReadLine().Split(' ');
    int n = int.Parse(firstInput[0]);
    int k = int.Parse(firstInput[1]);

    List<Player> players = new List<Player>(n);

    // プレイヤーの初期化
    for (int i = 0; i < n; i++)
    {
      string[] playerData = Console.ReadLine().Split(' ');
      int hp = int.Parse(playerData[0]);
      int f1 = int.Parse(playerData[1]);
      int a1 = int.Parse(playerData[2]);
      int f2 = int.Parse(playerData[3]);
      int a2 = int.Parse(playerData[4]);
      int f3 = int.Parse(playerData[5]);
      int a3 = int.Parse(playerData[6]);

      players.Add(new Player(hp, f1, a1, f2, a2, f3, a3));
    }

    // イベント処理
    for (int i = 0; i < k; i++)
    {
      string[] values = Console.ReadLine().Split(' ');
      int p1 = int.Parse(values[0]) - 1;
      int t1 = int.Parse(values[1]) - 1;
      int p2 = int.Parse(values[2]) - 1;
      int t2 = int.Parse(values[3]) - 1;

      (int f1, int a1) = players[p1].GetStatus(t1);
      (int f2, int a2) = players[p2].GetStatus(t2);

      if (!players[p1].GetAlive() || !players[p2].GetAlive())
      {
        continue;
      }

      if (f1 == 0 && a1 == 0 && f2 == 0 && a2 == 0)
      {
        players[p1].Enhance();
        players[p2].Enhance();
      }
      else if (f1 == 0 && a1 == 0)
      {
        players[p1].Enhance();
        players[p1].CalcHp(a2);
      }
      else if (f2 == 0 && a2 == 0)
      {
        players[p2].Enhance();
        players[p2].CalcHp(a1);
      }
      else
      {
        if (f1 > f2)
        {
          players[p1].CalcHp(a2);
        }
        else if (f1 < f2)
        {
          players[p2].CalcHp(a1);
        }
      }
    }

    // 生存者の数をカウント
    int aliveCount = 0;
    foreach (var player in players)
    {
      if (player.GetAlive())
      {
        aliveCount++;
      }
    }

    // 結果を出力
    Console.WriteLine(aliveCount);
  }
}
