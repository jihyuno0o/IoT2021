﻿#pragma once


// CDlgPrac 대화 상자

class CDlgPrac : public CDialogEx
{
	DECLARE_DYNAMIC(CDlgPrac)

public:
	CDlgPrac(CWnd* pParent = nullptr);   // 표준 생성자입니다.
	virtual ~CDlgPrac();

// 대화 상자 데이터입니다.
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_DIALOG1 };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 지원입니다.

	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedButton1();
	afx_msg void OnBnClickedButton2();
	afx_msg void OnBnClickedButton3();
	afx_msg void OnBnClickedButton4();
	virtual BOOL OnInitDialog();
};
