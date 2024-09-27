// クラスのメンバの更新
// https://paiza.jp/works/mondai/class_primer/class_primer__change_member
// エンジニアであり、社員を管理する立場にあるあなたが勤める会社には、効率的に社員を管理するために、次のようなメンバ変数とメンバ関数を持つ社員クラス class employee が存在しています。

// メンバ変数
// 整数 number, 文字列 name

// メンバ関数

// getnum(){
//     return number;
// }
// getname(){
//     return name;
// }


// しかし、この社員クラスについて、社員番号や名前が変わった際にいちいち手動で更新するのは面倒だと感じたあなたは、引数に元の社員番号と新しい社員番号を指定すれば、新しい社員番号に更新してくれる関数 change_num と 引数に元の名前と新しい名前を指定すれば、新しい名前に更新してくれる関数 change_name を作成することにしました。

// 入力で make number name と入力された場合は変数にnumber, nameを持つ社員を作成し、getnum nと入力された場合は n 番目に作成された社員の number を、getname n と入力された場合は n 番目に作成された社員の name を出力してください。

// また、 change_num n newnum と入力された場合は、n 番目に作成された社員の number を、 newnum に変更し、 change_name n newname と入力された場合は、n 番目に作成された社員の name を、 newname に変更してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
  public int Number { get; private set; }
  public string Name { get; private set; }

  public Employee(int number, string name)
  {
    Number = number;
    Name = name;
  }

  public int GetNum()
  {
    return Number;
  }

  public string GetName()
  {
    return Name;
  }

  public void ChangeNum(int newNum)
  {
    Number = newNum;
  }

  public void ChangeName(string newName)
  {
    Name = newName;
  }
}

class Paiza
{
  static void Main()
  {
    int N = int.Parse(Console.ReadLine());

    List<string[]> S = Enumerable.Range(0, N)
                               .Select(_ => Console.ReadLine().Split(' '))
                               .ToList();

    List<Employee> employees = new List<Employee>();

    foreach (string[] s in S)
    {
      string order = s[0];
      switch (order)
      {
        case "make":
          employees.Add(new Employee(int.Parse(s[1]), s[2]));
          break;
        case "getnum":
          Console.WriteLine(employees[int.Parse(s[1]) - 1].GetNum());
          break;
        case "getname":
          Console.WriteLine(employees[int.Parse(s[1]) - 1].GetName());
          break;
        case "change_num":
          employees[int.Parse(s[1]) - 1].ChangeNum(int.Parse(s[2]));
          break;
        case "change_name":
          employees[int.Parse(s[1]) - 1].ChangeName(s[2]);
          break;
      }
    }
  }
}