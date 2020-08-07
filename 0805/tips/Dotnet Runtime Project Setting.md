Runtime 개발환경 설정문서 및 SDK 위치 from @rlgur41

dotnet/runtime 프로젝트 개발환경 셋팅시 어떻게 하셨는지 알 수 있을까요??
 
global.json에 기재된 sdk 까지 다운로드는 완료한 상황입니다.
기여하려는 solution을 실행해서 빌드 시도하면 다른 solution에 있는 DLL 파일 및 artifact와 충돌이 자꾸 발생하고 있습니다.  이들을 하나하나 빌드해주면 해결될 것 같긴한데 너무 많은 시간이 걸릴 것 같아 질문올립니다!

https://github.com/dotnet/runtime/blob/master/docs/workflow/README.md


global.json에 있는 sdk가 필요합니다. 

dotnet install-sdk

으로는 개발에 사용되는 sdk 다운로드가 안되어 아래 링크로 다운로드 하셔야합니다.
 
2020-08-06 master branch 기준 SDK :  https://dotnetcli.azureedge.net/dotnet/Sdk/5.0.100-preview.8.20362.3/dotnet-sdk-5.0.100-preview.8.20362.3-win-x64.exe
 
전체 설치 문서 : https://github.com/dotnet/runtime/blob/master/docs/workflow/README.md


위 문서에서 빌드하려는 프로젝트에 맞는 문서에 들어가서 셋업을 하시면 됩니다!
