// Decompiled with JetBrains decompiler
// Type: WpfApp1.Controls.MyGridBase`2
// Assembly: WpfApp1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA9405B3-984C-42C6-B15A-725559E75105
// Assembly location: C:\Users\deepa.gp\Desktop\dlls\Release Obfuscated-No\WpfApp1.dll

using DataDLL;
using System.Windows;
using System.Windows.Controls;

#nullable disable
namespace WpfApp1.Controls;

public abstract class MyGridBase<TRow, TCol> : Grid
{
  public static DependencyProperty PersonProperty = DependencyProperty.Register(nameof (Person), typeof (Person), typeof (MyGridBase<TRow, TCol>), new PropertyMetadata((PropertyChangedCallback) ((s, e) => ((MyGridBase<TRow, TCol>) s).DataChanged(e))));

  public MyGridBase()
  {
    this.VerticalAlignment = VerticalAlignment.Center;
    this.HorizontalAlignment = HorizontalAlignment.Center;
  }

  public Person Person
  {
    get => (Person) this.GetValue(MyGridBase<TRow, TCol>.PersonProperty);
    set => this.SetValue(MyGridBase<TRow, TCol>.PersonProperty, (object) value);
  }

  private void DataChanged(DependencyPropertyChangedEventArgs e) => this.Refresh();

  public abstract string GetText();

  private void Refresh()
  {
    this.Children.Clear();
    TextBlock element = new TextBlock();
    element.Text = this.GetText();
    element.HorizontalAlignment = HorizontalAlignment.Center;
    element.VerticalAlignment = VerticalAlignment.Center;
    this.Children.Add((UIElement) element);
  }
}
