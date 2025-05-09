// Decompiled with JetBrains decompiler
// Type: WpfApp1.App
// Assembly: WpfApp1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA9405B3-984C-42C6-B15A-725559E75105
// Assembly location: C:\Users\deepa.gp\Desktop\dlls\Release Obfuscated-No\WpfApp1.dll

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

  [STAThread]
  [GeneratedCode("PresentationBuildTasks", "9.0.4.0")]
  [DebuggerNonUserCode]
  public static void Main()
  {
    App app = new App();
    app.InitializeComponent();
    app.Run();
  }
}
