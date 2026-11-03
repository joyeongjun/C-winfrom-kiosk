# 코드 구성과 동작 설명

## 시작 지점

[`Program.cs`](../src/pro/Program.cs)는 WinForms 환경을 초기화하고 `Form9`를 시작합니다.

```csharp
ApplicationConfiguration.Initialize();
Application.Run(new Form9());
```

프로젝트 이름은 `pro`, 시작 코드의 네임스페이스는 `pro`, 화면 클래스의 네임스페이스는 `WinFormsApp1`입니다. 원본 구조를 유지했습니다.

## 화면별 역할

| 파일 | 핵심 역할 | 이동 / 처리 |
| --- | --- | --- |
| [Form9.cs](../src/pro/Form9.cs) | 원투·루어·찌 낚시 선택 | 세 버튼 모두 Form10 열기 |
| [Form10.cs](../src/pro/Form10.cs) | 안내 메뉴 | Form11 또는 Edge 실행 |
| [Form11.cs](../src/pro/Form11.cs) | 용품 카테고리 선택 | Form12 / Form13 / Form14 열기 |
| [Form12.cs](../src/pro/Form12.cs) | 낚시대 주문 | 체크 상태, 합계, 주문 메시지 |
| [Form13.cs](../src/pro/Form13.cs) | 채비 주문 | 체크 상태, 합계, 주문 메시지 |
| [Form14.cs](../src/pro/Form14.cs) | 미끼 주문 | 체크 상태, 합계, 주문 메시지 |

각 화면은 `.cs`의 이벤트 처리 코드, `.Designer.cs`의 컨트롤 생성·배치, `.resx`의 이미지 리소스로 구성됩니다.

## 크기와 위치를 유지하는 화면 전환

`Form9`에서 `Form10`을 여는 실제 코드입니다.

```csharp
Form10 form10 = new Form10();
form10.Size = this.Size;
form10.StartPosition = FormStartPosition.Manual;
form10.Location = this.Location;
form10.ShowDialog();
```

`ShowDialog()`는 하위 화면이 닫힐 때까지 상위 화면의 입력을 막습니다. 뒤로가기에서는 `Close()`로 현재 화면을 닫습니다. 주문 화면을 새로 열면 새 Form 인스턴스가 생성되므로 이전 선택과 합계가 유지되지 않습니다.

## 선택 상태에 따른 합계 계산

각 주문 화면은 `public long totalPrice = 0;`으로 합계를 관리합니다. 다음은 `Form12`의 첫 상품 처리입니다.

```csharp
int one = int.Parse(labone.Text);
if (checkBox1.Checked)
{
    totalPrice += one;
}
else
    totalPrice -= one;
```

- `CheckedChanged` 이벤트에서 체크하면 더하고, 해제하면 뺍니다.
- 화면상의 가격 Label은 쉼표 없는 숫자 문자열이어야 합니다.
- 구매 버튼에서 `textBox1.Text = totalPrice.ToString();`으로 합계를 표시합니다.
- 분류별 합계는 독립적이며, 상품당 수량은 체크 여부로만 표현됩니다.

## 결제 방식과 주문 결과

`comboBox1_SelectedIndexChanged`는 결제 수단이 선택되면 ListBox를 비우고 `일시불`, `3개월`, `6개월`을 추가합니다.

구매 버튼은 선택된 체크박스의 텍스트를 연결해 `lblOrder`에 표시하고, `MessageBox.Show()`로 결제 방식과 금액을 안내합니다. `{totalPrice:N0}` 서식으로 금액에 천 단위 구분 기호를 적용합니다.

실제 결제 승인 요청, 카드 정보 입력, 서버 통신, DB 저장은 구현되어 있지 않습니다. 초보자용·중급자용 또는 채비 1·2처럼 여러 열에서 같은 체크박스 문구를 사용하므로 주문 결과의 텍스트만으로 상품 종류를 구별하기 어려운 부분도 있습니다.

## 외부 링크

`Form10`은 아래 Edge 실행 파일 경로를 사용합니다.

```text
C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe
```

실행할 사이트를 `ProcessStartInfo.Arguments`에 지정한 뒤 `Process.Start()`를 호출합니다. 이 위치에 Edge가 없으면 링크 실행이 실패할 수 있습니다. 네이버 지도 링크 세 개는 각각 고정된 장소이며 낚시 유형에 따라 자동으로 달라지지 않습니다.

## 공개용 정리 내역

- 소스 솔루션을 `src/pro.sln`, 프로젝트를 `src/pro/`에 배치했습니다.
- 원본 C#·Designer·RESX·프로젝트·솔루션 파일의 내용은 변경하지 않았습니다.
- 이미지가 RESX 안에 포함되어 있어 별도 상품 이미지 폴더가 없어도 빌드할 수 있습니다.
- `.vs`, `bin`, `obj`, `*.user`, ZIP 등 개발 환경 및 중복 산출물을 제외했습니다.
- 제공된 녹화에서 화면 이미지를 추출하고, 무음 MP4 및 GIF 미리보기를 만들었습니다.
- README는 코드와 제공된 녹화에서 확인한 기능을 기준으로 작성했습니다.

## 빌드 검증 기록

검증일: 2026-11-03

```powershell
dotnet build src/pro.sln --configuration Release --nologo
```

| 항목 | 결과 |
| --- | --- |
| 운영체제 | Windows |
| 사용 SDK | .NET SDK 10.0.301 |
| 대상 | net6.0-windows |
| 결과 | 빌드 성공, 오류 0개, 경고 5개 |
| NETSDK1138 | 지원이 종료된 .NET 6 타깃 경고 2건 |
| CS0414 | Form12·Form13·Form14의 사용하지 않는 `strOrder` 필드 경고 3건 |

빌드 통과는 화면 상호작용이나 외부 사이트의 정상 동작을 모두 보장하지 않습니다. 화면 예시는 제공된 시연 영상 기준입니다.

## 후속 개선 후보

1. `string.IsNullOrWhiteSpace`, 선택 인덱스, 주문 항목 수를 사용한 구매 입력 검증.
2. `Product` / `CartItem` 모델을 도입한 가격·수량·상품명 관리와 공통 장바구니.
3. 주문 결과에 유형·등급을 함께 표시해 상품 구분 개선.
4. 기본 브라우저로 링크 열기와 예외 처리.
5. 주문 이력 저장 및 실제 결제 연동을 별도 서비스로 분리.
6. 지원되는 .NET 버전으로 이전하고 Designer와 리소스 호환성 재검증.
