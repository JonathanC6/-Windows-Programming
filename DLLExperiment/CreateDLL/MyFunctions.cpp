#include "MyFunctions.h"
#include "pch.h"
#include<iostream>
using namespace std;

int Factorial(int n) {
    if (n < 0) return -1; //·Ç·¨ÊäÈë
    int result = 1;
    for (int i = 1; i <= n; ++i) {
        result *= i;
    }
    return result;
}

int Difference(int& a, int& b) {
    if (a < b) swap (a, b);
    return a - b;
}
