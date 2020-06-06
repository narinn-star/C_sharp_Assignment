#### Assignment_7

> 2020.05.15

+ for 반복문

  for (int = 0; i < 50; i++)

  0 = 반복 시작 값 / 50 = 반복 끝 조건 / i++ = 2번째 반복부터 i값을 1씩 더하기

+ a = a+1; a = a-1; 의 여러가지 표현 방법

  "a = a+1;" **=** "a += 1;" **=** "a++;"

  "a = a-1;" **=** "a -= 1;" **=** "a--;"

**☞ 1st. for 반복문**

시작값 ~ 마지막값의 합과 곱

ulong sum01 = 0;

ulong sum02 = 1; // sum02 가 0이면 * 를 계산했을 때 무조건 0이 나오게 된다.

for (ulong i = num01; i <= num02; i++) {

sum01 = sum01 + i;

sum02 = sum02 * i;

}

**☞ 2nd. if 제어문 + for 반복문**

1 ~ 20 사이의 값 입력 -> 축적된 수 출력

if (num > 0 && num <= 20){

​	for (int i = 1; i <= num; i++) {

​	result += i + ", ";

​	}

labelX.Text = result.TrimEnd(',', ' ');

}

※Trim() : 문자열 앞, 뒤 (공백)제거 / TrimStart() : 앞 (공백)제거 / TrimEnd() : 뒤 (공백)제거

**☞ 3rd. if 제어문 + for 반복문**

양수 n 입력 후 n! 출력

double num02 = 1;

if (double.Parse(textBox.Text) >= 0){

​	for (int i = 1; i <= num; i++){

​	num02 = num02 * i;

​	}

​	labelX.Text = num02;

}

**☞ 4th. for 반복문 + Operator %**

17부터 100까지의 수를 17로 나누어 떨어지는 수 출력

for (int i = 17; i <= 100; i++){

​	if (i % 17 == 0) result += i.ToString() + ", ";

}

labelX.Text = result.TrimEnd(',', ' ');