#include <stdio.h>

int main() {
    FILE* fp = fopen("Demo.txt", "r");

    int countChar = 0;
    int countLine = 0;
    int countTab = 0;
    int countSpace = 0;

    char c;
    while ((c = fgetc(fp)) != EOF) {
        if (c != ' ' && c != '\n' && c != '\t'){
            countChar++;
        }
        if (c == '\n'){
            countLine++;
        }
        if (c == '\t'){
            countTab++;
        }
        if(c == ' '){
            countSpace++;
        }
    }

    printf("Char Count: %d\n", countChar);
    printf("Line Count: %d\n", countLine);
    printf("Tab Count : %d\n", countTab);
    printf("Space COunt: %d\n",countSpace);

    fclose(fp);
    return 0;
}
