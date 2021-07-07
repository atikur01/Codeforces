#include <iostream>
#include <cstdlib>
using namespace std;

int main()
{
    int n;
    cin >> n;

    while (n--) {
        int a, b, c;
        cin >> a >> b >> c;

        int e = abs(a - c);
        int f = abs(b - c);

        
         
        if (b > a) {
            if (abs(e - f) <= c) {

                cout << "YES" << endl;

            }
        }
         else {
             if (abs(a - b) <= c) {
                 cout << "YES" << endl;

             }
             else if (abs(a - b) > c) {
                 cout << "NO" << endl;

             }
         }
        
         
       

    }
}
