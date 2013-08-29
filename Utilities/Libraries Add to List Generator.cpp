#include<cstring>
#include<fstream>
#include<iostream>
using namespace std;

int main(void)
{
    string s;

    ifstream in("Libraries.Txt");
    ofstream out("_Libraries Add to List.Txt");

    while(getline(in,s))
    {
            out <<"Form1.Lessons.Items.Add(\"";
            out <<s;
            out <<"\")";
            out <<"\n";
    }
}
