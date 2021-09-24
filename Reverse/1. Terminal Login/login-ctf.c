#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc, char **argv)
{
    printf("*=====================================================*\n");
    printf("|                    Login d:ctf	                  |\n");
    printf("*=====================================================*\n");
    
    char username[50];
    char password[100];
    
    printf("Username: ");
    scanf("%s", username);
    printf("Password: ");
    scanf("%s", password);
    
    if (!strcmp(username, "Dips-CTF"))
        {
            if (!strcmp(password, "eHealth"))
            {
                printf("Access Granted\n");
                char s[40] = "_a_way_of_thinking";
                printf("d:ctf{%s%s}\n", password, s);
            }
            else
            {
                printf("Access Denied\n");
                printf("Wrong Password\n");
            }
        }
        else
        {
            printf("Access Denied\n");
            printf("Wrong Username\n");
        }
        
    return 0;
}