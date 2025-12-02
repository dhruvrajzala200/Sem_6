#include <stdio.h>
#include <ctype.h>

int main() {
    FILE *fp = fopen("Dmo.txt", "r");
    char c;
    int newWord = 1;

    while ((c = fgetc(fp)) != EOF) {
        if (newWord && isalpha(c)) {
            c = toupper(c);
            newWord = 0;
        } else if (c == ' ' || c == '\n' || c == '\t') {
            newWord = 1;
        }
        putchar(c); 
    }

    fclose(fp);
    return 0;
}


