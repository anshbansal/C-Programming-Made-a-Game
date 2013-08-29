#include<cstring>
#include<fstream>
#include<iostream>
using namespace std;

int main(void)
{
    string s;

    {//File 1 Parsing
        ifstream in("One.txt");
        ofstream out("_One.txt");
        string endline = "& Chr(13) &";
        bool firstline = false;
        while(getline(in, s))
        {
            if(firstline == true)
            {
                out << endline;
            }
            out <<"\"";
            for(int i = 0; s[i] !='\0' ; i++)
            {
                if(s[i] == '\"')
                {
                    out << "\"\"";
                }
                else
                {
                    out <<s[i];
                }
            }
            out <<"\"";
            firstline = true;

        }
    }
    return 0;
}
