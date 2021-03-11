# IoT2021-kosta

### 2021-03-11

c를 사용한 피아노 치기!? 
```
#include <stdio.h>
#include <conio.h>

int main()
{
	char *point="..........";
	char vBar='|';
	
	while(1)
	{	
		int getKey=getch()-48; // 0=30h -아스키코드
		if(getKey<0 || getKey>9) break;
		for(int i=0; i<10; i++)
		{
			if(i==getKey)
				printf("%c",vBar);
			else
				printf("%c",*(point+i));
		}
		printf("\r");
	}
}
```

## C++ 시작

생성자는 클래스 이름이랑 같게 해야함, public 안에 선언해야함

함수 오버로딩 ; 매개변수가 다를 때 함수 오버로딩 성립 / 변환형의 차이는 안됨

namespace가 다르면 함수 이름이 같아도 쓸 수 있음; 프로젝트명으로 많이 사용함스



