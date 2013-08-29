#include<cstring>
#include<fstream>
#include<iostream>
using namespace std;

int main(void)
{
    string s;

    ifstream in("Keyword.Txt");
    ofstream out("_Keyword Case.Txt");
    bool firstline = false;
    while(getline(in,s))
    {
        if(firstline == true)
        {
            out << '\n';
        }
        out <<"Case \"";
        out <<s;
        out <<"\"";
        out <<"\n                        Form1.Display.Text = String_";
        for(int i=0; s[i] !='\0'; i++)
        {
            if(   (s[i]<65)  ||  (  (s[i]>90)  &&  (s[i]<97)  )  ||  (s[i]>122)   )
            {
                out <<'_';
            }
            else
                out << s[i];
        }
        firstline = true;
    }
}

/*
Case "Step 01"
                        Form1.Display.Text =
*/
