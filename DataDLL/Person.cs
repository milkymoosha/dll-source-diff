// Decompiled with JetBrains decompiler
// Type: DataDLL.Person
// Assembly: WpfApp1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA9405B3-984C-42C6-B15A-725559E75105
// Assembly location: C:\Users\deepa.gp\Desktop\dlls\Release Obfuscated-No\WpfApp1.dll

#nullable enable
namespace DataDLL;

public class Person
{
  public int Id { get; set; }

  public string Name { get; set; }

  public int Age { get; set; }

  public Person()
  {
    this.Id = 0;
    this.Name = "Test";
    this.Age = 0;
  }
}
