// Decompiled with JetBrains decompiler
// Type: WpfApp1.Controls.MyGridBase`2
// Assembly: WpfApp1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AD6B8365-ABF7-48C4-BA1E-E8D1110A0088
// Assembly location: C:\Users\deepa.gp\Desktop\VS\2\WpfApp1_v2\WpfApp1\WpfApp1\bin\Release Obfuscated-Yes\WpfApp1.dll

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
