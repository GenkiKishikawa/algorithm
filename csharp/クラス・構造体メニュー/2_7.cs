// 静的メンバ
// https://paiza.jp/works/mondai/class_primer/class_primer__static_member
// 居酒屋で働きながらクラスの勉強をしていたあなたは、お客さんをクラスに見立てることで勤務時間中の店内の人数や注文の情報を管理できることに気付きました。
// 全てのお客さんは、ソフトドリンクと食事を頼むことができます。加えて 20 歳以上のお客さんはお酒を頼むことができます。
// 20 歳未満のお客さんがお酒を頼もうとした場合はその注文は取り消されます。
// また、お酒（ビールを含む）を頼んだ場合、以降の全ての食事の注文 が毎回 200 円引きになります。

// 今回、この居酒屋でビールフェスをやることになり、ビールの注文が相次いだため、いちいちビールの値段である 500 円を書くのをやめ、注文の種類と値段を書く代わりに 0 とだけを書くことになりました。

// 勤務時間の初めに店内にいるお客さんの人数と与えられる入力の回数、各注文をしたお客さんの番号とその内容、または退店したお客さんの番号が与えられます。
// お客さんが退店する場合はそのお客さんの会計を出力してください。勤務時間中に退店した全てのお客さんの会計を出力したのち、勤務時間中に退店した客の人数を出力してください。

using System;
using System.Collections.Generic;

class Customer
{
  public static int N { get; private set; } = 0;
  public int Sum { get; protected set; }

  public Customer()
  {
    Sum = 0;
  }

  public virtual void TakeFood(int price)
  {
    Sum += price;
  }

  public virtual void TakeSoftDrink(int price)
  {
    Sum += price;
  }

  public virtual void TakeAlcohol(int price = 500)
  {
    // 何もしない (未成年者はアルコールを注文できない)
  }

  public void Accounting()
  {
    N += 1;
    Console.WriteLine(Sum);
  }
}

class Adult : Customer
{
  private bool alcoholConsumed;

  public Adult() : base()
  {
    alcoholConsumed = false;
  }

  public override void TakeFood(int price)
  {
    if (alcoholConsumed)
    {
      Sum += price - 200;
    }
    else
    {
      Sum += price;
    }
  }

  public override void TakeAlcohol(int price = 500)
  {
    Sum += price;
    alcoholConsumed = true;
  }
}

class Program
{
  static void Main()
  {
    // 入力処理
    string[] inputs = Console.ReadLine().Split(' ');
    int n = int.Parse(inputs[0]);
    int k = int.Parse(inputs[1]);

    List<Customer> customers = new List<Customer>(n);

    // 顧客の年齢に応じて Customer または Adult インスタンスを作成
    for (int i = 0; i < n; i++)
    {
      int age = int.Parse(Console.ReadLine());
      if (age >= 20)
      {
        customers.Add(new Adult());
      }
      else
      {
        customers.Add(new Customer());
      }
    }

    // k回の注文処理
    for (int i = 0; i < k; i++)
    {
      string[] order = Console.ReadLine().Split(' ');
      int index = int.Parse(order[0]) - 1;
      string action = order[1];

      if (action == "0")
      {
        customers[index].TakeAlcohol();
      }
      else if (action == "A")
      {
        customers[index].Accounting();
      }
      else
      {
        int price = int.Parse(order[2]);

        if (action == "food")
        {
          customers[index].TakeFood(price);
        }
        else if (action == "softdrink")
        {
          customers[index].TakeSoftDrink(price);
        }
        else
        {
          customers[index].TakeAlcohol(price);
        }
      }
    }

    // 静的メンバ Customer.N の値を出力
    Console.WriteLine(Customer.N);
  }
}
