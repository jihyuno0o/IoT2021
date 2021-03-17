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


### 2021-03-12

클래스 사용해서 점, 사각형, 원 메소드 구현하기

```
# include <iostream>

class Point //기본적으로 private: 외부참조불가
{
private:

public:	//외부참조가능
	int x, y;
	Point(int a, int b) : x(a), y(b) {}
	Point() {} //null 생성자
	int GetX() { return x; }
	int GetY() { return y; }
	void SetX(int a) { x = a; }
	void SetY(int a) { y = a; }

	Point operator+(int n)
	{
		Point p1;
		p1.x = x + n; p1.y = y + n;
		return p1;
	}

	Point operator+(Point p)
	{
		Point p1;
		p1.x = x + p.x; p1.y = y + p.y;
		return p1;
	}
};

class Rect
{
private:
	Point p1, p2;
public:
	Rect(Point pp1, Point pp2) : p1(pp1), p2(pp2)
	{
		//		p1 = pp1; p2 = pp2; //class 변수의 대입문
	}
	Rect() :p1(0, 0), p2(0, 0) {}
	void SetP1(Point p) { p1 = p; }
	void SetP2(Point p) { p2 = p; }

	int GetX1() { return p1.x; }
	int GetY1() { return p1.y; }
	int GetX() { return abs(p1.x - p2.x); }
	int GetY() { return abs(p1.y - p2.y); }

	int area()
	{
		int x = p1.x - p2.x;
		int y = p1.y - p2.y;
		return abs(x * y);
	}


};

class RectEx :public Rect // Rect class를 상속
{
	int a;
public:
	RectEx(Point pp1, Point pp2) :Rect(pp1, pp2)
	{
		//SetP1(pp1); SetP2(pp2);
	}
	double Distance()
	{
		int x = GetX();
		int y = GetY();
		return sqrt(x * x + y * y);
	}
};

class Circle :public Rect
{
private:
	Point cp;
	double r;
public:
	Circle(Point pp1, Point pp2) : Rect(pp1, pp2), cp(0, 0), r(0)
	{
		cp.SetX((pp1.x + pp2.x) / 2);
		cp.SetY((pp1.y + pp2.y) / 2);
		int x = GetX();
		int y = GetY();
		r = sqrt(x * x + y * y) / 2;
	}


	double diameter()
	{
		return 2 * r;
	}
	double CLen()
	{
		return 2 * 3.14 * r;
	}
	double area()
	{
		return 3.14 * r * r;
	}




};

int func1(Rect* r);
int func2(Rect& r);
int func3(Circle& c);

int main()
{
	Point p1(10, 10), p2(20, 20);
	Rect r1(p1, p2);
	//	Rect r1 = { {10,10},{20,20} }; //struct type 초기화

	func1(&r1); //포인터 변수 전달을 위해 변수(클래스)의 주소 전달
	func2(r1); //레퍼런스 타입은 그냥 변수명 전달

	printf("main 면적 %d\n", r1.area());

	Circle circle(p1, p2);
	func3(circle);

	printf("지름: %.3f, 둘레: %.3f, 면적: %.3f  \n", circle.diameter(), circle.CLen(), circle.area());

	p1.SetX(15); p1.SetY(15);
	Point p3 = p1 + 10;
	Point p4 = p1 + p2;
	printf("Point 클래스의 연산자 오버로딩 테스트 (+) : p1(%d,%d) + %d --> (%d, %d)\n",
		p1.x, p1.y, 10, p3.x, p3.y);
	printf("Point 클래스의 연산자 오버로딩 테스트 (+) : p1(%d,%d) + p2(%d,%d) --> (%d, %d)\n",
		p1.x, p1.y, p2.x, p2.y, p4.x, p4.y);

}

int func1(Rect* r1)
{
	printf("면적 %d\n", r1->area());

	return 0;
}
int func2(Rect& r1)
{
	printf("면적 %d\n", r1.area());
	return 0;
}
int func3(Circle& c1)
{
	printf("면적 %f\n", c1.area());
	printf("지름 %f\n", c1.diameter());
	printf("둘레 %f\n", c1.CLen());
	return 0;
}
```

생성자(constructor)도 함수라서 오버로드, 디폴트 값 설정 가능

레퍼런스 타입, 연산자 오버로딩 사용하는 법 익히기

get, set 선언 바로바로 하기 


### 2021-03-15

MFC(Microsoft Foundation Class)

SDK(Software Development Kit) ; library 개념

```void CTestDLG::OnBnClickedButton1()
{
	// TODO: 여기에 컨트롤 알림 처리기 코드를 추가합니다.
	//CEdit 
	CString buf;
	//GetDlgItem(IDC_EDIT5)->GetWindowTextW(buf);
	cEditInput.GetWindowTextW(buf);
	//GetDlgItem(IDC_EDIT6)->SetWindowTextW(buf.MakeUpper());
	cEditUpper.SetWindowTextW(buf.MakeUpper());
	int n = buf.GetLength();
	CString s;
	s.Format(L"%d", n);
	//GetDlgItem(IDC_EDIT7)->SetWindowTextW(s);
	cEditLen.SetWindowTextW(s);

}
```
포인터와 로컬변수 둘다 같은데 흠,, 글쿤,,

### 2021-03-17

## C# 시작

static 메소드랑 instance 메소드랑 차이점은

static으로 선언된 메소드는 클래스에 소속된? 그런거라서 
메인함수에서 불러올 때 클래스명.메소드(); 이렇게 쓸 수 있고
인스턴스 메소드는 선언해줘야한다 Instance ins = new Instance();
이렇게 하고 ins.메소드(); 로 사용한다.

프로그램 전체에 걸쳐서 공유해야하는 경우에 보통 static 이용
또는, 인스턴스 생성하지 않고 메소드를 바로 사용하고 싶을 때 static 이용







