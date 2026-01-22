#include <stdio.h>
#include <string.h>

int main() {
    int hp = 5;
    char lett;
    char word[6];
    // Zadej slovo o delce 5:
    scanf("%5s", word);

    while (hp != 0) {
        // Hadej pismenko
        scanf(" %c", &lett);
        if (strchr(word, lett) != NULL) {
            for(int i = 0;i < strlen(word);i++){
               if () {
                   
               }
            }
            printf("Pismenko %c je ve slove\n", lett);
        }
        else {
            hp -= 1;
            printf("-1 hp, zustatek: %d hp\n", hp);
        }

    }
     


    return 0;
}