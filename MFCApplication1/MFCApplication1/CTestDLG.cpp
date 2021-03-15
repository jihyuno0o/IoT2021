// CTestDLG.cpp: 구현 파일
//

#include "pch.h"
#include "MFCApplication1.h"
#include "CTestDLG.h"
#include "afxdialogex.h"


// CTestDLG 대화 상자

IMPLEMENT_DYNAMIC(CTestDLG, CDialogEx)

CTestDLG::CTestDLG(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_DLG_Test1, pParent)
{

}

CTestDLG::~CTestDLG()
{
}

void CTestDLG::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_STATIC_Text1, cStaticTest);
}


BEGIN_MESSAGE_MAP(CTestDLG, CDialogEx)
	ON_BN_CLICKED(IDC_BUTTON1, &CTestDLG::OnBnClickedButton1)
END_MESSAGE_MAP()


// CTestDLG 메시지 처리기


BOOL CTestDLG::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// TODO:  여기에 추가 초기화 작업을 추가합니다.

	CFont f;
	f.CreateFontW(36, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, TEXT("Arial"));
	//GetDlgItem(IDC_STATIC_Text1)->SetWindowTextW(L"안녕하세요. 반갑습니다.");
	//GetDlgItem(IDC_STATIC_Text1)->SetFont(&f);
	cStaticTest.SetFont(&f);
	cStaticTest.SetWindowTextW(L"안녕하세요. 반갑.");
	return TRUE;  // return TRUE unless you set the focus to a control
				  // 예외: OCX 속성 페이지는 FALSE를 반환해야 합니다.
}


void CTestDLG::OnBnClickedButton1()
{
	// TODO: 여기에 컨트롤 알림 처리기 코드를 추가합니다.
	//CEdit 
	CString buf;
	GetDlgItem(IDC_EDIT5)->GetWindowTextW(buf);
	GetDlgItem(IDC_EDIT6)->SetWindowTextW(buf.MakeUpper());
	int n = buf.GetLength();
	CString s;
	s.Format(L"%d", n);
	GetDlgItem(IDC_EDIT7)->SetWindowTextW(s);

}
