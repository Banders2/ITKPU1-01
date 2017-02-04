// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the KPULAB1DLL_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// KPULAB1DLL_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef KPULAB1DLL_EXPORTS
#define KPULAB1DLL_API __declspec(dllexport)
#else
#define KPULAB1DLL_API __declspec(dllimport)
#endif
#include <string>

// This class is exported from the KPU Lab 1 DLL.dll
class KPULAB1DLL_API CKPULab1DLL {
public:
	CKPULab1DLL(void);
	// TODO: add your methods here.
	int AddNumbers(int x, int y);
	std::string AddStrings(std::string x, std::string y);
	char* AddChars(char* x, char* y);
};

extern KPULAB1DLL_API int nKPULab1DLL;

KPULAB1DLL_API int fnKPULab1DLL(void);
