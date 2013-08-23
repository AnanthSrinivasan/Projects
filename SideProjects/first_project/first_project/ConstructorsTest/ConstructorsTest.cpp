//ConstructorsTest.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "mem_init_list_player.h"

TEST(Test, TRUETEST) 
{ 
	EXPECT_TRUE(true);
}

class player_racer_test : public player_racer
{
public:
	player_racer_test(int ht,
			int wt,
			int stg,
			const char *str) : player_racer(ht, wt, stg, "")
	{}

	void profile()
	{
		std::cout << "Name : " << name << std::endl;
		std::cout << "Height : " << height_in_cms << std::endl;
		std::cout << "Weight : " << weight_in_kgs << std::endl;
		std::cout << "Strength : " << strength << std::endl;
	}

};

int _tmain(int argc, _TCHAR* argv[])
{
	::testing::InitGoogleMock(&argc, argv);

	int c= RUN_ALL_TESTS();
	
	player_racer_test xtest(181, 70, 10, "iphone");
	xtest.profile();

	getchar();
	return c;
}

