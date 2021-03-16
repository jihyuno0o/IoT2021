// CDlgPrac.cpp: 구현 파일
//

#include "pch.h"
#include "MFCApplicationPrac.h"
#include "CDlgPrac.h"
#include "afxdialogex.h"


// CDlgPrac 대화 상자

IMPLEMENT_DYNAMIC(CDlgPrac, CDialogEx)

CDlgPrac::CDlgPrac(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_DIALOG1, pParent)
{

}

CDlgPrac::~CDlgPrac()
{
}

void CDlgPrac::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}


BEGIN_MESSAGE_MAP(CDlgPrac, CDialogEx)
	ON_BN_CLICKED(IDC_BUTTON1, &CDlgPrac::OnBnClickedButton1)
	ON_BN_CLICKED(IDC_BUTTON2, &CDlgPrac::OnBnClickedButton2)
	ON_BN_CLICKED(IDC_BUTTON3, &CDlgPrac::OnBnClickedButton3)
	ON_BN_CLICKED(IDC_BUTTON4, &CDlgPrac::OnBnClickedButton4)
END_MESSAGE_MAP()


// CDlgPrac 메시지 처리기

int btnStatus = 0;
void CDlgPrac::OnBnClickedButton1()
{
	// TODO: 여기에 컨트롤 알림 처리기 코드를 추가합니다.
	CButton* btn = (CButton*)GetDlgItem(IDC_BUTTON1);
	if (btnStatus == 0)
	{
		btn->SetWindowTextW(L"I Want");
		btnStatus = !btnStatus;
	}
	else
	{
		btn->SetWindowTextW(L"Go Home");
		btnStatus = !btnStatus;
	}
}


void CDlgPrac::OnBnClickedButton2()
{
	// TODO: 여기에 컨트롤 알림 처리기 코드를 추가합니다.
	CFileDialog df(TRUE);
	OPENFILENAME& ofn = df.GetOFN();
	ofn.Flags |= OFN_ALLOWMULTISELECT;
	if (df.DoModal() == IDCANCEL) return;
	CString fPath = df.GetPathName();
	CFile f;
	f.Open(fPath, CFile::modeRead);
	int n = f.GetLength();

	char* buf = new char[n];
	WCHAR* wBuf = new WCHAR[n];

	f.Read(buf, n);
	f.Close();
	MultiByteToWideChar(CP_ACP, 0, buf, n, wBuf, n);
	GetDlgItem(IDC_EDIT1)->SetWindowTextW(wBuf);

	delete wBuf;
	delete buf;

}


void CDlgPrac::OnBnClickedButton3()
{
	// TODO: 여기에 컨트롤 알림 처리기 코드를 추가합니다.
	EndDialog(IDC_BUTTON3);
}




void CDlgPrac::OnBnClickedButton4()
{
	// TODO: 여기에 컨트롤 알림 처리기 코드를 추가합니다.
	EndDialog(IDC_BUTTON4);
}


BOOL CDlgPrac::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// TODO:  여기에 추가 초기화 작업을 추가합니다.
	CFont f;
	f.CreateFontW(36, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, TEXT("Arial"));
	GetDlgItem(IDC_BUTTON4)->SetFont(&f,1);

	return TRUE;  // return TRUE unless you set the focus to a control
				  // 예외: OCX 속성 페이지는 FALSE를 반환해야 합니다.
}
