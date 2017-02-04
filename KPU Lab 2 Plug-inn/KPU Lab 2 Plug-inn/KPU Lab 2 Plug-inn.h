// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the KPULAB2PLUGINN_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// KPULAB2PLUGINN_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef KPULAB2PLUGINN_EXPORTS
#define KPULAB2PLUGINN_API __declspec(dllexport)
#else
#define KPULAB2PLUGINN_API __declspec(dllimport)
#endif
#include "CDLLclass.h"
#include "CDLLClass1.h"

// This class is exported from the KPU Lab 2 Plug-inn.dll
class KPULAB2PLUGINN_API CKPULab2Pluginn{
public:
	CKPULab2Pluginn(void);
	// TODO: add your methods here.
	CDLLclass1 * CreateDllObject();
	void DeleteDllObject(CDLLclass *);
};

extern KPULAB2PLUGINN_API int nKPULab2Pluginn;

KPULAB2PLUGINN_API int fnKPULab2Pluginn(void);
