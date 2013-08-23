#include <iostream>

int atoi_impl(const char* str)
{
	int result = 0;

	if (!str)	//NULL check
		return -1;

	while (*str == ' ' || *str == '\t')	//white space and tab check
		str++;

	while (*str != NULL) 
	{
		if (*str >= '0' && *str <= '9')	//numbers check 
		{ 
			if (result * 10 + ((int)*str - '0') < result) 
			{ 
				std::cout << "Buffer overflow" << std::endl;
				return -1;
			}
		}
		result = result * 10 + ((int)*str - '0');
		str++;
	}

	return result;	
}

