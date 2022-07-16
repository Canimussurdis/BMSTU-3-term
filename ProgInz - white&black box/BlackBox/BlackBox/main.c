#include "header.h"

extern int size_array = 0;

int main(int argc, char* argv[])
{
	//setlocale(LC_ALL, "Rus");

	FILE* file1 = NULL;
	FILE* file2 = NULL;
	char* filename1 = argv[1];

	fopen_s(&file1, filename1, "r+");
	int* array;
	int* new_array;

	//проверка существует ли файл
	if (file1 != NULL)
	{
		fseek(file1, 0, SEEK_END);
		long pos = ftell(file1);
		if (pos != 0)
		{
			array = read_string(file1);
			char* filename2 = argv[2];
			fopen_s(&file2, filename2, "w");
			if (array == -1) {
				fprintf(filename2, "Wrong data!\n");
			}
			if (array == NULL)
			{
				return 0;
			}
			new_array = (int*)calloc(array, sizeof(int) * size_array);
			for (int i = 0; i < size_array; i++)
			{
				int number = array[i];
				int new_num = flip_number(number);
				new_array[i] = new_num;
			}

			//char* filename2 = argv[2];

			//fopen_s(&file2, filename2, "w");
			output_numbers(file2, new_array);
			//free(filename2);
			fclose(file2);
			printf("Everything is fine!\n");
		}
		else
		{
			printf("File is empty");
			return 0;
		}
	}
	else
	{
		printf("File with this name doesn't exist");
		return 0;
	}

	fclose(file1);
	//free(filename1);
	free(array);
	free(new_array);

	return 0;
}
