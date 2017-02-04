// KPU Lab 2 Plug-inn.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "KPU Lab 2 Plug-inn.h"
#include "CDLLClass1.h"


// This is an example of an exported variable
KPULAB2PLUGINN_API int nKPULab2Pluginn=0;

// This is an example of an exported function.
KPULAB2PLUGINN_API int fnKPULab2Pluginn(void)
{
    return 42;
}

// This is the constructor of a class that has been exported.
// see KPU Lab 2 Plug-inn.h for the class definition
CKPULab2Pluginn::CKPULab2Pluginn()
{
}

CDLLclass1* CKPULab2Pluginn::CreateDllObject()
{
	return new CDLLclass1;
}

void CKPULab2Pluginn::DeleteDllObject(CDLLclass*)
{

}
