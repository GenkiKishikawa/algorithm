// RPG
// https://paiza.jp/works/mondai/class_primer/class_primer__heros
// paiza 村にたびたび魔物が訪れるため、 1 〜 N 番の番号が割り当てられた N 人の勇者を雇うことにしました。
// 勇者には次のようなステータスを持ちます。

// レベル l_i
// 体力 h_i
// 攻撃力 a_i
// 防御力 d_i
// 素早さ s_i
// 賢さ c_i
// 運 f_i

// また、各勇者には次のようなイベントが発生します。

// levelup h a d s c f
// レベルが 1 上昇
// 体力が h 上昇
// 攻撃力が a 上昇
// 防御力が d 上昇
// 素早さが s 上昇
// 賢さが c 上昇
// 運が f 上昇

// muscle_training h a
// 体力が h 上昇
// 攻撃力が a 上昇

// running d s
// 防御力が d 上昇
// 素早さが s 上昇

// study c
// 賢さが c 上昇

// pray f
// 運が f 上昇

// 各勇者の初期ステータスと起こるイベントの回数、
// また、起こるイベントとその対象の勇者の番号が与えられるので、
// 全てのイベントが終わった後の各勇者のステータスを出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Hero
{
  public int Level { get; set; }
  public int Health { get; set; }
  public int Attack { get; set; }
  public int Deffence { get; set; }
  public int Speed { get; set; }
  public int Clever { get; set; }
  public int Luck { get; set; }

  public Hero(int level, int health, int attack, int deffence, int speed, int clever, int luck)
  {
    Level = level;
    Health = health;
    Attack = attack;
    Deffence = deffence;
    Speed = speed;
    Clever = clever;
    Luck = luck;
  }

  public void Levelup(int health, int attack, int deffence, int speed, int clever, int luck)
  {
    Level++;
    Health += health;
    Attack += attack;
    Deffence += deffence;
    Speed += speed;
    Clever += clever;
    Luck += luck;
  }

  public void MuscleTraining(int health, int attack)
  {
    Health += health;
    Attack += attack;
  }

  public void Running(int deffence, int speed)
  {
    Deffence += deffence;
    Speed += speed;
  }

  public void Study(int clever)
  {
    Clever += clever;
  }

  public void Pray(int luck)
  {
    Luck += luck;
  }

  public void PrintStatic()
  {
    Console.WriteLine($"{Level} {Health} {Attack} {Deffence} {Speed} {Clever} {Luck}");
  }
}

class Paiza
{
  static void Main()
  {
    int[] nk = Console.ReadLine()
                          .Split(' ')
                          .Select(x => int.Parse(x))
                          .ToArray();

    int N = nk[0];
    int K = nk[1];

    Hero[] heros = new Hero[N];

    for (int i = 0; i < N; i++)
    {
      int[] param = Console.ReadLine()
                           .Split(' ')
                           .Select(x => int.Parse(x))
                           .ToArray();

      int level = param[0];
      int health = param[1];
      int attack = param[2];
      int deffence = param[3];
      int speed = param[4];
      int clever = param[5];
      int luck = param[6];

      heros[i] = new Hero(level, health, attack, deffence, speed, clever, luck);
    }

    for (int i = 0; i < K; i++)
    {
      string[] inputs = Console.ReadLine()
                               .Split(' ')
                               .ToArray();

      int index = int.Parse(inputs[0]) - 1;
      string action = inputs[1];

      switch (action)
      {
        case "levelup":
          int h = int.Parse(inputs[2]);
          int a = int.Parse(inputs[3]);
          int d = int.Parse(inputs[4]);
          int s = int.Parse(inputs[5]);
          int c = int.Parse(inputs[6]);
          int f = int.Parse(inputs[7]);
          heros[index].Levelup(h, a, d, s, c, f);
          break;
        case "muscle_training":
          heros[index].MuscleTraining(int.Parse(inputs[2]), int.Parse(inputs[3]));
          break;
        case "running":
          heros[index].Running(int.Parse(inputs[2]), int.Parse(inputs[3]));
          break;
        case "study":
          heros[index].Study(int.Parse(inputs[2]));
          break;
        case "pray":
          heros[index].Pray(int.Parse(inputs[2]));
          break;
      }
    }

    foreach (Hero hero in heros)
    {
      hero.PrintStatic();
    }
  }
}