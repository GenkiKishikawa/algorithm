// 構造体の作成
// https://paiza.jp/works/mondai/class_primer/class_primer__make
// クラスの学級委員である paiza 君は、クラスのみんなに次のような形式でアカウントの情報を送ってもらうよう依頼しました。

// 名前 年齢 誕生日 出身地

// 送ってもらったデータを使いやすいように整理したいと思った paiza 君はクラス全員分のデータを次の形式でまとめることにしました。

// User{
// nickname : 名前
// old : 年齢
// birth : 誕生日
// state : 出身地
// }


// クラスメートの情報が与えられるので、それらを以上の形式でまとめたものを出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());

    var persons = Enumerable.Range(0, N)
                            .Select(_ => Console.ReadLine().Split(' '))
                            .Select(x => new Person(x[0], x[1], x[2], x[3]))
                            .ToList();

    foreach (Person person in persons)
    {
      Console.WriteLine("User{");
      Console.WriteLine($"nickname : {person.nickname}");
      Console.WriteLine($"old : {person.old}");
      Console.WriteLine($"birth : {person.birth}");
      Console.WriteLine($"state : {person.state}");
      Console.WriteLine("}");
    }
  }
}

class Person
{
  public readonly string nickname;
  public readonly string old;
  public readonly string birth;
  public readonly string state;
  public Person(string nickname, string old, string birth, string state)
  {
    this.nickname = nickname;
    this.old = old;
    this.birth = birth;
    this.state = state;
  }
}