// KPU Lab 1 DLL.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <cstring>
#include "KPU Lab 1 DLL.h"


// This is an example of an exported variable
KPULAB1DLL_API int nKPULab1DLL=0;

// This is an example of an exported function.
KPULAB1DLL_API int fnKPULab1DLL(void)
{
    return 42;
}

// This is the constructor of a class that has been exported.
// see KPU Lab 1 DLL.h for the class definition
CKPULab1DLL::CKPULab1DLL()
{
    return;
}

int CKPULab1DLL::AddNumbers(int x, int y)
{
	return x + y;
}

std::string CKPULab1DLL::AddStrings(std::string x, std::string y)
{
	return x+y;
}

char * CKPULab1DLL::AddChars(char * x, char * y)
{
	char * newArray = new char[std::strlen(x) + std::strlen(y) + 1];
	strcpy_s(newArray, sizeof(x), x);
	strcat_s(newArray, sizeof(y), y);
	return newArray;
}
