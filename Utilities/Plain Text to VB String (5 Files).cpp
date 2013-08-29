#include<cstring>
#include<fstream>
#include<iostream>
using namespace std;

int main(void)
{
    string s;

    {//File 1 Parsing
        ifstream in("Goals.txt");
        ofstream out("_Goals.txt");
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
    {//File 2 Parsing
        ifstream in("Instructions.txt");
        ofstream out("_Instructions.txt");
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
    {//File 3 Parsing
        ifstream in("Code To Be Copied.txt");
        ofstream out("_Code To Be Copied.txt");
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
    {//File 4 Parsing
        ifstream in("Detials of the Code.txt");
        ofstream out("_Detials of the Code.txt");
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
    {//File 5 Parsing
        ifstream in("Further Technical Details.txt");
        ofstream out("_Further Technical Details.txt");
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
