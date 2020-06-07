#### Assignment_8

> 2020.05.24

+ for 반복문

  + for (int = 0; i < 50; i++)

    0 = 반복 시작 값 / 50 = 반복 끝 조건 / i++ = 2번째 반복부터 i 값을 1씩 더하기

**☞ 1st. for 반복문**

최대값과 증가값 입력 후 합과 곱 출력

for (uint i = 1; i <= max; i = i + plus){

​	sum01 = sum01 + i;

​	sum02 = sum02 * i;

}

**☞ 2nd. if 제어문 + for 반복문 + Operator %**

1 ~ 100 사이 숫자 출력, 3의 배수는 "짝", 줄 바꾸기

if (num > 100)

else {

​	for (uint i = 1; i <= num; i++){

​		if ( i % 10 == 1 ) output += "\n";

​			if ( i % 3 == 0 ) output += " 짝 ";

​			else output += "  " + "  ";

​	}

​	labelX.Text = output;

}