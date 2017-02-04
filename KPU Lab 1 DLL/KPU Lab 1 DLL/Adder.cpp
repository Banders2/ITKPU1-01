#include "stdafx.h"
#include "Adder.h"

namespace Adder
{
	int Functions::AddNumbers(int x, int y)
	{
		return x + y;
	}

	std::string Functions::AddStrings(std::string x, std::string y)
	{
		return x + y;
	}

	char * Functions::AddChars(char * x, char * y) const
	{
		char * newArray = new char[std::strlen(x) + std::strlen(y) + 1];
		strcpy_s(newArray, sizeof(x), x);
		strcat_s(newArray, sizeof(y), y);
		return newArray;
	}
}