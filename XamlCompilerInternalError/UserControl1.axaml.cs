using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Reflection.Metadata;
using System;

namespace XamlCompilerInternalError;

// Building with the wrong base class - Control instead of UserControl - causes the following error:
// UserControl1.axaml(1,2,1,2): Avalonia error AVLN2000: Internal compiler error: Index was out of range.Must be non-negative and less than the size of the collection.
// UserControl1.axaml(1,2,1,2): Avalonia error AVLN2000: Parameter name: index(ResolveContentPropertyTransformer) Line 1, position 2.
public partial class UserControl1 : /*User*/Control
{
    public UserControl1()
    {
        InitializeComponent();
    }
}