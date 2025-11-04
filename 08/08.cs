using System;

// 콜렉션을 쓸거다 라이브러리 가져오기
using System.Collections.Generic;
					
public class Program
{
	
	// 클라스 퀴즈
	// 번호, 쳤는지 안쳤는지 멤버로 입력하고
	// Swing()이라는 메소드를 실행해서
	// 쳤으면 "00번 선수 안타"
	// 못쳤으면 "00번 선수 헛스윙"
	// 이렇게 프린트하는 클라스 만들기
	
	// 한사람 코드 복붙해주세요~
	class Player
	{
		public int number;
		public bool isHit;
		public void Swing()
		{
			if (isHit)
			{
				Console.WriteLine($"{number}번 선수 안타");
			}
			else
			{
				Console.WriteLine($"{number}번 선수 헛스윙");
			}
		}
	}
	
	class Car
	{
		// 멤버 프로퍼티
		public string name;
		public int speed;
		
		// method 메소드
		public void Name()
		{
			Console.WriteLine($"이름은 {name}입니다");
		}
		public void Drive()
		{
			Console.WriteLine($"{speed} 속도로 운전 중");
		}
	}
	
	public static void Main()
	{
		
		// 오늘의 목표
		// 리스트, 딕셔너리, while. switch, 함수, 클라스,
		// 콘솔로 소통하기
		
		// Collection 콜렉션 타입
		// List 리스트
		
		// evaluate 코드 런하라는 소리
		
		List<int> scores = new List<int> {70, 80, 90};
		Console.WriteLine($"{scores.Count}개");
		Console.WriteLine($"첫번째 점수는? {scores[0]}점");
		
		// boolean is뭐뭐뭐
		// camelCase
		// 콜렉션타입, 배열, 리스트, 딕셔너리. 복수 score가 아니라 scores
		
		scores.Add(11); // 리스트 마지막에 추가한다
		Console.WriteLine($"이제 {scores.Count}개"); // 4개
		Console.WriteLine($"마지막 점수는? {scores[ scores.Count-1 ]}점");
		
		// List String
		List<string> names = new List<string> {"lee", "kim"}; // 2개
		names.Add("park");
		Console.WriteLine(names.Count); // 3개
		Console.WriteLine(names[2]); // park
		
		names.Insert(1, "shin");
		Console.WriteLine(names.Count); // 4개
		Console.WriteLine(names[1]); // shin
		Console.WriteLine(names[2]); // kim
		
		names.Remove("lee");
		Console.WriteLine(names.Count); // 3개
		// shin, kim, park
		Console.WriteLine(names[0]);
		Console.WriteLine(names[1]);
		Console.WriteLine(names[2]);
		
		names.RemoveAt(0);
		Console.WriteLine(names[0]); // kim
		Console.WriteLine(names[1]); // park
		
		for (int i = 0; i < names.Count; i++)
		{
			// 1. kim
			// 2. park
			Console.WriteLine($"{i+1}. {names[i]}");
		}
		
		// Dictionary
		// name 이름
		// 쌍으로. key, value
		
		Dictionary<string, int> ages = new Dictionary<string, int>();
		ages["lee"] = 10;
		ages["kim"] = 13;
		// lee, kim은 key
		// 10, 13은 value
		
		if (ages.ContainsKey("lee"))
		{
			Console.WriteLine($"lee는 {ages["lee"]}살");
		}
		else
		{
			Console.WriteLine("이름이 없습니다");
		}
		
		// 반복문 필수요소 3가지.
		// 변수, 조건, 조건을 맞추는 코드
		// while
		int count = 0;
		while (count < 3)
		{
			count++;
			Console.WriteLine($"{count}. 반복 중");
			// count++;
		}
		
		// Switch
		
		// 요일을 입력하세요 mon
		Console.Write("요일을 입력하세요 ");
		string day = Console.ReadLine(); // 콘솔에 타이핑
		
		// 만약에, day가 mon 이면, 월요일! 프린트하고,
		// 만약에, day가 tue 이면, 화요일! 프린트하고,
		// mon, tue을 제외한 다른 값이 들어오면, 요일이 없습니다! 라고 프린트하기
		
		if (day == "mon")
		{
			Console.WriteLine("if: 월요일!");
		}
		else if (day == "tue")
		{
			Console.WriteLine("if: 화요일!");
		}
		else
		{
			Console.WriteLine("if: 요일이 없습니다!");
		}
		
		switch (day)
		{
			case "mon":
				Console.WriteLine("switch: 월요일!");
				break;
			case "tue":
				Console.WriteLine("switch: 화요일!");
				goto case "red";
			case "red":
				Console.WriteLine("switch: 빨간날!");
				break;
			default:
				Console.WriteLine("switch: 요일이 없습니다!");
				break;
		}
		
		// function 함수!
		static int AddIntegers(int a, int b)
		{
			Console.WriteLine("더하기 함수 실행!");
			return a + b;
		}
		// int a, int b는 parameter
		int result = AddIntegers(3, 5);
		Console.WriteLine(result);
		
		// 콘솔에 숫자를 입력하면 제곱을 해주는 계산기 만들기.
		// 계속 실행되고, 종료키가 있어서 이 키를 누르면 종료
		// 무한루프? break;
		
		static int SquareInteger(int a)
		{
			return a * a;
		}
		
		while (true)
		{
			Console.Write("숫자를 입력하세요. 종료키는 q 입니다. ");
			string input = Console.ReadLine();
			if (input == "q")
			{
				Console.WriteLine("종료~");
				break; // while 루프 탈출
			}
			int myResult = SquareInteger( int.Parse(input) );
			Console.WriteLine($"결과는 {myResult}");
		}
		
		// Class 클라스
		
		Car myCar = new Car();
		// 지금부터 myCar는 Car Class를 사용하는것	
		// 닷문법 안에 접근할때
		myCar.name = "induk";
		myCar.speed = 100;	
		myCar.Name();
		myCar.Drive();
		
		Car gwangyuCar = new Car();
		gwangyuCar.name = "gwangyu";
		gwangyuCar.speed = 120;
		gwangyuCar.Name();
		gwangyuCar.Drive();
		
		// 클라스 퀴즈
		// 번호, 쳤는지 안쳤는지 멤버로 입력하고
		// Swing()이라는 메소드를 실행해서
		// 쳤으면 "00번 선수 안타"
		// 못쳤으면 "00번 선수 헛스윙"
		// 이렇게 프린트하는 클라스 만들기
		
		Player induk = new Player();
		induk.number = 7;
		induk.isHit = true;
		induk.Swing();
	}
}
