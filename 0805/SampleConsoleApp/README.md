SampleConsoleApp - on Visual Studio Code

# commands

dotnet new sln -n SampleApp <br>
dotnet new console -n Sample.ConsoleApp <br>
dotnet sln add Sample.ConsoleApp <br>
dotnet restore . <br>
dotnet build <br>
dotnet run -p Sample.ConsoleApp <br>

cd .. <br>
dotnet new mstest -n Sample.ConsoleApp.Tests <br>
cd Sample.ConsoleApp.Tests <br>
dotnet add . package FluentAssertions
dotnet add . reference ../Sample.ConsoleApp
cd ..
dotnet sln add Sample.ConsoleApp.Tests
dotnet build . 
dotnet test 
