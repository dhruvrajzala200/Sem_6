#include <stdio.h>

int main() {
    FILE* fp = fopen("Demo.txt", "a");   
    FILE* dp = fopen("Dmo.txt", "r");   
    char c;

    while ((c = fgetc(dp)) != EOF) {
        fputc(c, fp); 
    }

    fclose(dp);
    fclose(fp);

    return 0;
}
