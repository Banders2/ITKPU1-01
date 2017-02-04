#pragma once
#include "CDLLclass.h"
#include "CAppUtil.h"

class CDLLclass1 : public CDLLclass
{
	


public:
	CDLLclass1(): Tst(nullptr)
	{
	} ;
	~CDLLclass1() {  };
	bool Init(CAppUtil * pUtil) override;
	bool Run() override;
	void TearDown() override;
	CAppUtil* Tst;
};

inline bool CDLLclass1::Init(CAppUtil* pUtil)
{
	Tst = pUtil;
	return true;
}

inline bool CDLLclass1::Run()
{
	return true;
}

inline void CDLLclass1::TearDown()
{
	delete Tst;
}
