1. 0731 (Orientation)
Github project board
Microsoft teams — Every Wednesday at open up (offline)
— — — — — — — — — — — -
java — not standard
c# is an ECMA standard language
C# runs on Raspberry Pi
C# is good for spatial computing.
crossplatform (justin gave a presentation on running c# rasoberry pi)
what to contribute
github.com/dotnet/runtime
github.com/azure/azure-sdk-for-net
up-for-grabs : for beginners
not best but allowable : docs.microsoft.com
week first : searching process
dotnet framework — only for windows
.net core — crossplatform / mobile, game, ml.net, quantum computing
c# is used a lot in austrailia
xamarin — mobile development
~8/8
week 2
must be with test code
.net core’s build server
github action
azure devops
code review
readability, consistency — mac!
OKR
30 code PRs
30 DOC PRs
2. making .net project (0805)
https://blog.alien.org .netcore
https://github.com/devkimchi/codespaces-dotnetcore/blob/main/.devcontainer/setup.sh
코드 : devkimchi/codespaces (리눅스 환경의 visual studio code 임, 도커 컨테이너에 개발환경 구현해서 그걸 돌리는 거임)
Dockerhub -> .NET CORE SDK -> 3.1-bionic 설치(lts 임). 가벼운 거 하려면
윈도우 — blank solution — 오른쪽 마우스. c# console app (.net core)
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
=> 프로젝트 오른쪽마우스 — properties — debug — application arguments — 입력
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
// 위에 test tab — 오른쪽 누르면 테스트 실행 됨
// hardcode 값 보다
단위테스트 : 위에거 — 개발자가 할 수 있는거
통합테스트 : 개발자가 할 수 있는거
종단간 테스트 : 테스트 엔지니어, 유즈케이스적어서 쫙 함, 수동 -> 요즘 자동화
2–1. On visual studio code
Botnet sln add xxx
저장 -> Botnet build .
- c# (by microsoft)
- Josh 가 만든 c# extension 설치
dotnet run .
dotnet run -p Sample.ConsoleApp
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
