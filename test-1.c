#include <stdio.h>

int Fibonnaci(int n){ // utilizei a recursividade para calcular a sequencia
    if(n <= 1){
        return n;
    }
    return Fibonnaci(n-1) + Fibonnaci(n-2);
}


int pertence_fibonacci(int n){ // aqui vamos ver se o numero pertence a sequencia de fibonnaci
    int i= 0;
    int fib;

// calcula os numeros de fibonnaci ate o numero do usuario
    while(1){
        fib = Fibonnaci(i);
        if(fib == n){
            return  1; // se pertencer retorna 1
        }
        if(fib> n){
            return 0;
        }
        i++;
    }
}



int main(){
    int num;

    printf("\ninforme um numero:");
        scanf("%d",num);
    
    if(pertence_fibonacci(num)){
        printf("o numero %d pertence a sequencia de fibonnacci.\n",num);
    }else{
        printf("O numero %d nao pertence a sequencia de fibonacci\n",num);
    }
    return 0;
}