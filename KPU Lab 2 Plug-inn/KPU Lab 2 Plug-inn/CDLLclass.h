#pragma once
class CAppUtil;

class CDLLclass
{
public:
	virtual ~CDLLclass() = default;
	virtual bool Init(CAppUtil * pUtil) = 0;
	virtual bool Run() = 0;
	virtual void TearDown() = 0;
};
