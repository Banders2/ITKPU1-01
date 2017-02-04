#pragma once
#include <string>
#include "CAppUtil.h"

class CAppUtillmp : public CAppUtil
{
	std::string Name;
public:
	CAppUtillmp(void) { Name = "Anders"; };
	CAppUtillmp(std::string str1) { Name = str1; };
	std::string GetName() override;
	std::string MyAddString(std::string str1, std::string str2) override;
};


inline std::string CAppUtillmp::GetName()
{
	return Name;
}

inline std::string CAppUtillmp::MyAddString(std::string str1, std::string str2)
{
	return str1 + str2;
}
