// MathLibrary.h - Contains declaration of Function class  
#pragma once  

#ifdef MATHLIBRARY_EXPORTS  
#define MATHLIBRARY_API __declspec(dllexport)   
#else  
#define MATHLIBRARY_API __declspec(dllimport)   
#endif
#include <string>

namespace Adder
{
	// This class is exported from the MathLibrary.dll  
	class Functions
	{
	public:
		static int AddNumbers(int x, int y);

		static std::string AddStrings(std::string x, std::string y);

		char* AddChars(char* x, char* y) const;
	};
}
