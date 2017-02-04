// Tester.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "../KPU Lab 2 Plug-inn/KPU Lab 2 Plug-inn.h"
#include "../KPU Lab 2 Plug-inn/CDLLClass1.h"
#include "../KPU Lab 2 Plug-inn/CAppUtillmp.h"
#include <iostream>


int main()
{
	CKPULab2Pluginn test;
	CDLLclass1* test2 = test.CreateDllObject();
	test2->Init(new CAppUtillmp ("Heiiidrooonnn"));
	std::string teststring = test2->Tst->MyAddString("Hej ", "Anders");

	std::cout << "teststring: " << teststring << "\n";
	std::cout << "testname: " << test2->Tst->GetName() << "\n";

    return 0;
}

