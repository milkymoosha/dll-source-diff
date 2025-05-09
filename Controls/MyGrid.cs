// Decompiled with JetBrains decompiler
// Type: WpfApp1.Controls.MyGrid
// Assembly: WpfApp1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA9405B3-984C-42C6-B15A-725559E75105
// Assembly location: C:\Users\deepa.gp\Desktop\dlls\Release Obfuscated-No\WpfApp1.dll

#nullable disable
namespace WpfApp1.Controls;

public class MyGrid : MyGridBase<string, string>
{
  public override string GetText() => this.Person?.Name;
}
