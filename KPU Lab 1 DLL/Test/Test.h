// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the TEST_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// TEST_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef TEST_EXPORTS
#define TEST_API __declspec(dllexport)
#else
#define TEST_API __declspec(dllimport)
#endif
#include <string>

// This class is exported from the Test.dll
class TEST_API CTest {
public:
	CTest(void);
	static int AddNumbers(int x, int y);

	static std::string AddStrings(std::string x, std::string y);

	static char* AddChars(char* x, char* y);
};

extern TEST_API int nTest;

TEST_API int fnTest(void);
