// 価格の算出
// https://paiza.jp/works/mondai/data_structure/data_structure__dict_step4
// paiza 商店では N 個の商品が売られており、i 番目の商品の名前は A_i で、価格は B_i です。
// あなたは M 個の商品名が書かれたお買い物リスト S を持っています。リストに書かれているそれぞれの商品について、paiza 商店での価格を出力してください。
// リストには paiza 商店が扱っていない商品も書かれている可能性がありますが、その場合は価格の代わりに -1 を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main()
  {
    string[] nm = Console.ReadLine().Split(' ');
    int n = int.Parse(nm[0]);
    int m = int.Parse(nm[1]);

    List<Item> itemList = Enumerable.Range(0, n)
                                    .Select(_ => new Item(Console.ReadLine().Split(' ')))
                                    .ToList();

    Enumerable.Range(0, m)
              .Select(_ => Console.ReadLine())
              .Select(x => itemList.FirstOrDefault(y => y.ItemName == x)?.Price ?? -1)
              .ToList()
              .ForEach(x => Console.WriteLine(x));
  }
}
class Item
{
  public string ItemName { get; private set; }
  public int Price { get; private set; }

  public Item(string[] input)
  {
    ItemName = input[0];
    Price = int.Parse(input[1]);
  }
}

// -----------------------------------------------------

using System;
using System.Collections.Generic;

class Paiza
{
  static void Main()
  {
    string[] input = Console.ReadLine().Split();
    int N = int.Parse(input[0]);
    int M = int.Parse(input[1]);

    Dictionary<string, int> stock = new Dictionary<string, int>();

    for (int i = 0; i < N; i++)
    {
      string[] item = Console.ReadLine().Split();
      string a = item[0];
      int b = int.Parse(item[1]);
      stock[a] = b;
    }

    for (int i = 0; i < M; i++)
    {
      string s = Console.ReadLine();
      if (stock.ContainsKey(s))
      {
        Console.WriteLine(stock[s]);
      }
      else
      {
        Console.WriteLine(-1);
      }
    }
  }
}