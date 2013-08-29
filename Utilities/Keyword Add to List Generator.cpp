#include<cstring>
#include<fstream>
#include<iostream>
using namespace std;

int main(void)
{
    string s;

    ifstream in("Keyword.Txt");
    ofstream out("_Keyword Add to List.Txt");

    while(getline(in,s))
    {
            out <<"Form1.Lessons.Items.Add(\"";
            out <<s;
            out <<"\")";
            out <<"\n";
    }
}
