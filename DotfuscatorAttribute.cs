// Decompiled with JetBrains decompiler
// Type: DotfuscatorAttribute
// Assembly: WpfApp1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA9405B3-984C-42C6-B15A-725559E75105
// Assembly location: C:\Users\deepa.gp\Desktop\dlls\Release Obfuscated-No\WpfApp1.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
[AttributeUsage(AttributeTargets.Assembly)]
[ComVisible(false)]
public sealed class DotfuscatorAttribute : Attribute
{
  private string a;
  private int c;

  public DotfuscatorAttribute(string a, int c)
  {
    DotfuscatorAttribute dotfuscatorAttribute = this;
    // ISSUE: explicit constructor call
    dotfuscatorAttribute.\u002Ector();
    dotfuscatorAttribute.a = a;
    this.c = c;
  }

  public string A => this.a;

  public string a() => this.a;

  public int C => this.c;

  public int c() => this.c;
}
