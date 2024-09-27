// 構造体の更新
// https://paiza.jp/works/mondai/class_primer/class_primer__change
// クラスの学級委員である paiza 君は、クラスのみんなに次のような形式でアカウントの情報を送ってもらうよう依頼しました。

// 名前 年齢 誕生日 出身地

// 送ってもらったデータを使いやすいように整理したいと思った paiza 君はクラス全員分のデータを次の形式でまとめることにしました。

// User{
//     nickname : 名前
//     old : 年齢
//     birth : 誕生日
//     state : 出身地
// }

// 途中で名前が変わった際にいちいちデータを修正するのが面倒だと思ったあなたは、生徒の構造体と新しい名前を受け取り、その名前を修正する関数 changeName を作成し、それを用いて生徒の名前を更新することにしました。

// クラスの人数と全員の情報、更新についての情報が与えられるので、入力に従って名前を更新した後のクラスのメンバーの情報を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

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

    List<Student> students = Enumerable.Range(0, N)
                                       .Select(_ => Console.ReadLine().Split(' '))
                                       .Select(x => new Student(x[0], x[1], x[2], x[3]))
                                       .ToList();

    for (int i = 0; i < K; i++)
    {
      string[] controller = Console.ReadLine().Split(' ');

      int index = int.Parse(controller[0]) - 1;
      string update_name = controller[1];

      students[index].name = update_name;
    }

    foreach (Student student in students)
    {
      Console.WriteLine($"{student.name} {student.old} {student.birth} {student.state}");
    }
  }
}

class Student
{
  public string name;
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