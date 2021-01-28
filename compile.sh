#!/bin/sh

clear
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

showfoot()
{
    echo ""
    echo "\e[1m\e[38;2;128;128;255m"$barra
    echo "\e[0m Compilation Finished    \e[1m\e[38;2;255;255;128mWarnings\e[0m: \e[1m\e[38;2;255;255;255m" $1 "\e[0m    \e[1m\e[38;2;255;128;128mErrors\e[0m: \e[1m\e[38;2;255;255;255m " $2 "\e[0m"
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
    war=0
    err=0
    
    csc -nologo -unsafe -target:library -debug:full -define:DEBUG -recurse:./*.cs -o:./bin/Debug/dgtk.dll | while read -r line; do    
        case $line in
        *warning*) echo ${line%%:*}":" "\e[1m\e[38;2;255;255;128mWarning\e[0m:" ${line##*:}
        war=$(($war+1))
        echo $war > war.tmp
        ;;
        *error*) echo ${line%%:*}":" "\e[1m\e[38;2;255;128;128mError\e[0m:" ${line##*:}
        err=$(($err+1))
        echo $err > err.tmp
        ;;
        esac
    done

    break
    ;;
    *)
    makedir "./bin"
    makedir "./bin/Release"
    cp dgtk.dll.config ./bin/Release/
    war=0
    err=0
    csc -nologo -unsafe -target:library -recurse:./*.cs -out:./bin/Release/dgtk.dll | while read -r line; do    
        case $line in
        *warning*) echo ${line%%:*}":" "\e[1m\e[38;2;255;255;128mWarning\e[0m:" ${line##*:}
        war=$(($war+1))
        echo $war > war.tmp
        ;;
        *error*) echo ${line%%:*}":" "\e[1m\e[38;2;255;128;128mError\e[0m:" ${line##*:}
        err=$(($err+1))
        echo $err > err.tmp
        ;;
        esac
    done
    break;
    ;;
esac

if [ -f ./war.tmp ];
then
    war=$(cat war.tmp)
    rm war.tmp
fi

if [ -f ./err.tmp ];
then
    err=$(cat err.tmp)
    rm err.tmp
fi
showfoot $war $err
