#!/bin/sh

widthterminal=$(($(stty size | cut '-d ' -f2)))
barrachar='='
barra=''
cont=0
while [ $cont -lt $widthterminal ]
do
    barra=$barra$barrachar
    cont=$(($cont+1))
done

makedir()
{
    if [ ! -d $1 ]
    then
        mkdir $1
    fi
}

showhead()
{
    echo ''
    echo "\e[1m\e[38;2;255;128;128mDark Gear Tool Kit compiler script."
    echo "\e[38;2;128;128;255m"$barra
    if [ "$1" = "-d" ]
    then
        echo "\e[0mCompiling in Debug Mode."
    else
        echo "\e[0mCompiling in Normal Mode."
    fi

    echo "\e[1m\e[38;2;128;128;255m"$barra"\e[0m"
}

showhead $1

case "$1" in
    -h)
    echo ""
    echo "\e[1m\e[38;2;255;128;128mDark Gear Tool Kit compiler script."
    echo "\e[38;2;128;128;255m"$barra
    echo "\e[0muse -d argument for compile with debug"
    echo "\e[0muse -h Show this Help."
    return 0;
    break
    ;;
    -d)
    makedir "./bin"
    makedir "./bin/Debug"
    cp dgtk.dll.config ./bin/Debug/
    csc -nologo -unsafe -target:library -debug:full -recurse:./*.cs -out:./bin/Debug/dgtk.dll
    break
    ;;
    *)
    makedir "./bin"
    makedir "./bin/Release"
    cp dgtk.dll.config ./bin/Release/
    csc -nologo -unsafe -target:library -recurse:./*.cs -out:./bin/Release/dgtk.dll
    break;
    ;;
esac
