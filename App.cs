// Decompiled with JetBrains decompiler
// Type: WpfApp1.App
// Assembly: WpfApp1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AD6B8365-ABF7-48C4-BA1E-E8D1110A0088
// Assembly location: C:\Users\deepa.gp\Desktop\VS\2\WpfApp1_v2\WpfApp1\WpfApp1\bin\Release Obfuscated-Yes\WpfApp1.dll

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

#nullable disable
namespace WpfApp1;

public class App : Application
{
  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "9.0.4.0")]
  public void InitializeComponent()
  {
    this.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "9.0.4.0")]
  [STAThread]
  public static void Main()
  {
    App app = new App();
    app.InitializeComponent();
    app.Run();
  }
}
