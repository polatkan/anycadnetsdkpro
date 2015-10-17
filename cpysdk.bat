
set bin=..\bin\release
xcopy %bin%\PthreadVC2.dll .\bin\release\ /y
xcopy %bin%\SamKernel.dll .\bin\release\ /y
xcopy %bin%\SamGeom.dll .\bin\release\ /y
xcopy %bin%\SamCore*.dll .\bin\release\ /y
xcopy %bin%\AnySamGeom.dll .\bin\release\ /y
xcopy %bin%\AnyCore*.dll .\bin\release\ /y
xcopy %bin%\AnyData*.dll .\bin\release\ /y
xcopy %bin%\AnyViz*.dll .\bin\release\ /y
xcopy %bin%\AnyExchange*.dll .\bin\release\ /y
xcopy %bin%\AnyPlatformAPI.dll .\bin\release\ /y
xcopy %bin%\AnyCAD.*.dll .\bin\release\ /y
xcopy %bin%\AppProConfig.xml .\bin\release\ /y

xcopy .\bin\release\*.* .\bin\debug\ /y