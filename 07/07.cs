using System;
					
public class Program
{
	public static void Main()
	{
		// Expression & Statement 표현식과 문
		int one = 1;
		// token몇개? 5개
		// 변수선언문
		// ;세미콜론은 문을 구분
		
		int two = 2; Console.WriteLine(two);
		int three = 1 + two;
		// "1 + two"는 표현식
		
		
		// two는 2입니다.
		Console.Write("two는 ");
		Console.Write(two);
		Console.Write("입니다");
		Console.WriteLine("줄바꿈을하는데"); //여기서 줄바꿈하고
		Console.WriteLine("끝나고 합니다");
		
		// Console.Write 은 한줄로계속씀
		// Console.WriteLine 은 한줄쓰고 줄바꿈합니다.
		
		// String interpolation 문자열보간법
		int four = 4;
		// four는 4입니다
		Console.WriteLine($"four는 {four}입니다");
		four = 444; // 이때부터 four는 444
		Console.WriteLine($"four는 {four}입니다");
		
		// null 
		// 아무것도 없다. 0도 아니고 없다!
		int? five = null;
		Console.WriteLine($"five는 {five}입니다");
		five = 55555; // 이때 값이 들어가서
		Console.WriteLine($"five는 {five}입니다");
		
		int? six = null;
		Console.WriteLine($"six는 값이 {six.HasValue}");
		six = 6;
		Console.WriteLine($"six는 값이 {six.HasValue}");
		
		// if문
		// if (condition/expression)
		// {
		// 	statement
		// }
		// else
		// {
		// 	statement
		// }
		
		int? seven = null;
		seven = 7;
		// 만약에 seven이 값이 없으면(null)이면 "seven에 값이 없습니다." 콘솔에 출력하고.
		// 만약에 seven에 값이 있으면 "seven은 {값}입니다" 라고 출력하려면?
		if (seven.HasValue)
		{
			// TRUE
			Console.WriteLine($"seven은 값이 {seven}입니다");
		}
		else
		{
			// FALSE
			Console.WriteLine("seven에 값이 없습니다.");
		}	
		
		// 기본값
		
		int? eight = null;
		eight = 888;
		int myEight = eight ?? 8;
		Console.WriteLine($"myEight은 {myEight}입니다");
		
		int? nine = null;
		nine = 888;
		int? myNine = null;
		// 값이 있으면 값을 대입하고, 값이 없으면 기본값으로 9 대입. if문으로 작성한다면?
		if (nine.HasValue)
		{
			// 값이 있으면
			myNine = nine;
			Console.WriteLine($"myNine은 {myNine}입니다");
		}
		else
		{
			// 값이 없으면
			 myNine = 9;
			Console.WriteLine($"myNine은 {myNine}입니다");
		}
		// Console.WriteLine($"myNine은 {myNine}입니다");
		// {} scope 범위
		// script, object, scene variables 선언했었죠
		
		// if문을 사용해서, myNumber가 8보다 크면, Console에 "8보다 크다!"라고 프린트하고
		// 8보다 작거나 같으면 콘솔에 8보다 작거나 같다! 라고 프린트하세요
		int myNumber = 8;
		if (myNumber > 8)
		{
			Console.WriteLine("8보다 크다!");
		}
		else
		{
			Console.WriteLine("8보다 작거나 같다!");
		}
			
		myNumber = 9;
		if (myNumber == 8)
		{
			Console.WriteLine("8이다!");
		} 
		else if (myNumber > 8)
		{
			Console.WriteLine("8보다 크다!");
		}
		else
		{
			Console.WriteLine("8보다 작다");
		}
		
		// Array 배열은 대괄호
		int[] myArray = {10, 20, 30, 40, 50, 60};
		Console.WriteLine(myArray);
		Console.WriteLine(myArray.Length);
		Console.WriteLine(myArray[0]);
		// 배열 카운트는 0부터
		
		// for-in-loop 반복문
		for (int i = 0; i < myArray.Length; i++)
		{
			Console.WriteLine($"{i}번째 숫자는");
			Console.WriteLine(myArray[i]);
			// 이 코드가 5번 실행왜? i는 0이고, 한번 반복할때마다 i++ 해서 1씩 증가.
			// 언제 끝나냐면, 5보다 작을때가지만 반복
		}
		
		for (int i = 4; i < 9; i++)
		{
			// 5번 반복하기는 하는데 좋지는 않음
			Console.WriteLine($"{i}번 반복 중");
		}
		
		for (int i = 0; i < 9; i++)
		{
			Console.WriteLine($"내가 원하는 grid의 좌표는 ({i%3}, {i/3})");
			// 내가 원하는 숫자는 0, 0, 0, 1, 1, 1, 2, 2, 2이 방식 으로 출력하고싶음
			// 내가 원하는 숫자는 0, 1, 2, 0, 1, 2, 0, 1, 2
		}
		
		for (int i = 0; i < 10; i = i + 3)
		{
			Console.WriteLine($"i는 {i}");
		}
		
		// 반복문과 if문을 사용해서
		// 1살, 2살, 3살, 4살... 20살 까지 프린트하고, 20살이 되면, 성인입니다! 라고 프린트하기
		
		for (int i = 1; i < 21; i++)
		{
			Console.WriteLine($"{i}살");
			if (i == 20)
			{
				Console.WriteLine("성인입니다!");
			}
		}
		
		// 반복문 사용해서 홀수만 프린트하고, 7일때는 "행운의 7입니다!" 라고 프린트하기
		// 1, 3, 5, 7, 행운의 7입니다!, 9
		int[] allNumber = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
		for (int i = 1; i < allNumber.Length; i = i + 2)
		{
			Console.WriteLine(allNumber[i]);
			if (i == 7)
			{
				Console.WriteLine("행운의 7입니다!");
			}
			
		}
	}
}

