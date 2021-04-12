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

### 2021-03-18

닷넷 플랫폼 + 클래스 라이브러리 = 닷넷 프레임워크

파일명 : WindowsFormsEdit
메뉴를 통해서 텍스트박스에 파일 불러오고, 저장하고, 폰트설정 및 컬러 설정까지 할 수 있도록 코딩 작성

### 2021-03-19

파일명: WindowsFormGrap
그림판마냥 그릴 수 있게 만듬


### 2021-03-23

C#으로 DB다루기

1. File Select
2. Open and Read
3. Grid header generate
4. Record append
5. Input to Cell

파일명: DBManager ;; 폼의 텍스트박스에 sql문 작성하면 DB에 적용됨

```
        SqlConnection sqlCon = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();   

        string sConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=[filename];Integrated Security=True;Connect Timeout=30";

        private void mnuDBOpen_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ret = openFileDialog1.ShowDialog();
                if (ret != DialogResult.OK) return;
                string nFile = openFileDialog1.FileName; //full name
                string NFile = openFileDialog1.SafeFileName;

                
                sqlCmd.Connection = sqlCon;
                //            sqlCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KOSTA\source\repos\DBManager\testDB.mdf;Integrated Security=True;Connect Timeout=30";
                sqlCon.ConnectionString = sConn.Replace("[filename]", nFile);

                sqlCon.Open();
                sb1.Text = NFile + " Open success";
                sb1.BackColor = Color.Green;
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);
                sb1.Text = "Database Cannot Open";
                sb1.BackColor = Color.Red;
            }
            
        }

        
        int RunSql(string sql)
        {
            try
            {
                sqlCmd.CommandText = sql; 
                sqlCmd.ExecuteNonQuery(); // select문 제외 -- no return value -- update, insert, delete, create, alt
            }
            catch(SqlException e1)
            {
                MessageBox.Show(e1.Message);
            }
	    catch (InvalidOperationException e2)
            {
                MessageBox.Show(e2.Message);

            }
            return 0;
                        
        }

        private void mnuExecSql_Click(object sender, EventArgs e)
        {
            
            RunSql(textBox1.Text);
           //sqlCmd.ExecuteReader(); //select

        }

        private void mnuExecSelectSql_Click(object sender, EventArgs e)
        {
           RunSql(textBox1.SelectedText);
        }

```

### 2021-03-25

textbox로 sql문 작성하면 작동하도록, 
+ girdview 데이터를 수정하면 update 되도록,
+ gridview 의 테이블을 새 테이블로 저장하도록

update 메소드
```
       private void mnuUpdate_Click(object sender, EventArgs e)
        {
            for(int i=0; i<dataGrid.Rows.Count; i++)
            {
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    string s = dataGrid.Rows[i].Cells[j].ToolTipText;
// update [Table] set [field]=[CellText] where [1st_Col Name]=[ist_Col.CellText]
                    if (s == ".")
                    {
                        string tn = TableName;
                        string fn = dataGrid.Columns[j].HeaderText;
                        object ct = dataGrid.Rows[i].Cells[j].Value;
                        string kn = dataGrid.Columns[0].HeaderText;
                        object kt = dataGrid.Rows[i].Cells[0].Value;
                        string sql = $"update {tn} set {fn}={ct} where {kn}={kt}";
                        RunSql(sql);
                    }
                }            
            }
        }
```


### 2021-03-26

1. 프로젝트 수행 계획 수립
- 프로그램 : S/W
- H/W
- 시스템 : 환경, 네트워크, Mobile
2. 프로젝트 이름 -> 프로젝트 이름
3. 개요 : 프로젝트(프로그램) 설명 - 기능 - 효과
4. 일정, 개발자, 참고자료

### 2021-04-12

클라이언트 폼
```
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static myLib.LibSor;

namespace ChartManager
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        delegate void cbAddText(string s);
        void AddText(string str)
        {
            if(tbReceive.InvokeRequired)
            {
                cbAddText cb = new cbAddText(AddText);
                object[] oArr = { str };
                Invoke(cb, oArr);  //Invoke(cb, new object[] {str});
            }
            tbReceive.AppendText(str); //byte[]의 size만큼 변환 (null 포함)
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            int size1 = 200; //splitContainer1.Panal2 의 사이즈 ->고정 원츄

            splitContainer1.SplitterDistance = splitContainer1.Size.Width - size1;
        }

        Thread threadClient = null;
        Socket sock = null;
        private void btnConnect_Click(object sender, EventArgs e)
        {
          
           if(sock==null)
            {
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
            
            sock.Connect(tbIP.Text, int.Parse(tbPort.Text));
            sbLabel1.Text=((IPEndPoint)(sock.RemoteEndPoint)).Address.ToString(); //12.0.0.1:12345
            sbLabel2.Text = ((IPEndPoint)(sock.RemoteEndPoint)).Port.ToString(); 

            if(threadClient==null)
            {
                threadClient = new Thread(ClientProcess);
                threadClient.Start();
            }

        }

        void ClientProcess() //Thread 등록 프로세스
        {
            while(true)
            {
                int n = sock.Available;
                if(n>0)
                {
                    byte[] bArr = new byte[n]; //c#에서의 통신은 byte[] ;c/c++ char
                    sock.Receive(bArr);
                    AddText(Encoding.Default.GetString(bArr));
                }
            } 
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(sock.Connected)
            {
                string str = tbSend.Text.Trim();
                string[] sArr = str.Split('\r'); //multiline \r\n
                string sLast = sArr[sArr.Length - 1];
            
                sock.Send(Encoding.Default.GetBytes(sLast));
            }
           
        }

        iniFile ini = new iniFile(".\\ChatClient.ini");
        private void FrmClient_Load(object sender, EventArgs e)
        {
            int x1, x2, y1, y2;
            tbIP.Text = ini.GetString("Server", "IP","127.0.0.1");
            tbPort.Text = ini.GetString("Server", "Port", "9001");
            x1 = int.Parse(ini.GetString("Form", "LocationX", "0"));
            y1 = int.Parse(ini.GetString("Form", "LocationY", "0"));
            this.Location = new Point(x1, y1);
            x2 = int.Parse(ini.GetString("Form", "SizeX", "500"));
            y2 = int.Parse(ini.GetString("Form", "SizeY", "500"));
            this.Size = new Size(x2, y2);

        }

        private void FrmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            ini.SetString("Server", "IP", tbIP.Text);
            ini.SetString("Server", "Port", tbPort.Text);
            ini.SetString("Form", "LocationX", $"{Location.X}");
            ini.SetString("Form", "LocationY", $"{Location.Y}");
            ini.SetString("Form", "SizeX", $"{Size.Width}");
            ini.SetString("Form", "SizeY", $"{Size.Height}");
        }
    }
}
```

![image](https://user-images.githubusercontent.com/79901413/114365265-47bebb00-9bb5-11eb-8588-6ba09fcd30ac.png)


서버 폼
```
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
        }

        delegate void CB();
        void AddText()
        {
            if(tbReceive.InvokeRequired)
            {
                CB cb = new CB(AddText);
                Invoke(cb);
            }
            else
            {
                tbReceive.AppendText(TmpString);
            }
            
        }

        string TmpString = "";
        Thread threadServer = null;
        Thread threadRead = null;
        TcpListener listener = null;
        TcpClient tcp = null;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(listener ==null)
            {
                listener = new TcpListener(int.Parse(tbSerPort.Text));
                listener.Start();
            }
            if(threadServer==null)
            {
                threadServer = new Thread(ServerProcess);
                threadServer.Start();
                threadRead = new Thread(ReadProcess);
            }
        }

        void ServerProcess()
        {
            while(true)
            {
                if(listener.Pending() == true) //접속 요청이 있는 경우...
                {
                    tcp = listener.AcceptTcpClient(); //블로킹 모드
                    threadRead.Start();
                }
                Thread.Sleep(100);
            }
            
        }

        void ReadProcess()
        {
            if(tcp != null)
            {
                NetworkStream ns = tcp.GetStream();
                byte[] bArr = new byte[50];
                while (true)
                {
                    while (ns.DataAvailable)
                    {
                        int n = ns.Read(bArr, 0, 50);
                        TmpString = Encoding.Default.GetString(bArr, 0, n);
                        AddText();
                    }
                }
            }
        }

        private void FrmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(threadServer != null)
                threadServer.Abort();
            if (threadRead != null)
                threadRead.Abort();
        }
    }
}
```

![image](https://user-images.githubusercontent.com/79901413/114365303-54dbaa00-9bb5-11eb-81a2-c1b85be7d99f.png)


서버에서 스타트버튼 누르면 오류가 뜨는데, 
![image](https://user-images.githubusercontent.com/79901413/114365369-6329c600-9bb5-11eb-937a-7bdcaca64bb3.png)
이유를 모르겠넹,,,,
