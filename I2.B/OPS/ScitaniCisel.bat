@echo off
cls

set /p prvni=Prvni cislo: 
set /p druhe=Druhe cislo: 
set /a "v=%prvni% + %druhe%"

echo %v%

pause
