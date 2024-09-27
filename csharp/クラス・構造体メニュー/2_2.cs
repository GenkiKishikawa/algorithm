// コンストラクタ
// https://paiza.jp/works/mondai/class_primer/class_primer__constructor
// エンジニアのあなたの会社には、既に次のような社員クラス class employee が存在しています。

// メンバ変数
// 整数 number, 文字列 name

// メンバ関数

// getnumber(){
//     return number;
// }
// getname(){
//   return name;
// }


// 現状、この社員クラスの全てのメンバ変数・メンバ関数を設定するためには、インスタンス名.変数名 = 変数 といった具合に直接代入をしなくてはなりません。
// それは面倒なので、コンストラクタという機能を用いて、インスタンスを作成する際に インスタンス名 = new クラス名(number, name) とすることでメンバ変数を設定できるように書き換えましょう。

// 入力で make number name と入力された場合は各変数に number , name を持つ社員を作成し、getnum nと入力された場合は n 番目に作成された社員の number を、getname n と入力された場合は n 番目に作成された社員の name を出力してください。

using System;
using System.Collections.Generic;

class Employee
{
  public int Number { get; }
  public string Name { get; }

  public Employee(int number, string name)
  {
    Number = number;
    Name = name;
  }

  public int GetNumber()
  {
    return Number;
  }

  public string GetName()
  {
    return Name;
  }
}

class Program
{
  static void Main(string[] args)
  {
    // 入力処理
    int n = int.Parse(Console.ReadLine());

    // 社員リスト
    List<Employee> employees = new List<Employee>();

    for (int i = 0; i < n; i++)
    {
      string query = Console.ReadLine();
      string[] parts = query.Split(' ');

      if (parts[0] == "make")
      {
        int number = int.Parse(parts[1]);
        string name = parts[2];
        employees.Add(new Employee(number, name));
      }
      else if (parts[0] == "getnum")
      {
        int index = int.Parse(parts[1]) - 1;
        Console.WriteLine(employees[index].GetNumber());
      }
      else if (parts[0] == "getname")
      {
        int index = int.Parse(parts[1]) - 1;
        Console.WriteLine(employees[index].GetName());
      }
    }
  }
}