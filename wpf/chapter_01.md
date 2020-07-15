```xml
<Page x:Class="Hello.MainPage"
      xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
      xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
      xmlns:local="clr-namespace:Hello"
      mc:Ignorable="d" 
      d:DesignHeight="450" d:DesignWidth="800"
      Title="MainPage">

    <Grid>
        
    </Grid>
</Page>
```

### `x:Class` 속성
- XAML 파일의 루트 엘리먼트에서만 나타날 수 있음.
- `Hello 네임스페이스 하위의 MainPage 클래스는 Page 로부터 파생된 것으로 정의한다.` 라는 의미

### `xmlns`, `xmlns:x`
- 2006년은 마이크로소프트가 WPF를 선보인 해이자 XAML이 데뷔한 해.
- WPF는 닷넷 프레임워크 3.0의 일부로서 출시 이전에는 `WinFx`로 알려졌음.