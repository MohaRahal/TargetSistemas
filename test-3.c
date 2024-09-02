#include <stdio.h>
#include <stdlib.h>




int main(){
    int INDICE = 12 , SOMA = 0 , K = 1;

    while(K < INDICE){ // UTILIZADO O LACO WHILE
        K = K + 1;
        SOMA = SOMA + K;
    }
    printf("%d",SOMA); // SOMA = 77
}