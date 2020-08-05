Todo by 8/18



코딩 스킬(c#, .net core) - asp.net 으로 웹 서비스 개발(튜토리얼 참고해서 하기)배포, 디버깅, 테스트
테스트 코드 작성 방법 
오픈소스 - azure
코딩인터뷰  - 알고리즘 매일 한 문제 
포폴 작성


논문작성


학부기초&cs 기초 다시 점검 - 정보처리기사 교재
  4. 수학/통계

영어
석사과목 예습

https://blog.alien.org .netcore

https://github.com/devkimchi/codespaces-dotnetcore/blob/main/.devcontainer/setup.sh



코드 : devkimchi/codespaces (리눅스 환경의 visual studio code 임, 도커 컨테이너에 개발환경 구현해서 그걸 돌리는 거임) 

Dockerhub -> .NET CORE SDK -> 3.1-bionic 설치(lts 임). 가벼운 거 하려면 



윈도우 - blank solution - 오른쪽 마우스. c# console app (.net core) 

올해 말 arm + Mac 나오니 맥은 arm 으로 갈아타야 함 


namespace Sample.ConsoleApp

{

	public class Program

	{

		public static SampleModel Model { get; set; } = new SampleModel(); // after : 테스트 하기 좋음 // 실행될 때 정적 프로퍼티로 인식됨 



		public static void Main(string[] args)

		{

			// var model = new SampleModel(); // 문제 : dependency, 테스트 하기 어려움 

			model.Arguments = args.ToList();



			Console.WriteLine(“Hello world!” + string.Join(“:::”, model.Arguments));

		} 

	}

}



// Null 체크하는 거가 코드스멜 남



Public class SampleModel

{

	public List<string> Arguments { get; set; } = new List<string>(); 

}



=> 프로젝트 오른쪽마우스 - properties - debug - application arguments - 입력 



//테스트 ? // .net -> nunit, xunit, mstest 



Mutest

Sample : dependencies -> 레퍼런스체크 

ProblemTest.cs



[DataTestMethod]

[DataRow(“botnet”, “core”)]



[TestMethod]

Public void Given_Arguments_When_Invoked_Then_It_Should_Return_Result(params string[] args)

{

	var args = new[] { “botnet”, “core” }.ToArray();



	Program.Main(args);

	

	// Program.Model.Arguments.First().Should().Be(“botnet”); // Should() : ttd, bad

	// Program.Model.Arguments.First().Should().Be(args.First()); // // 테스트 성공

	// Program.Model.Arguments.First().Should().Be(args.Last()); // 테스트 실패 할 거임. 

	// 라이브 테스팅 가능 

}



// Should() : nuget package manager : ffluent (fluentAssertion) 추가 

// 위에 test tab - 오른쪽 누르면 테스트 실행 됨 

// hardcode 값 보다 



단위테스트 : 위에거 - 개발자가 할 수 있는거

통합테스트 : 개발자가 할 수 있는거

종단간 테스트 : 테스트 엔지니어, 유즈케이스적어서 쫙 함, 수동 -> 요즘 자동화



Botnet sln add xxx

저장 -> Botnet build .



Josh 가 만든 c# extension 설치 



Botnet run . 

Botnet run -p Sample.ConsoleApp



Test 파일 만들기 -> 



Botnet add . Reference ../Sample.ConsoleApp 



Program



[TestMethod]

Public void Given_Arguments_When_Invoked_Then_It_Should_Return_Result(params string[] args)

{

	var args = new[] { “botnet”, “core” }.ToArray();



	Program.Main(args);

	

	// Program.Model.Arguments.First().Should().Be(“botnet”); // Should() : ttd, bad

	// Program.Model.Arguments.First().Should().Be(args.First()); // // 테스트 성공

	// Program.Model.Arguments.First().Should().Be(args.Last()); // 테스트 실패 할 거임. 

	// 라이브 테스팅 가능 

}



Cd ..

Botnet build

Botnet sun add Sample.ConsoleApp.Tests

Botnet test . (테스트 돌아감) 



[codespaces]
