// 長方形に含まれる点
// https://paiza.jp/works/mondai/sequence_search_problems/sequence_search_problems_search_condition_step5
// 整数 n と、二次元平面上の点 1 ~ n の座標 (x_1, y_1), ... , (x_n, y_n), 整数 x_s, x_t, y_s, y_t が与えられます。
// n 個の点のうち、(x_s, y_s), (x_s, y_t), (x_t, y_t), (x_t, y_s) の4頂点からなる長方形の内部に含まれている点の数を求めてください。なお、長方形の辺上にある点は長方形に含まれているものとします。

using System;

class Paiza
{
  static void Main()
  {
    // 整数 n
    int n = int.Parse(Console.ReadLine());

    // 二次元平面上の点 1 ~ n の座標 (x_1, y_1), ... , (x_n, y_n)
    int[] x = new int[n];
    int[] y = new int[n];
    for (int i = 0; i < n; i++)
    {
      string[] input = Console.ReadLine().Split(' ');
      x[i] = int.Parse(input[0]);
      y[i] = int.Parse(input[1]);
    }

    // 整数 x_s, x_t
    int[] outside_x = new int[2];
    string[] input_x = Console.ReadLine().Split(' ');
    outside_x[0] = int.Parse(input_x[0]);
    outside_x[1] = int.Parse(input_x[1]);

    // 整数 y_s, y_t
    int[] outside_y = new int[2];
    string[] input_y = Console.ReadLine().Split(' ');
    outside_y[0] = int.Parse(input_y[0]);
    outside_y[1] = int.Parse(input_y[1]);

    int ans = 0;
    // ループで線形探索
    for (int i = 0; i < n; i++)
    {
      if(outside_x[0] <= x[i] && x[i] <= outside_x[1])
      {
        if(outside_y[0] <= y[i] && y[i] <= outside_y[1])
        {
          ans++;
        }
      }
    }
    Console.WriteLine(ans);
  }
}

// -----------------------------------------------------

using System;

class paiza
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] x = new int[n];
        int[] y = new int[n];
        for (int i = 0; i < n; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            x[i] = int.Parse(inputs[0]);
            y[i] = int.Parse(inputs[1]);
        }

        string[] inputs2 = Console.ReadLine().Split(' ');
        int xS = int.Parse(inputs2[0]);
        int xT = int.Parse(inputs2[1]);

        string[] inputs3 = Console.ReadLine().Split(' ');
        int yS = int.Parse(inputs3[0]);
        int yT = int.Parse(inputs3[1]);

        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            bool horizontal = (xS <= x[i]) && (x[i] <= xT);
            bool vertical = (yS <= y[i]) && (y[i] <= yT);
            if (horizontal && vertical)
            {
                answer++;
            }
        }

        Console.WriteLine(answer);
    }
}