using System;
// using Unity;
// 유니티에서는 이렇게 사용
// 오늘부터 즐거운 코딩시간~

public class Program
{
	// 여기는 프로그램
// tab 싫은데?
	public static void Main()
	{
		// 여기부터는 Main
		
		// 자연어(한국말, 영어, 일본어, 등등 사람이 쓰는 말)
		// 프로그래밍언어(컴퓨터가 작동하기위해 쓰는 말)
		// LLM Large Language Model GPT
		// 자연어를 너무 잘 알아들음
		// 바이브 코딩?
		
		// Token 토큰
		// 프로그래밍 언어에서 가장 작은 단위
		int one = 1;
		// 토큰은 5개
		// 왜? =은 ~는 이라고 해석할수있죠
		// -. -로 나눠버리면 다른 의미
		// 토큰은 공백으로 구분
		// 토큰이 모여 표현식이되고 여러개가 모이고 모여 프로그램이 완성
		// 표현식이 끝나는것은 ;
		
		// Literal 리터럴
		// Integer, Float, Boolean, String, Character
		int two = 2;
		// 여기서 2는 integer literal
		double pointOne = 0.1; // 여기서는 0.1
		bool isStudent = false; // 여기서는 false
		string name = "Gwangyu"; // 여기서는 "Gwangyu"
		char initial = 'G'; // 여기서는 'G'
		
		// Quiz
		string familyNameInitial = "L";
		// L은 string literal
		// char는 무조건 한글자, string은 하나도 괜찮고, 100개도 괜찮음
		
		bool isCube1Hit = false;
		
		// Keyword 키워드
		// 미리 사용하려고 예약되어있는 문자
		int three = 3;
		// 3은 integer literal
		// int는 키워드, 정수를 선언할껀데...
		double pointTwo = 0.2;
		// double은 키워드, 소수를 선언할껀데...
		
		// Identifier 식별자
		// 변수 이름
		int four = 4;
		// ❌ int int = 4;
		// keyword는 identifier로 사용할 수 없음
		
		// ❌ int 4 = 4;
		// identifier는 숫자로 시작할 수 없음
		int myNumber4 = 4;
		// 숫자 포함은 가능
		
		// ❌ int 2*2 = 4;
		// 특수문자는 포함 불가능. 근데 _는 가능
		int _five = 5;
		int five = 5;
		int my_number_is_five = 5;
		// 추천 안함. 왜? Camel Case가 더 편함
		
		int oneMillion = 1_000_000;
		// Integer 또는 Float Literal도 _으로 표시 가능
		string anotherOneMillion = "1,000,000";
		
		Console.WriteLine(oneMillion);
		// Debug.Console은 유니티~
		
		// Camel Case
		// lower upper
		// 공백으로 토큰을 구분
		// my number 라는 변수 이름
		// mynumber 읽기 힘듭니다
		// myNumberIsFour
		// mynumberisfour
		// 소문자로 시작하면 lower
		// 대문자로 시작하면 upper
		// 변수같은건 lower
		// class 같은건 upper
		
		// Operator 연산자
		// 연산
		
		// Arithmetic Operator 산술 연산자
		// +, -, *, / 등등
		
		double pi = 3.14;
		double twoPi = pi * 2;
		Console.WriteLine(twoPi);
		
		double six = 6;
		double myNumber = six / 5;
		Console.WriteLine(myNumber);
		// 1.2
		
		// Assignment Operator 대입 연산자
		int seven = 7;
		// 여기서 대입 연산자는 =
		// 어디에 어떤걸 대입해라(집어넣어라)
		// int는 키워드, seven은 식별자. =는 대입연산자, 7은 정수 리터럴
		// seven이라는 정수 타입의 변수를 선언했고, 이 변수 안에 7을 대입!
		Console.WriteLine(seven); // 아직 7
		seven = 777; // 이제 777
		// seven이라는 변수에 777을 대입!
		Console.WriteLine(seven);
		
		// Constant 상수
		const int eight = 8;
		// ❌ eight = 888;
		// 왜? 상수로 선언했기때문에
		
		// Relational Operator 관계 연산자
		// >, <, >=, =<. ==. !=
		
		// Quiz
		// eight > 5
		bool true1 = eight > 5;
		Console.WriteLine(true1);
		
		bool true2 = eight == 8;
		// == 같냐?
		Console.WriteLine(true2);
		// 같다 true
		
		bool true3 = eight != 9;
		// != 다르냐?
		Console.WriteLine(true3);
		// 그래 다르다 true
		
		// 왜 세미콜론이지?
		// 토큰과 토큰은 공백으로 구분한다!
		
		// using System;
		// string greeting = "Hello, world";
		// Console.WriteLine(greeting);
		
		// c계열 언어, c, c#, c++, objective-c, 계열은 옛날꺼
		// c 빠르게 구동
		
		// swift, python, java
		// java 엄청 느림 웹개발 웹디자인
		
		// Scope 범위
		// { }
		// tab으로 들여쓰기
		
		// Logical Operator 논리 연산자
		// AND, OR
		// &&, ||
		
		bool myLogic1 = (10 > 5) && (20 > 10);
		// (10 > 5) TRUE
		// (20 > 10) TRUE
		Console.WriteLine(myLogic1);
		
		bool myLogic2 = (10 > 15) || (20 > 10);
		// (10 > 15) FALSE
		// (20 > 10) TRUE
		Console.WriteLine(myLogic2);
		
		// Bitwise Operator 비트연산자
		byte bitOne = 0b0000_0001;
		byte bitTwo = 0b0000_0010;
		byte bitThree = 0b0000_0011;
		Console.WriteLine(bitThree);
		
		// &, |
		int myBit1 = bitOne & bitTwo;
		//   bitOne 0000_0001
		// & bitTwo 0000_0010
		// result:  0000_0000
		Console.WriteLine(myBit1); // 0
		
		int myBit2 = bitOne | bitTwo;
		//   bitOne 0000_0001
		// I bitTwo 0000_0010
		// result:  0000_0011
		Console.WriteLine(myBit2); // 3
		
		// 정수와 소수
		// 예
		// 앞에 0000은 정수표현 뒤에 0000은 소수점뒤에표현
		
		double myDouble1 = 0.1; // 0.1000000000001
		Console.WriteLine(myDouble1);
		double myDouble2 = 0.2; // 0.2000000000001
		Console.WriteLine(myDouble2);
		double myDouble3 = 0.3; // 0.3000000000001
		Console.WriteLine(myDouble3);
		Console.WriteLine(myDouble1 + myDouble2); // 0.30000000000000004
		bool compare = myDouble3 == 0.3;
		// bool compare = myDouble3 == (myDouble1 + myDouble2);
		// FALSE
		Console.WriteLine(compare);
		// 산술연산? 문제없음
		// 문제는 산술연산 후 관계연산
	}
}









