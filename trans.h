#ifndef ecoli_h
#define ecoli_h

#include <iostream>
#include <vector>
#include <algorithm>
#include <cstdlib>
#include "Ecoli_codon_usage.h"

std::string TRANS(char a)
{
    std::vector<std::string> b;

    if (a == 'A') b = codon_A;
    if (a == 'G') b = codon_G;
    if (a == 'E') b = codon_E;
    if (a == 'D') b = codon_D;
    if (a == 'V') b = codon_V;
    if (a == 'R') b = codon_R;
    if (a == 'S') b = codon_S;
    if (a == 'K') b = codon_K;
    if (a == 'N') b = codon_N;
    if (a == 'M') b = codon_M;
    if (a == 'I') b = codon_I;
    if (a == 'T') b = codon_T;
    if (a == 'W') b = codon_W;
    if (a == 'C') b = codon_C;
    if (a == 'Y') b = codon_Y;
    if (a == 'L') b = codon_L;
    if (a == 'F') b = codon_F;
    if (a == 'Q') b = codon_Q;
    if (a == 'H') b = codon_H;
    if (a == 'P') b = codon_P;

    size_t randomIndex = std::rand() % b.size();
    return b[randomIndex];
}

//TRANS() is the function that translates the inputted AA sequence into the corresponding DNA sequence. The rules for the translation are in the codon_usage.h file.
//


#endif //ecoil_h
