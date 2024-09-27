// クラスの継承
// https://paiza.jp/works/mondai/class_primer/class_primer__inheritance
// paiza 国の大衆居酒屋で働きながらクラスの勉強をしていたあなたは、お客さんをクラスに見立てることで店内の情報を管理できることに気付きました。
// 全てのお客さんは、ソフトドリンクと食事を頼むことができます。
// paiza 国の法律では、 20 歳以上のお客さんは成人とみなされ、お酒を頼むことができます。
// 20 歳未満のお客さんは未成年とみなされ、お酒を頼もうとした場合はその注文は取り消されます。
// また、お酒を頼んだ場合、以降の全ての食事の注文 が毎回 200 円引きになります.

// 店内の全てのお客さんの数と注文の回数、各注文をしたお客さんの番号とその内容が与えられるので、各お客さんの会計を求めてください。

// ヒント

// 注文について、20 歳未満のお客さんにできて、 20 歳以上のお客さんにできないことはないので、20歳未満のお客さんのクラスを作成して、それを継承して 20歳以上のお客さんのクラスを作成することで効率よく実装することができます。

using System;
using System.Collections.Generic;
using System.Linq;

class Customer
{
  public int Total { get; set; }

  public Customer()
  {
    Total = 0;
  }

  public virtual void TakeFood(int m)
  {
    Total += m;
  }

  public virtual void TakeSoftDrink(int m)
  {
    Total += m;
  }

  public virtual void TakeAlcohol(int m)
  {

  }
}

class Adult : Customer
{
  private bool Drunk;

  public Adult() : base()
  {
    Drunk = false;
  }

  public override void TakeFood(int m)
  {
    if (Drunk)
    {
      m -= 200;
    }
    base.TakeFood(m);
  }

  public override void TakeAlcohol(int m)
  {
    Drunk = true;
    Total += m;
  }
}

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

    List<Customer> customers = new List<Customer>();

    for (int i = 0; i < N; i++)
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

    for (int i = 0; i < K; i++)
    {
      string[] orderInput = Console.ReadLine().Split(' ');
      int index = int.Parse(orderInput[0]) - 1;
      string order = orderInput[1];
      int amount = int.Parse(orderInput[2]);

      switch (order)
      {
        case "food":
          customers[index].TakeFood(amount);
          break;
        case "softdrink":
          customers[index].TakeSoftDrink(amount);
          break;
        case "alcohol":
          customers[index].TakeAlcohol(amount);
          break;
      }
    }

    foreach (Customer customer in customers)
    {
      Console.WriteLine(customer.Total);
    }
  }
}