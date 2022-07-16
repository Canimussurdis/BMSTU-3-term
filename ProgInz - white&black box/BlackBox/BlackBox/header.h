#ifndef LIBRARY_H
#define LIBRARY_H

#include <stdio.h>
#include <stdlib.h>
#include <locale.h>


int* read_string(FILE* read_file);
int flip_number(int number);
int output_numbers(FILE* write_file, int* array);


#endif
