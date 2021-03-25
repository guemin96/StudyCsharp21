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


6. 다형성
7. 템플릿
8. 예외 처리
9. 타입 정보
10. 네임스페이스
11. 표준 라이브러리


