# OpenCV 설치
## OpenCV 설치
1. Visual Studio 실행
2. `OpenCV`라는 프로젝트 생성
3. [OpenCVSharp.2.4.10.zip](./res/OpenCVSharp_2.4.10.zip) 파일의 압축 해제하고 해당 파일들을 프로젝트 경로에 포함시켜야 함.
4. 해당 파일에 압축을 푼 파일들을 모두 복사함.
5. 프로젝트 경로를 찾아가서, `프로젝트 이름` - `프로젝트 이름` - `bin` - `Debug`에 붙여넣기 함.
6. Visual Studio 로 돌아와서 `솔루션 탐색기`에서 `참조`에서 우클릭 해서 `참조 추가`를 선택함.
7. `참조 관리자` 하단에서 `찾아보기`를 선택하고 `찾아보기` 버튼을 클릭함.
8. 프로젝트 경로에서 좀전에 붙여 넣기 한 `Debug`로 들어가 `OpenCvSharp.Blob.dll`, `OpenCvSharp.CPlusPlus.dll`, `OpenCvSharp.dll`, `OpenCvSharp.Extensions.dll`, `OpenCvSharp.UserInterface.dll` 파일을 추가하고, 체크 상태가 완료되었는지 확인하고 `확인` 버튼을 클릭함.
9. 솔루션 탐색기에서 방금 추가한 5개의 dll 파일이 정상적으로 등록되어 있는지 확인하고, 정상적으로 등록되었다면 설치가 완료된 것.

## `PictureBoxIpl` 등록하기.
1. `도구 상자`에 `All WPF Controls`에서 우클릭해서 `도구 상자 항목 선택`을 선택함.
2. `찾아보기` 버튼을 클릭한 후, 저장되어 있던 프로젝트 경로에서 `OpenCvSharp.UserInterface.dll` 파일을 클릭함.
3. `PictureBoxIpl`이 등록된 것을 확인하고, `확인` 버튼을 클릭함.
4. `도구 상자`에 `검색 도구 상자`에서 `Ipl`을 검색하자.
5. `PictureBoxIpl`이 검색이 되면 정상적으로 설치가 완료되었음.

# Image Size & FPS
### Image
- 실제 함수, 메소드 계산 시 **원본 이미지 크기 사용**
- 카메라, 동영상, 이미지 모두 동일

### FPS (Frame Per Second)
프레임(화면)이 바뀌는 속도를 초 단위로 나타내는 단위

$$ fps = {\frac{1000}{interval}} $$

- `interval`은 `Timer`에서 입력할 값.

`Timer`에 `Interval`을 `33`으로 입력할 경우 **30fps**로 영상이 출력됨.

$$ fps = {\frac{1000}{interval}} = {\frac{1000}{33}} = 30.303030... $$

**Interval이 낮을 수록 매끄러운 영상 출력**
> 컴퓨터의 성능을 고려하여 적절한 Interval을 사용.
> interval을 `1`로 할 경우, 초당 1000 프레임을 처리하기 때문에 컴퓨터의 성능이 따라가지 못해서 버벅거리게 됨.