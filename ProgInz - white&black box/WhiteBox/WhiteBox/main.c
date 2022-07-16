#include "header.h"

int main()
{
	// White box
	printf_s("White box\n");
	int countErrors = 0;
	int expectedValue = 0;

	// 1. Function CountSum
	printf_s("1. Function flip_number\n");
	int num = -12;
	int rev = 0;
	expectedValue = -21;
	rev = flip_number(num);
	if (rev != expectedValue)
		countErrors++;
	printf_s("Test 1: num = %d, rev = %d\n", num, rev);

	num = 1300;
	expectedValue = 31;
	rev = flip_number(num);
	if (rev != expectedValue)
		countErrors++;
	printf_s("Test 2: num = %d, rev = %d\n", num, rev);

	num = 0;
	expectedValue = 0;
	rev = flip_number(num);
	if (rev != expectedValue)
		countErrors++;
	printf_s("Test 3: num = %d, rev = %d\n", num, rev);

	num = 354;
	expectedValue = 453;
	rev = flip_number(num);
	if (rev != expectedValue)
		countErrors++;
	printf_s("Test 4: num = %d, rev = %d\n", num, rev);

	// 2. Function read_string
	printf_s("1. Function read_string\n");
	FILE* read_file = NULL;
	expectedValue = -2;
	int* array;
	if (read_string(NULL) != expectedValue)
		countErrors++;
	
	

	// 3. Function output_numbers
	printf_s("1. Function output_numbers\n");
	FILE* file2 = NULL;
	int* new_array;
	expectedValue = -3;
	
	if (output_numbers(file2, NULL) != expectedValue)
		countErrors++;
	
	

	printf_s("Amount of errors: %d\n", countErrors);
}