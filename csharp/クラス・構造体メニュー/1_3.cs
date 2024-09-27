// 構造体の整列
// https://paiza.jp/works/mondai/class_primer/class_primer__sort
// クラスの学級委員である paiza 君は、クラスのみんなに次のような形式でアカウントの情報を送ってもらうよう依頼しました。

// 名前 年齢 誕生日 出身地

// 送ってもらったデータを使いやすいように整理したいと思った paiza 君はクラス全員分のデータを次の形式でまとめることにしました。

// User{
//     nickname : 名前
//     old : 年齢
//     birth : 誕生日
//     state : 出身地
// }

// この情報を扱いやすくするために、年齢が昇順になるようにデータを並び替えることにしました。
// クラスメートの情報が与えられるので、並び替えた後のデータを出力してください。

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


    students.Sort((a, b) => int.Parse(a.old) - int.Parse(b.old));
    foreach (Student student in students)
    {
      Console.WriteLine($"{student.name} {student.old} {student.birth} {student.state}");
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