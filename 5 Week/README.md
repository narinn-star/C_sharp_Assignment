#### Assignment_5

> 2020.05.02

+ switch ─ case 문

  switch (){

  ​	case __ : ____ ;

  ​			break ;

  ​	default :  ;

  ​			break ;

  }

##### ☞ 1st. switch ─ case 문 

1 ~ 5 사이의 숫자 영문으로 출력하기

default : 알수없는 수

※ break 주의

##### ☞ 2nd. switch ─ case 문 + if 문

if (char.Parse(str) >= 'a' && char.Parse(str) <= 'z'){

​	switch (char.Parse(str))

​		case 'a' ~ case 'u' :  ____ ;

​			break ;

​		default : consonant ;

​			break;

}

모음 (a, e, i, o, u) --> "vowel"  //  자음 (나머지) --> "consonant"

※ 자료형 string : 문자열 "abc"

​	자료형 char : 문자 'a', 'b', 'c'

##### ☞ 3rd. switch ─ case 문 

자료형의 허용값 확인

switch (str){

​	case "int" : 

​			int iData01 = int.MaxValue ;

​			int iData01 = int.MinValue ;

​			break ; 

​	……

}

※ MaxValue : 최댓값 // MinValue : 최솟값

##### ☞ 4th. switch ─ case 문 + if 문

Month 출력하기

if (month >= 1 && month <= 12){

​	switch (month){

​		case 1 : January ; 

​			break ;

​		……

​	}

}