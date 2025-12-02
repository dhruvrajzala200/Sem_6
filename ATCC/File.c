#include<stdio.h>

void main(){
    //FILE *fptr;

    //char filename[] = "DEMO.txt";

    FILE* fp = fopen("Demo.txt","w");

    fputs("Im in DUUUUUU \n Shu khabar \tplacement thase ke nai  joi have",fp);
    fclose(fp);

    fp = fopen("Demo.txt","r");

    char c;
    while((c=fgetc(fp)) != EOF ){ //eof etle end of file 
        printf("%c",c);
    }    
}