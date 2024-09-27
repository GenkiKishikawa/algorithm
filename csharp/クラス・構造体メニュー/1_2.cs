// 構造体の検索
// https://paiza.jp/works/mondai/class_primer/class_primer__find
// クラスの学級委員である paiza 君は、クラスのみんなに次のような形式でアカウントの情報を送ってもらうよう依頼しました。

// 名前 年齢 誕生日 出身地

// 送ってもらったデータを使いやすいように整理したいと思った paiza 君はクラス全員分のデータを次のような構造体でまとめることにしました。

// student{
//     name : 名前
//     old : 年齢
//     birth : 誕生日
//     state : 出身地
// }


// 年齢ごとの生徒の名簿を作る仕事を任された paiza 君はクラスメイトのうち、決まった年齢の生徒を取り出したいと考えました。
// 取り出したい生徒の年齢が与えられるので、その年齢の生徒の名前を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());
    List<Student> students = Enumerable.Range(0, N)
                                       .Select(_ => Console.ReadLine().Split(' '))
                                       .Select(x => new Student(x[0], x[1], x[2], x[3]))
                                       .ToList();

    string K = Console.ReadLine();

    foreach (Student student in students)
    {
      if (student.old == K)
      {
        Console.WriteLine(student.name);
      }
    }
  }
}

class Student
{
  public readonly string name;
  public readonly string old;
  public readonly string birth;
  public readonly string state;
  public Student(string name, string old, string birth, string state)
  {
    this.name = name;
    this.old = old;
    this.birth = birth;
    this.state = state;
  }
}