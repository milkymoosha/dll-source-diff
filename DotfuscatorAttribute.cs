// Decompiled with JetBrains decompiler
// Type: DotfuscatorAttribute
// Assembly: WpfApp1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AD6B8365-ABF7-48C4-BA1E-E8D1110A0088
// Assembly location: C:\Users\deepa.gp\Desktop\VS\2\WpfApp1_v2\WpfApp1\WpfApp1\bin\Release Obfuscated-Yes\WpfApp1.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
[ComVisible(false)]
[AttributeUsage(AttributeTargets.Assembly)]
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
