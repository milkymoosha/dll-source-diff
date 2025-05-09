// Decompiled with JetBrains decompiler
// Type: WpfApp1.Controls.MyGrid
// Assembly: WpfApp1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AD6B8365-ABF7-48C4-BA1E-E8D1110A0088
// Assembly location: C:\Users\deepa.gp\Desktop\VS\2\WpfApp1_v2\WpfApp1\WpfApp1\bin\Release Obfuscated-Yes\WpfApp1.dll

#nullable disable
namespace WpfApp1.Controls;

public class MyGrid : MyGridBase<string, string>
{
  public override string GetText() => this.Person?.Name;
}
