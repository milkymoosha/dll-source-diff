// Decompiled with JetBrains decompiler
// Type: WpfApp1.MainWindow
// Assembly: WpfApp1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AD6B8365-ABF7-48C4-BA1E-E8D1110A0088
// Assembly location: C:\Users\deepa.gp\Desktop\VS\2\WpfApp1_v2\WpfApp1\WpfApp1\bin\Release Obfuscated-Yes\WpfApp1.dll

using DataDLL;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

#nullable disable
namespace WpfApp1;

public partial class MainWindow : Window, IComponentConnector
{
  public static DependencyProperty MyPersonProperty = DependencyProperty.Register(nameof (MyPerson), typeof (Person), typeof (MainWindow), new PropertyMetadata());
  internal MainWindow win;
  internal Button testButton;
  internal ContentControl myContentControl;
  private bool _contentLoaded;

  public MainWindow() => this.InitializeComponent();

  public Person MyPerson
  {
    get => (Person) this.GetValue(MainWindow.MyPersonProperty);
    set => this.SetValue(MainWindow.MyPersonProperty, (object) value);
  }

  private void Window_Loaded(object sender, RoutedEventArgs e)
  {
  }

  private void testButton_Click(object sender, RoutedEventArgs e)
  {
    this.MyPerson = new Person()
    {
      Name = "GivenName Surname"
    };
    this.myContentControl.ContentTemplate = this.FindResource((object) "MyGridDataTemplate") as DataTemplate;
  }

  [GeneratedCode("PresentationBuildTasks", "9.0.4.0")]
  [DebuggerNonUserCode]
  public void InitializeComponent()
  {
    if (this._contentLoaded)
      return;
    this._contentLoaded = true;
    Application.LoadComponent((object) this, new Uri("/WpfApp1;component/mainwindow.xaml", UriKind.Relative));
  }

  [GeneratedCode("PresentationBuildTasks", "9.0.4.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  [DebuggerNonUserCode]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        this.win = (MainWindow) target;
        this.win.Loaded += new RoutedEventHandler(this.Window_Loaded);
        break;
      case 2:
        this.testButton = (Button) target;
        this.testButton.Click += new RoutedEventHandler(this.testButton_Click);
        break;
      case 3:
        this.myContentControl = (ContentControl) target;
        break;
      default:
        this._contentLoaded = true;
        break;
    }
  }
}
