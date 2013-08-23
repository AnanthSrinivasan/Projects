// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently
//

#pragma once

#include <stdio.h>
#include <tchar.h>

#include <gmock/gmock.h> 
#include <gtest/gtest.h> 

#ifdef _DEBUG
#pragma comment(lib, "gmockd.lib")
#pragma comment(lib, "gtestd.lib")
#else
#pragma comment(lib, "gmock.lib")
#pragma comment(lib, "gtest.lib")
#endif

