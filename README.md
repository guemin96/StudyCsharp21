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
#### 9. 배열
   
   배열이란?   
   동일한 데이터 타입의 집합이다.   
   쉽게 이야기를 해보자면,   
   반복적인 코드 동작을 최대한 효율적으로 코드를 작성하기 위해 태어난 아이가 '배열'이다.
   MBTI의 ENTJ가 가장 좋아하는 구성이다.

```
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList( new[] { 80,74,81,90,34});

            var loc = array.IndexOf(81);
            array.Insert(loc, 50);

            Console.WriteLine("81위치에 50추가");
            foreach (var item in array)

            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("90 삭제");
            loc = array.IndexOf(90);

            array.RemoveAt(4);
            foreach (var item in array)

            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("정렬");
            array.Sort(); // 정렬
            foreach (var item in array)

            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
```

#### 10. 대리자와 이벤트

 ##### (1) 대리자란?
  - 콜백
    - 대신 어떤 일을 해줄 코드를 두고 실행 시점에 부여
  
  - 콜백을 구현하는 방법 = 대리자

  - 메소드에 대한 참조를 하는 대리자
    -대리자에 메소드의 주소를 할당

- 코드예제

```
namespace Chap13App
{
    delegate int MyDelegate(int a, int b); //대리자. 대신 호출한다.
    class Calculator
    {
        public int Plus (int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            MyDelegate callback;

            callback = new MyDelegate(calc.Plus);
            Console.WriteLine($"result = {callback(3,4)}");
        }
    }
}   
```

 ##### (2) 대리자 사용 이유와 시기
  - "값"이 아닌 "코드"자체를 매게변수로 넘기고 싶을 때
  - 대리자 사용 사례
    - 대리자 선언
    - 대리자가 참조할 비교메소드 작성
    - 정렬할 배열과 대리자를 매개변수로 받는 정렬 메소드 작성
    - 정렬 메소드 호출

- 코드예제2

```
namespace CallbackTestApp
{
    delegate int Compare(int a, int b); // a, b 비교 대리자.

    class Program
    {
        // 오름차순 a가 b보다 크면 1리턴, 같으면 0리턴, a < b이면 -1리턴
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1; // a, b를 바꿀것
            else if (a == b) return 0;
            else return -1;
        }

        // 내림차순 비교, a<b이면 1리턴, 같으면 0, a>b -1리턴
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1; // b와 a를 순서 바꿀것
            else if (a == b) return 0;
            else return -1;
        }

        static void BubbleSort(int[] DataSet, Compare comparer)
        {
            int temp = 0;
            for (int i = 0; i < DataSet.Length; i++)
            {
                for (int j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    // 비교하여 값 위치변경 Swap
                    if (comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 8, 4, 2, 1, 10 };

            Console.WriteLine("Sorting....");
            BubbleSort(array, new Compare(DescendCompare)); // 오름(내림)차순 정렬
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}   
```
 ##### (3) Delegate {익명 메소드}

```
namespace DelegateChainApp
{
    delegate void AllCalc(int x, int y); //대리자 선언
    class Program
    {
        static void Plus (int a, int b) { Console.WriteLine($"a + b = {a+b}"); }
        static void Minus(int a, int b) { Console.WriteLine($"a - b = {a - b}"); }
        static void Multiple(int a, int b) { Console.WriteLine($"a * b = {a * b}"); }
        static void Divide(int a, int b) { Console.WriteLine($"a / b = {a / b}"); }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating!");
            AllCalc allCalc = Plus;
            allCalc += Minus;
            allCalc += Multiple;
            allCalc += Divide;

            allCalc(10, 5);

            /*Plus(10, 5);
            Minus(10, 5);
            Multiple(10, 5);
            Divide(10, 5);*/

            Console.WriteLine("뺄셈 메서드 제거");
            allCalc -= Minus;
            allCalc(10, 5);
        }
    }
}   
```
 ##### (4) 이벤트
 
  - 이벤트 : 객체에서 일어난 사건 알리기
    - 어떤 일이 생겼을 때 알려주는 객체를 만들 때 사용
    - 이벤트 사용 절차
        - 대리자 선언
        - 선언한 대리자 인스턴스를 event 한정자로 수식
        - 이벤트 핸들러 작성
        - 클래스 인스턴스 생성 후 객체의 이벤트에 이벤트 핸들러 등록
        - 이벤트 발생 및 핸들러 호출


```
namespace UsingEventApp
{
    delegate void EventHandler(string message); //메시지 받아서 처리하는 대리자 선언 
    class CustomNotifier
    {//이벤트 선언, 사용하는 객체
        public event EventHandler SomethingHappened;

        public void Dosomething (int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappened($"{number} : 짝 !");
            }
        }
    }
    class Program
    {
        //이벤트가 발생했을 때 실행되는 메서드 (이벤트 핸들러)
        public static void MyHandler (string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용!");
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for (int i = 0; i <= 100; i++)
            {
                notifier.Dosomething(i);
            }
        }
    }
}   

```

#### 11. LINQ{from,where,orderby,select} sql과 유사

  -(1) C#언어에 통합된 데이터 질의 기능
  -(2) 내부 조인과 외부 조인
    - 각 데이터 원본 특정 필드 값을 비교해 일치하는 데이터끼리 연결
    - 내부조인 : 교집합
    - 외부조인 : 기준이 되는 데이터 원본 모두 포함

- 코드예제

```
namespace Chap15App
{
    class Profile
    {
        public string Name { get; set; }
        public short Height { get; set; }
    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 }; // 10개 배열
            // LINQ안쓰는 방식
            /*List<int> result = new List<int>();
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
            }
            result.Sort();*/
            // LINQ쓰는 방식
            var result = from item in numbers
                         where item % 2 == 0
                         orderby item
                         select item;

            foreach (var item in result)
            {
                Console.WriteLine($"짝수 : {item}");
            }

            List<Profile> profiles = new List<Profile>
            {
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 158 },
                new Profile() { Name = "고현정", Height = 172 },
                new Profile() { Name = "이문세", Height = 178 },
                new Profile() { Name = "하하", Height = 171 }
            };

            List<Product> products = new List<Product>
            { 
                new Product() { Title = "비트", Star = "정우성" },
                new Product() { Title = "CF다수", Star = "김태희" },
                new Product() { Title = "아이리스", Star = "김태희" },
                new Product() { Title = "모래시계", Star = "고현정" },
                new Product() { Title = "솔로예찬", Star = "이문세" },
            };

            var resProfiles = from item in profiles
                              where item.Height < 175
                              orderby item.Height ascending /*descending*/
                              select new
                              {
                                  Name = item.Name,
                                  Height = item.Height,
                                  InchHeight = item.Height * 0.393
                              };

            foreach (var item in resProfiles)
            {
                Console.WriteLine($"{item.Name}, {item.Height}cm, {item.InchHeight}inch");
            }

            var resProfiles2 = from item in profiles
                              where item.Height < 175
                              orderby item.Height ascending /*descending*/
                              select item.Height;

            foreach (var item in resProfiles2)
            {
                Console.WriteLine($"{item}");
            }

            // group by
            var resProfiles3 = from item in profiles
                               orderby item.Height
                               group item by item.Height < 175 into g
                               select new { 
                                   GroupKey = g.Key, Items = g
                               };

            foreach (var group in resProfiles3)
            {
                Console.WriteLine($"175cm 미만 그룹 : {group.GroupKey}");

                foreach (var item in group.Items)
                {
                    Console.WriteLine($"    {item.Name}, {item.Height}cm");
                }
            }

            // inner join
            var joinProfiles = from p in profiles
                               join d in products
                               on p.Name equals d.Star
                               select new
                               {
                                   Name = p.Name,
                                   Work = d.Title,
                                   InchHeight = p.Height * 0.393
                               };
            Console.WriteLine("내부 조인 결과!");
            foreach (var item in joinProfiles)
            {
                Console.WriteLine($"이름:{item.Name}, 작품:{item.Work}, 키:{item.InchHeight}inch");
            }

            // outer join
            var joinProfiles2 = from p in profiles
                               join d in products
                               on p.Name equals d.Star into ps
                               from d2 in ps.DefaultIfEmpty(new Product() { Title ="작품없음" })
                               select new
                               {
                                   Name = p.Name,
                                   Work = d2.Title,
                                   InchHeight = p.Height * 0.393
                               };
            Console.WriteLine("외부 조인 결과!");
            foreach (var item in joinProfiles2)
            {
                Console.WriteLine($"이름:{item.Name}, 작품:{item.Work}, 키:{item.InchHeight}inch");
            }
        }
    }
}   

```

#### 12. 스레드와 태스크

  ##### (1) 프로세스와 스레드
    
    - 프로세스
      - 실행 파일이 실행되어 메모리에 적재된 인스턴스
      - 하나 이상의 스레드로 구성
        
    - 스레드
      - 운영체제가 CPU 시간을 할당하는 기본 단위
    
    - 멀티 스레드의 장점

      - 사용자 대화형 프로그램에서 응답성을 높일 수 있음
      - 경제성 : 메모리와 자원을 할당하는 비용 절감
      - 멀티 프로세스 방식에 비해 멀티 스레드 방식 자원 공유가 쉽다
       
    - 멀티 스레드의 단점

      - 구현하기 까다랍고 테스트가 쉽지 않음
      - 과다한 사용 = 성능 저하 야기
      - 자식 스레드의 문제 발생 시 전체 프로세스에 영향을 끼침
  
  - 코드예제
  
  ```
  namespace Chap19App
{
    class Program
    {
        static void Dosomething()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10); // 1/100초 동안 멈추게함 
            }
        }
        static void SomthingHappened()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10); // 1/100초 동안 멈추게함 
            }
        }
        static void Main(string[] args)
        {
           

            Thread thread = new Thread(new ThreadStart(Dosomething));
            Thread thread1 = new Thread(SomthingHappened);

            try

            {
                Console.WriteLine("스레드 시작!");
                thread.Start();
                thread1.Start();

                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"Main thrad : {i}");
                    Thread.Sleep(10);

                    if (i == 10)
                        thread.Abort();
                }


                Console.WriteLine("스레드 종료 대기...");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            finally
            {
                thread.Join();
                thread1.Join();

                Console.WriteLine("프로세스 종료");
            }
        }
    }
}
  ```

 ##### (2) 스레드 임의 종료 시키기
 
  - Thread 객체의 Abort()메소드 사용
  - 권장하지 않음
     - 자원을 독점한 스레드가 해제 못한 상태로 Abort의 희상양이되어짐
     - 꼭 해야하는 상황이라면 도중에 강제로 중단해도 프로세스에 영향주지 않는 작업으로 진행
   
  - 코드예제
  
  ```
  namespace SideTaskApp
{
    class SideTask
    {
        int Count { get; set; }

        public SideTask(int count)
        {
            this.Count = count;
        }

        public void CountDown()
        {
            try
            {
                while (Count > 0)
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {Count} 남음");
                    Count--;
                    Thread.Sleep(10);
                }
                Console.WriteLine($"Count : {Count}"); //결과는 0 

            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine($"스레드 임의종료 예외발생 : {ex.Message}");
                Thread.ResetAbort();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"스레드 예외발생 : {ex.Message}");
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread th = new Thread(task.CountDown);
            th.IsBackground = false; // 이 스레드가 종료되기 전까지는 모든 프로세스가 끝나지 않음
            // true인 경우, 백그라운드 스레드가 돌고있는 상태에도 메인스레드가 끝나면 백그라운드 스레드도 같이 종료
            SideTask task2 = new SideTask(200);
            Thread th2 = new Thread(task2.CountDown); // 기본값 IsBackground false


            Console.WriteLine("스레드 시작!");
            th.Start();
            th2.Start();

            Thread.Sleep(1000); // 1초 슬립

            Console.WriteLine("인터럽트!");
            th2.Interrupt(); ; //인터럽트 
            Console.WriteLine("임의 종료!");
            //th.Abort();

            Console.WriteLine("종료 대기"); // 카운트다운 중간에 표시
            th.Join();
            th2.Join();

            Console.WriteLine("스레드/프로세스 종료!");
        }
    }
}   
  
  ```
  
  
 ##### (3) 태스크 (Task)
 
  - 멀티 코어 시대 고성능 소프트 웨어 개발
    - 병렬 처리 기법과 비동기 처리 기법

 - 코드예제
  
  ```
  namespace ThreadStateApp
{
    class Program
    {
        static void PrintState(ThreadState state)
        {
            Console.WriteLine($"{state, 16} : {(int) state}");
        }
        static void Main(string[] args)
        {
            PrintState(ThreadState.Running);
            
            PrintState(ThreadState.StopRequested);
            PrintState(ThreadState.Stopped);
            PrintState(ThreadState.SuspendRequested);
            PrintState(ThreadState.Suspended);
            PrintState(ThreadState.Unstarted);
            PrintState(ThreadState.WaitSleepJoin);
            PrintState(ThreadState.AbortRequested);
            PrintState(ThreadState.Aborted);
        }
    }
}
  ```

