// クラスの作成
// https://paiza.jp/works/mondai/class_primer/class_primer__make_class
// エンジニアであり、社員を管理を管理する立場にあるあなたは、効率的に社員を管理するために、
// 各社員の社員番号 number と名前 name を持ち、加えて情報を返す関数を持つような構造体、すなわち次のようなメンバ変数とメンバ関数を持つ社員クラス class employee を作成することにしました。

// メンバ変数

// number : 整数
// name : 文字列


// メンバ関数
// getnum(){
//     return number;
// }
// getname(){
//     return name;
// }


// 入力で make number name と入力された場合は変数に number , name を持つ社員を作成し、 getnum n と入力された場合は n 番目に作成された社員の number を、getname n と入力された場合は n 番目に作成された社員の name を出力してください。

using System;
using System.Collections.Generic;

class Employee
{
  public int Number { get; set; }
  public string Name { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    int n = int.Parse(Console.ReadLine());
    List<Employee> list = new List<Employee>();
    for (int i = 0; i < n; i++)
    {
      string[] s = Console.ReadLine().Split(' ');
      int idx = 0;
      switch (s[0])
      {
        case "make":
          list.Add(new Employee() { Number = int.Parse(s[1]), Name = s[2] });
          break;
        case "getnum":
          idx = int.Parse(s[1]) - 1;
          Console.WriteLine(list[idx].Number);
          break;
        case "getname":
          idx = int.Parse(s[1]) - 1;
          Console.WriteLine(list[idx].Name);
          break;
      }
    }
  }
}

// -----------------------------------------------------------------------------------

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
