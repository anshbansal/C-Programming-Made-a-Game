#include<cstring>
#include<fstream>
#include<iostream>
using namespace std;

int main(void)
{
    string s;

    ifstream in("Libraries.Txt");
    ofstream out("_Libraries String Declarations.Txt");

    while(getline(in,s))
    {
        out <<"Public Const String_";
        for(int i=0; s[i] !='\0'; i++)
        {
            if(   (s[i]<65)  ||  (  (s[i]>90)  &&  (s[i]<97)  )  ||  (s[i]>122)   )
            {
                out <<'_';
            }
            else
                out << s[i];
        }
        out <<" As String = \"\"\n";
    }
}
