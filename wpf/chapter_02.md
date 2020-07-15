# XAML 문법

## 코드로 그라데이션 브러시 다루기

```xml
<Window x:Class="Hello.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Hello"
        mc:Ignorable="d"
        Title="MainWindow">
    <Grid x:Name="contentGrid">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*" />
        </Grid.ColumnDefinitions>
        <TextBlock x:Name="txtblk"
                   Grid.Column="0"
                   Text="Hello, Windows 10!"
                   FontSize="96"
                   FontWeight="Bold"
                   HorizontalAlignment="Center"
                   VerticalAlignment="Center" />
    </Grid>
</Window>
```

```csharp
using System.Windows;
using System.Windows.Media;

namespace Hello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LinearGradientBrush foregroundBrush = new LinearGradientBrush();
            foregroundBrush.StartPoint = new Point(0, 0);
            foregroundBrush.EndPoint = new Point(1, 0);

            GradientStop gradientStop = new GradientStop();
            gradientStop.Offset = 0;
            gradientStop.Color = Colors.Blue;
            foregroundBrush.GradientStops.Add(gradientStop);

            gradientStop = new GradientStop();
            gradientStop.Offset = 1;
            gradientStop.Color = Colors.Red;
            foregroundBrush.GradientStops.Add(gradientStop);

            txtblk.Foreground = foregroundBrush;

            LinearGradientBrush backgroundBrush = new LinearGradientBrush
            {
                StartPoint = new Point(0, 0),
                EndPoint = new Point(1, 0)
            };
            backgroundBrush.GradientStops.Add(new GradientStop
            {
                Offset = 0,
                Color = Colors.Red
            });
            backgroundBrush.GradientStops.Add(new GradientStop
            {
                Offset = 1,
                Color = Colors.Blue
            });

            contentGrid.Background = backgroundBrush;
        }
    }
}
```

결과
![결과](./res/20200715-2.png)


## 속성 엘리먼트 문법

**Foreground** 속성을 **SolidColorBrush** 의 인스턴스로 설정되는 것을 명시적으로 드러나게 하기.
```xml
<TextBlock Text="Hello, Windows 10!" FontSize="96">
    <TextBlock.Foreground>
        <SolidColorBrush Color="Blue" />
    </TextBlock.Foreground>
</TextBlock>
```

- **TextBlock**과 **SolidColorBrush**는 모두 "개체 엘리먼트 (Object Elements)"의 예다. 개체를 생성하는 XML 엘리먼트이기 때문이다.
- **Text**, **FontSize**, **Color**는 "속성 어트리뷰트(Property Attributes)"의 예다. 속성의 설정을 지정하는 XML 어트리뷰트이기 때문이다.
- **TextBlock.Foreground** 태그는 "속성 엘리먼트(Property Element)"이다. XML 엘리먼트로 표현하는 속성이다.