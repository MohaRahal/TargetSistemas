#include <stdio.h>
#include <stdlib.h>
#include <string.h>



int main(){

    int i = 0; // NOSSO INDICE PARA PERCORRER A STRING
    int ocorrencia = 0; // NOSSO INDICE PARA SABER O NUMERO DE OCORRENCIAS DA LETRA
    char str[50]; // NOSSA STRING PARA ARMAZENAR A FRASE

    puts("insira uma palavra ou frase para string:\n"); // CAPTURA DA STRING PELO USUARIO
        gets(str);
        system("cls");
    for(i=0; i < strlen(str); i++){ // INICIO DO LOOPING UTILZANDO O TAMANHO DA STRING
        if(str[i] == 'a' || str[i]== 'A'){
            ocorrencia++;
        }       
    }
    if(ocorrencia == 0){
        printf("A letra A nao foi inserida nenhuma vez"); // CASO A LETRA "A" NAO FOSSE ENCONTRADA
    }
    printf("%d",ocorrencia);    // EXIBE O RESULTADO
    
}
