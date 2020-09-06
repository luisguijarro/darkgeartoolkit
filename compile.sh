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

nspaces()
{
    widthterminal=$(($(stty size | cut '-d ' -f2)))
    spcs=$(($widthterminal-44))
    spcschar=' '
    ret=''
    spcscont=0
    while [ $spcscont -lt $spcs ]
    do
        ret="${ret}${spcschar}"
        spcscont=$(($spcscont+1))
    done

    echo "${ret}";  
}

showhead()
{
    echo ''
    echo "\e[1m\e[38;2;255;128;128mDark Gear Tool Kit compiler script."
    echo "\e[38;2;128;128;255m"$barra
    espacios=$(nspaces)
    if [ "$1" = "-d" ]
    then        
        echo "\e[0mCompiling in Debug Mode. ${espacios}$(date +"%d-%m-%Y %H:%M:%S")"
    else
        echo "\e[0mCompiling in Normal Mode.${espacios}$(date +"%d-%m-%Y %H:%M:%S")"
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
    csc -nologo -unsafe -target:library -debug:full -define:DEBUG -recurse:./*.cs -out:./bin/Debug/dgtk.dll
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
