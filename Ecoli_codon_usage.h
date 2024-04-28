#pragma once
#include <vector>
#include <string>

//This is E.coli codon usage.
//

std::vector<std::string> codon_A = { "GCG","GCG","GCG","GCG","GCG", "GCA", "GCA","GCA","GCT","GCT", "GCC", "GCC", "GCC" };

std::vector<std::string> codon_G = { "GGG", "GGG", "GGG", "GGT","GGT", "GGT", "GGC", "GGC", "GGC", "GGC" };

std::vector<std::string> codon_E = { "GAG", "GAA", "GAA" };

std::vector<std::string> codon_D = { "GAT", "GAT", "GAC" };

std::vector<std::string> codon_V = { "GTG", "GTG", "GTG", "GTG", "GTA", "GTA", "GTT", "GTT","GTT", "GTC","GTC" };

std::vector<std::string> codon_R = { "AGG", "AGA", "CGG","CGG", "CGA", "CGA","CGT",
    "CGT","CGT","CGT","CGT","CGT","CGT","CGT","CGT","CGT","CGT",
    "CGT","CGT","CGT","CGT","CGT","CGT","CGT","CGT","CGT","CGT",
    "CGC","CGC","CGC","CGC","CGC","CGC","CGC","CGC","CGC","CGC",
    "CGC","CGC","CGC","CGC","CGC","CGC","CGC","CGC","CGC","CGC" };

std::vector<std::string> codon_S = { "AGT", "AGC", "AGC", "TCG", "TCA", "TCT", "TCC" };

std::vector<std::string> codon_K = { "AAG", "AAA", "AAA", "AAA" };

std::vector<std::string> codon_N = { "AAT", "AAC" };

std::vector<std::string> codon_I= { "ATA", "ATC", "ATC", "ATC", "ATC", "ATT", "ATT", "ATT", "ATT", "ATT" };

std::vector<std::string> codon_T = { "ACG", "ACG", "ACG", "ACA", "ACT", "ACT", "ACC", "ACC", "ACC", "ACC" };

std::vector<std::string> codon_C = { "TGT", "TGC" };

std::vector<std::string> codon_Y = { "TAT", "TAT", "TAT", "TAC", "TAC" };

std::vector<std::string> codon_L = { "TTG", "TTA", "CTG", "CTG", "CTG", "CTG", "CTG", "CTA", "CTT", "CTC" };

std::vector<std::string> codon_F = { "TTT", "TTC" };

std::vector<std::string> codon_Q = { "CAG", "CAG", "CAA" };

std::vector<std::string> codon_H = { "CAT", "CAT",  "CAT", "CAT", "CAC", "CAC", "CAC" };

std::vector<std::string> codon_P = { "CCG", "CCG", "CCG", "CCG", "CCG", "CCA", "CCA",  "CCT", "CCT", "CCC" };

std::vector<std::string> codon_M = { "ATG"};

std::vector<std::string> codon_W = { "TGG" };