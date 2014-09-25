@echo off
:zacatek
echo Tvuj ukol je uhodnout cislo od 1 az 9
set /a s1=%RANDOM% * 9 / 32768 + 1
set /p s2=Zadejte cislo: 
echo Vase cislo je: %s2%
if %s1% EQU %s2% (echo Spravne!) else (echo Spatne! %s1%)
echo.
set /p q=Chcete opakovat? [a/n]: 
if %q% == a (goto zacatek) else (echo Bye Bye)
echo.
