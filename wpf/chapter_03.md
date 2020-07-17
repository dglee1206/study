# 기본적인 이벤트 처리

> 이벤트는 첫 번째 객체로부터 "발생(fire, raised)" 또는 "트리거(triggered)" 되며, 다른 객체에서 "처리(handled)"된다고 주로 표현한다.
> 일반적으로 윈도우 런타임 프로그램은 초기화 이후 메모리에 상주하며 어떤 일이 발생하기를 기다린다.
> 그 후 거의 대부분이 프로그램이 하는 작업은 발생한 이벤트에 응답하는 것이다.

## Tapped 이벤트
**UIElement** 클래스는 모든 기본적인 입력 이벤트에 대해 정의하고 있다.
- **Pointer**라는 단어로 시작하는 8개의 이벤트. 이 이벤트들은 터치, 마우스, 펜 등으로부터 유입되는 입력을 통합한다.
- **Manipulation** 이라는 단어로 시작하는 5개의 이벤트. 이 이벤트들은 손가락으로부터의 입력을 조합해준다.
- **Key** 이벤트 2개는 키보드 입력을 제어한다.
- 더 높은 수준의 이벤트로 **Tapped, DoubleTapped, RightTapped, Holding**이라는 이벤트도 있다.

**UIElement** 클래스에서 유일하게 정의하는 다른 이벤트들도 마찬가지로 사용자 입력과 관련이 있다.
- **GotFocus, LostFocus** 이벤트는 엘리먼트가 키보드 입력의 대상일 때 발생함.
- **DragEnter, DragOver, DragLeave, Drop** 이벤트는 드래그 앤 드롭과 관련이 있다.

```csharp
public event TappedEventHandler Tapped;
```

```csharp
public delegate void TappedEventHandler(object sender, TappedRoutedEventArgs e);
```
- `sender` 는 이벤트가 발생한 출처.
- `e`는 Tapped 이벤트에 명시된 속성과 메서드를 제공함.