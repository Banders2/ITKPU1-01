// TesterLoadTime.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <windows.h> 
#include "../Test/Test.h"
#include <iostream>

int main()
{
	int x = 1;
	int y = 2;
	std::string stringA = "Test";
	std::string stringB = " of this dll with string";
	char* charA = "Test";
	char* charB = " of this dll with char*";

	CTest test;
	int numberResult = test.AddNumbers(x, y);
	std::string stringResult = test.AddStrings(stringA, stringB);
	char* charResult = test.AddChars(charA, charB);


	std::cout << "The result is: " << numberResult << "\n";
	std::cout << "The result is: " << stringResult << "\n";
	std::cout << "The result is: " << charResult << "\n";
	
}

