# StudyCsharp21
PKNU C# 학습 리포지토리

---------------------------------


## 개인적으로 중요한 부분 정리

#### 1. 연산자<br>
  [상세보기](https://github.com/guemin96/StudyCsharp21/tree/main/chap03/Chap03APP)<br>
<br>

#### 2. 상속
##### 상속에 관한 부분이 헷갈리는 경우
   - 형식에서 자식은 부모가 될 수 있다
   - 형식안에 있는 메소드를 사용하기 위해서는 그 형식이어야만 한다. (예시 밑에 사진) 
    
<kbd>![상속 클래스 ](https://github.com/guemin96/StudyCsharp21/blob/main/chap07(%EC%83%81%EC%86%8D)/%EC%82%AC%EC%A7%84/%EC%83%81%EC%86%8D%20%ED%98%95%EC%8B%9D%20%EB%B0%8F%20%EA%B0%92.PNG)<br></kbd>

#### 3. 인터페이스
  - C++에서 생기는 다중 상속의 문제를 해결하기 위해서 생긴 것이 인터페이스.
  - 보통 인터페이스는 이름에 I를 붙여줌
  - 인스턴스 생성 불가(참조는 가능)
  - 인터페이스끼리의 상속은 구현이라고 칭한다.
  - 인터페이스를 구현했을경우에는 무조건 사용해야한다.
  <kbd>![인터페이스 ](https://github.com/guemin96/StudyCsharp21/blob/main/chap08(%EC%9D%B8%ED%84%B0%ED%8E%98%EC%9D%B4%EC%8A%A4)/%EC%9D%B8%ED%84%B0%ED%8E%98%EC%9D%B4%EC%8A%A4.PNG)<br></kbd>

#### 4. 속성
  - private 속성을 가진 변수를 다른 클래스에서 사용하기 위해 만들어진 방법
  - get;set;을 통해 불러온다
  - get : 그 값을 불러오는 역할
  - set : 그 값을 제어하는 역할<br>
<kbd>![속성(기본식) ](https://github.com/guemin96/StudyCsharp21/blob/main/chap09/get%20set%20%EC%82%AC%EC%A7%84.PNG)<br></kbd>
  - get,set의 정석 <br>
<kbd>![속성(간단식) ](https://github.com/guemin96/StudyCsharp21/blob/main/chap09/get%20set%20%EA%B0%84%EB%8B%A8%EC%8B%9D%201.PNG)<br></kbd>
<kbd>![속성(간단식) ](https://github.com/guemin96/StudyCsharp21/blob/main/chap09/get%20set%20%EA%B0%84%EB%8B%A8%EC%8B%9D%202.PNG)<br></kbd>
  - get,set의 간단식<br>

#### 5. 해쉬테이블
  - 해쉬 테이블은 인덱스를 가지고 있는 배열이 아니라 지정해준 값을 가지고 있는 배열이기 때문에 foreach를 사용하지 못한다.
  - foreach를 사용하기 위해서는 DictionaryEntry item in ht를 써줘야한다(정렬을 하는 배열이 아니기 때문에 랜덤으로 가져오게 된다.)
  - 사이즈의 제약이 없어 원하는 만큼 넣을 수 있다.

<kbd>![해쉬 테이블 ](https://github.com/guemin96/StudyCsharp21/blob/main/chap10/HashTable.PNG)<br></kbd>

#### 6. 일반화 메소드
  - 형식만 다른 메소드를 하나로 합쳐 일반화를 시키는 메소드를 말한다
  - 데이터 형식이 사용된 부분을 T 기호로 치환
  - <>를 이용해 형식을 매개 변수로 넘겨준다.
  - 메소드 호출 시 <> 사이의 T 대신 형식의 이름을 입렵

<kbd>![일반화 메소드 ](https://github.com/guemin96/StudyCsharp21/blob/main/chap10/%EC%9D%BC%EB%B0%98%ED%99%94%20T%EB%B0%B0%EC%97%B4.PNG)<br></kbd>


#### 7. 오버플로우 (OverFlow)와 언더플로우 (Underflow)
  - 데이터가 흘러 넘쳤을 때: 데이터 형식의 최대값을 넘어가는 데이터를 저장 할 때
  - 언더플로우: 최저 값 보다 작은 데이터를 저장할 때   

``` c# 
using System;

namespace OverflowTestApp
{
    public partial class Form1_Load : Form
    {
        public Form1_Load()
        {
            InitializeComponent();
        }

        private void Form1_Load_Load(object sender, EventArgs e)
        {
                int flow = 2147483647;
                textBox1.Text = Convert.ToString(flow + 1);
        }
    }
}

```
#### 8. 연산자
  - 산술 연산자
     - +, -, *, /, %
  - 할당 연산자
    - =, +=, -=, *=, /=, %=
  - 증감 연산자
    - ++, --
  - 논리 연산자
    - && (And), || (Or), | (Not)
  - 관계/비교 연산자
    - <, >, ==, !=, >=, <=
  - 비트 연산자
    - & (And), | (Or), ^ (XOr)
  - Shift 연산자
    - , <<
    - 값을 이동시킬 수 있는 연산
  - 조건 연산자
    - ?, ??

#####<연산자 코드>
```
namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 더하기");
            var p2 = 456; // 지역 변수로 만듦 [숫자 : int]
            Console.WriteLine(123+p2); // 579 [int + int] = int
            Console.WriteLine("123" + p2); // [string + int] = string / 문자열이 하나라도 있으면 문자열 결합으로 바뀜
            Console.WriteLine($"123{p2}"); // [string] / 위와 결과값 같음 지금 방식이 훨씬 편함 (C# 6.0 이후 문자열 만드는 방법)
            Console.WriteLine("123" + "456"); //[string + string] / 123456 [문자 : string]

            // 관계연산자
            int a = 30, b = 30;
            Console.WriteLine( a > b); //false (true,false 화면 출력시, 대문자로 바뀜)
            Console.WriteLine(a < b); // false
            Console.WriteLine( a >= b ); // true
            Console.WriteLine( a<=b ); //true
            Console.WriteLine( a == b ); //true
            Console.WriteLine(a != b); //false ( ! 는 '아니다'는 의미) 

            //논리 연산자
            Console.WriteLine("논리 연산자");
            Console.WriteLine( 10 > 9 && a > 0 );//true ('&&' 는 '그리고' 의미)
            Console.WriteLine( a > b || b > 0); // true ( || 는 '또는' 의미)
            Console.WriteLine(!(a < b)); //true

            // 조건연산자 단항 if 문을 대체 가능
            int c = 30;
            string result = c == 30 ? "삼십" : "삼십아님"; // = > 조건 연산자 써볼게 

            /*string result;
            if (c == 30)
                result = "삼십";
            else
                result = "삼십아님";*/

            Console.WriteLine(result);

            //병합연산자 (NULL 조건부 연산자)

            Console.WriteLine("NULL 병합연산자");
            int? d = null;
            Console.WriteLine($"{d}");

          
            

        }
    }
}

```

6. 다형성
7. 템플릿
8. 예외 처리
9. 타입 정보
10. 네임스페이스
11. 표준 라이브러리


