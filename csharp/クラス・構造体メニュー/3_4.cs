// スーパースーパースーパーカー
// https://paiza.jp/works/mondai/class_primer/class_primer__super_super_supercar
// よくクラスの題材を扱う際に、「クラスは車の設計書」といった例が出てきます。
// スーパーカー販売店に勤務しながらクラスの勉強をしていた paiza 君はスーパーカーの走る様子をクラスを用いてシミュレーションしてみようと考えました。
// ただ車を走らせてもつまらないので、陸を走るスーパーカーに加えて、空を飛べるスーパースーパーカー ・ テレポートできるスーパースーパースーパーカー もシミュレーションに加えた
// 番号 1 〜 N の N 台のシミュレーションをすることにしました。

// それぞれの車について、初めに入っている燃料の量 l と燃費 f が定まっており、加えて、車種に応じて次のような機能を持ちます。

// ・スーパーカー
// run
// 燃料を 1 消費し、 f (km) 走る。
// 燃料が 0 の場合は何も起こらない。


// ・スーパースーパーカー
// run
// 燃料を 1 消費し、 f (km) 走る。
// 燃料が 0 の場合は何も起こらない。

// fly
// 燃料を 5 消費し、 f^2 (km) 飛行する。
// 燃料が 5 未満の場合は run を行う。


// ・スーパースーパースーパーカー
// run
// 燃料を 1 消費し、 f (km) 走る。
// 燃料が 0 の場合は何も起こらない。

// fly
// 燃料を 5 消費し、 2 * f^2 (km) 飛行する。
// 燃料が 5 未満の場合は run を行う。

// teleport
// 燃料を f^2 消費し、 f^4 (km) 移動する。
// 燃料が f^2 未満の場合は fly を行う。

// シミュレートする車の台数 N と機能を使う回数 K , N 台の車の車種と機能を使った車の番号と使った機能が与えられるので、全てのシミュレーションが終わった後の、各車ごとの総移動距離を求めてください。

using System;
using System.Collections.Generic;

class SuperCar
{
  public int Fuel { get; protected set; }
  public int FuelConsumption { get; protected set; }
  public int Mileage { get; protected set; }

  public SuperCar(int fuel, int fuelConsumption)
  {
    Fuel = fuel;
    FuelConsumption = fuelConsumption;
    Mileage = 0;
  }

  public virtual void Run()
  {
    if (Fuel <= 0)
    {
      return;
    }

    Fuel -= 1;
    Mileage += FuelConsumption;
  }

  public int GetMileage()
  {
    return Mileage;
  }
}

class SuperSuperCar : SuperCar
{
  public SuperSuperCar(int fuel, int fuelConsumption) : base(fuel, fuelConsumption)
  {
  }

  public virtual void Fly()
  {
    if (Fuel < 5)
    {
      base.Run();
    }
    else
    {
      Fuel -= 5;
      Mileage += FuelConsumption * FuelConsumption;
    }
  }
}

class SuperSuperSuperCar : SuperCar
{
  public SuperSuperSuperCar(int fuel, int fuelConsumption) : base(fuel, fuelConsumption)
  {
  }

  public override void Run()
  {
    base.Run();
  }

  public void Fly()
  {
    if (Fuel < 5)
    {
      base.Run();
    }
    else
    {
      Fuel -= 5;
      Mileage += 2 * FuelConsumption * FuelConsumption;
    }
  }

  public void Teleport()
  {
    if (Fuel < FuelConsumption * FuelConsumption)
    {
      Fly();
    }
    else
    {
      Fuel -= FuelConsumption * FuelConsumption;
      Mileage += FuelConsumption * FuelConsumption * FuelConsumption * FuelConsumption;
    }
  }
}

class Program
{
  static void Main()
  {
    // 入力処理
    string[] firstInput = Console.ReadLine().Split(' ');
    int n = int.Parse(firstInput[0]);
    int k = int.Parse(firstInput[1]);

    List<SuperCar> cars = new List<SuperCar>(n);

    // 車の初期化
    for (int i = 0; i < n; i++)
    {
      string[] carData = Console.ReadLine().Split(' ');
      string carType = carData[0];
      int fuel = int.Parse(carData[1]);
      int fuelConsumption = int.Parse(carData[2]);

      if (carType == "supercar")
      {
        cars.Add(new SuperCar(fuel, fuelConsumption));
      }
      else if (carType == "supersupercar")
      {
        cars.Add(new SuperSuperCar(fuel, fuelConsumption));
      }
      else
      {
        cars.Add(new SuperSuperSuperCar(fuel, fuelConsumption));
      }
    }

    // k回の操作処理
    for (int i = 0; i < k; i++)
    {
      string[] command = Console.ReadLine().Split(' ');
      int index = int.Parse(command[0]) - 1;
      string action = command[1];

      if (action == "run")
      {
        cars[index].Run();
      }
      else if (action == "fly")
      {
        if (cars[index] is SuperSuperCar superCar)
        {
          superCar.Fly();
        }
        else if (cars[index] is SuperSuperSuperCar superSuperCar)
        {
          superSuperCar.Fly();
        }
      }
      else if (action == "teleport")
      {
        if (cars[index] is SuperSuperSuperCar superSuperCar)
        {
          superSuperCar.Teleport();
        }
      }
    }

    // 結果の出力
    foreach (var car in cars)
    {
      Console.WriteLine(car.GetMileage());
    }
  }
}
