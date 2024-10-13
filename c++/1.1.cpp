#include <iostream>
#include <cmath>
class AG {
public:
    AG(int n1, int n2, int n3, double lower_bound, double upper_bound, double step)
        : n1(n1), n2(n2), n3(n3), lower_bound(lower_bound), upper_bound(upper_bound), step(step) {
        a = new double[n1];
        b = new int[n2];
        c = new double[n3];
    }
    ~AG() {
        delete[] a;
        delete[] b;
        delete[] c;
    }
    void generate_a() {
        int i = 0;
        for (double x = lower_bound; x <= upper_bound && i < n1; x += step, ++i) {
            try {
                a[i] = 1 / x - 2 ;
            }
            catch (...) {
                a[i] = 0;
            }
        }
    }
    void generate_b() {
        for (int i = 0; i < n2; ++i) {
            b[i] = rand() % 21 - 10;
        }
    }
    void generate_c() {
        for (int i = 0; i < n3; ++i) {
            try {
                c[i] = log(a[i] - 1.0 / b[i - 1]);
            }
            catch (...) {
                c[i] = 0;
            }
        }
    }
    void print_a() {
        std::cout << "Mas a: ";
        for (int i = 0; i < n1; ++i) std::cout << a[i] << ' ';
        std::cout << '\n';
    }
    void print_b() {
        std::cout << "Mas b: ";
        for (int i = 0; i < n2; ++i) std::cout << b[i] << ' ';
        std::cout << '\n';
    }
    void print_c() {
        std::cout << "Mas c: ";
        for (int i = 0; i < n3; ++i) std::cout << c[i] << ' ';
        std::cout << '\n';
    }
private:
    int n1, n2, n3;
    double lower_bound, upper_bound, step;
    double* a;
    int* b;
    double* c;
};
int main() {
    AG generator(20, 30, 40, -1.0, 5.0, 0.3);
    generator.generate_a();
    generator.generate_b();
    generator.generate_c();
    generator.print_a();
    generator.print_b();
    generator.print_c();
    return 0;
}
