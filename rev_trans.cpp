#include <iostream>
#include <string>
#include "trans.h"
using namespace std;


int main()
{
    while (1)
    {
        cout << "Enter aa sequence: " << endl;
        string input;

        cin >> input;

        cout << endl << "The reverse translation is: "<< endl << endl;

        for (char c : input) 
        {
            string dnaSeq = TRANS(c);
            cout << dnaSeq;
        }
        cout << endl << endl;
     }
    
    return 0;
}

//main() is the main function that takes the input AA sequence and sends it to the TRANS(), then prints the corresponding DNA sequence.
//