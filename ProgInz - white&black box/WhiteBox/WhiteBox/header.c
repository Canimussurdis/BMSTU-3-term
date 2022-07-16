#include "header.h"

#define SIZE_OF_INT 30

#define FILE_IS_EMPTY -2
#define NO_RESULT -3

int size_array = 30;

int* read_string(FILE* read_file)
{
	if (read_file != NULL) {
		int get_symbol;
		int get_number = 0;
		int* array = (int*)malloc(sizeof(int));
		int minus = 1;
		fseek(read_file, 0, SEEK_SET);

		while ((get_symbol = fgetc(read_file)) != EOF)
		{
			if ((get_symbol >= '0') && (get_symbol <= '9'))
			{
				get_number = get_number * 10 + ((int)(get_symbol - '0'));
			}
			else if (((get_symbol == ' ') || (get_symbol == '\n')))
			{
				array[size_array++] = get_number * minus;
				get_number = 0;
				minus = 1;
				array = (int*)realloc(array, sizeof(int) * (size_array + 1));
			}
			else if (get_symbol == '-')
			{
				minus = -1;
			}
			else if (get_symbol != '.')
			{
				printf("Strings contain anything other than numbers\n");
				return NULL;
			}
			else
			{
				printf("Strings contain real numbers\n");
				return NULL;
			}

		}

		array[size_array++] = get_number * minus;
		return array;
	}
	else {
		return FILE_IS_EMPTY;
	}
}


int flip_number(int number)
{
	int rev = 0, rem = 0, minus = 1;

	if (number == 0) {
		return number;
	}
	else {

		if (number < 0)
		{
			minus = -1;
			number *= -1;
		}

		while (number > 0)
		{
			rem = number % 10;
			rev = rev * 10 + rem;
			number = number / 10;
		}
		rev *= minus;
		return rev;
	}
}


int output_numbers(FILE* write_file, int* array)
{
	if (write_file != NULL && array != NULL) {
		char* str = (char*)malloc(sizeof(char) * SIZE_OF_INT);
		for (int i = 0; i < size_array; i++)
		{
			if (array[i])
			{
				sprintf_s(str, 11, "%d\n", array[i]);
				fprintf(write_file, str);
			}
		}
	}
	else {
		return NO_RESULT;
	}
	return 0;
}

