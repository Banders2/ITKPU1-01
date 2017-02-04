// Test.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "Test.h"
#include "../KPU Lab 1 DLL/Adder.h"


// This is an example of an exported variable
TEST_API int nTest=0;

// This is an example of an exported function.
TEST_API int fnTest(void)
{
    return 42;
}

// This is the constructor of a class that has been exported.
// see Test.h for the class definition
CTest::CTest()
{
    return;
}

int CTest::AddNumbers(int x, int y)
{
	return x + y;
}

std::string CTest::AddStrings(std::string x, std::string y)
{
	return x + y;
}

char * CTest::AddChars(char * x, char * y)
{

	size_t xLength = std::strlen(x);
	size_t yLength = std::strlen(y);
	char *newArray = new char[xLength + yLength + 20];
	int bufferSize = 50;

	strcpy_s(newArray, bufferSize, x);
	strncat_s(newArray, bufferSize, y, bufferSize);
	newArray[xLength + yLength + 2] = '\0';

	return (newArray);
}
