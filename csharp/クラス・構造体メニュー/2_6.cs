// デフォルト引数
// https://paiza.jp/works/mondai/class_primer/class_primer__set_default
// 居酒屋で働きながらクラスの勉強をしていたあなたは、お客さんをクラスに見立てることで店内の情報を管理できることに気付きました。
// 全てのお客さんは、ソフトドリンクと食事を頼むことができます。加えて 20 歳以上のお客さんはお酒を頼むことができます。
// 20 歳未満のお客さんがお酒を頼もうとした場合はその注文は取り消されます。
// また、お酒（ビールを含む）を頼んだ場合、以降の全ての食事の注文 が毎回 200 円引きになります。

// 今回、この居酒屋でビールフェスをやることになり、ビールの注文が相次いだため、いちいちビールの値段である 500 円を書くのをやめ、伝票に注文の種類と値段を書く代わりに 0 とだけを書くことになりました。

// 店内の全てのお客さんの数と注文の回数、各注文をしたお客さんの番号とその内容が与えられるので、各お客さんの会計を求めてください。

using System;
using System.Collections.Generic;

class Customer
{
  public int Amount { get; protected set; }

  public Customer()
  {
    Amount = 0;
  }

  public virtual void TakeFood(int m)
  {
    Amount += m;
  }

  public virtual void TakeSoftDrink(int m)
  {
    Amount += m;
  }

  public virtual void TakeAlcohol(int m) { }

  public virtual void TakeAlcohol()
  {
    // アルコールをデフォルトで500消費
    TakeAlcohol(500);
  }
}

class Adult : Customer
{
  private bool drunk;

  public Adult() : base()
  {
    drunk = false;
  }

  public override void TakeFood(int m)
  {
    if (drunk)
    {
      m -= 200;
    }
    base.TakeFood(m);
  }

  public override void TakeAlcohol(int m)
  {
    drunk = true;
    Amount += m;
  }
}

class Program
{
  static void Main(string[] args)
  {
    // 入力の処理
    string[] initialInput = Console.ReadLine().Split(' ');
    int n = int.Parse(initialInput[0]);
    int k = int.Parse(initialInput[1]);

    // 顧客リストの作成
    List<Customer> customers = new List<Customer>();

    // n人の顧客を作成
    for (int i = 0; i < n; i++)
    {
      int age = int.Parse(Console.ReadLine());
      if (age < 20)
      {
        customers.Add(new Customer());
      }
      else
      {
        customers.Add(new Adult());
      }
    }

    // k回の注文を処理
    for (int i = 0; i < k; i++)
    {
      string[] order = Console.ReadLine().Split(' ');
      int index = int.Parse(order[0]) - 1;
      string item = order[1];

      if (item == "0")
      {
        // アルコールを500消費する場合
        customers[index].TakeAlcohol();
      }
      else
      {
        int amount = int.Parse(order[2]);
        if (item == "food")
        {
          customers[index].TakeFood(amount);
        }
        else if (item == "softdrink")
        {
          customers[index].TakeSoftDrink(amount);
        }
        else if (item == "alcohol")
        {
          customers[index].TakeAlcohol(amount);
        }
      }
    }

    // 各顧客の最終的な amount を出力
    foreach (Customer customer in customers)
    {
      Console.WriteLine(customer.Amount);
    }
  }
}
