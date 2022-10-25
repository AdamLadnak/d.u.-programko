#include <iostream>
using namespace std;

int main()
{
    /*
    string pondelok[7] = { "TSV", "MAT", "FYZ", "ELE", "SJL", "NBV", "ANJ" };
    string utorok[7] = { "SJL", "MAT", "TSV", "DDM", "DDM", "ANJ", "   " };
    string streda[7] = { "ZCY", "ANJ", "DSY", "DSY", "PRX", "PRX", "PRX" };
    string stvrtok[7] = { "FYZ", "MAT", "ANJ", "SJL", "OBN", "PI1", "PI1" };
    string piatok[7] = { "KPZ", "KPZ", "CEE", "CEE", "MAT", "CPD", "CPD" };

    cout << "ROZVRH II.AT - AL" << endl;

    for (int i = 0; i < 7; i++)
    {
        cout << pondelok[i] << " | ";
    }
    cout << endl;
    for (int i = 0; i < 7; i++)
    {
        cout << utorok[i] << " | ";
    }
    cout << endl;
    for (int i = 0; i < 7; i++)
    {
        cout << streda[i] << " | ";
    }
    cout << endl;
    for (int i = 0; i < 7; i++)
    {
        cout << stvrtok[i] << " | ";
    }
    cout << endl;
    for (int i = 0; i < 7; i++)
    {
        cout << piatok[i] << " | ";
    }
    */
    string rozvrh[5][7] = { { "TSV", "MAT", "FYZ", "ELE", "SJL", "NBV", "ANJ" }, 
                            { "SJL", "MAT", "TSV", "DDM", "DDM", "ANJ", "   " },
                            { "ZCY", "ANJ", "DSY", "DSY", "PRX", "PRX", "PRX" },
                            { "FYZ", "MAT", "ANJ", "SJL", "OBN", "PI1", "PI1" },
                            { "KPZ", "KPZ", "CEE", "CEE", "MAT", "CPD", "CPD" } };

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            cout << rozvrh[i][j] << " | ";
            if (j == 6)
                cout << endl;
        }
    }

}
