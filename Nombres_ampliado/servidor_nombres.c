#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <ctype.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>

int main(int argc, char *argv[])
{
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char buff[512];
	char buff2[512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9070);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	int i;
	// Atenderemos peticiones infin
	for(;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi?n\n");
		//sock_conn es el socket que usaremos para este cliente
		
		int terminar = 0;
		while (terminar ==0)
		{
			// Ahora recibimos su nombre, que dejamos en buff
			ret=read(sock_conn,buff, sizeof(buff));
			printf ("Recibido\n");
			
			// Tenemos que a?adirle la marca de fin de string 
			// para que no escriba lo que hay despues en el buffer
			buff[ret]='\0';
			
			//Escribimos el nombre en la consola
			
			printf ("Se ha conectado: %s\n",buff);
			
		
			char *p = strtok( buff, "/");
			int codigo =  atoi (p);
			char nombre[20];
			
			if (codigo != 0)
			{
				p = strtok( NULL, "/");
				strcpy (nombre, p);
				printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
			}
			
			if (codigo == 0)
				terminar = 1;
			else if (codigo == 1) //piden la longitd del nombre
				sprintf (buff2,"%d",strlen (nombre));
			else if (codigo == 2)
				// quieren saber si el nombre es bonito
				if((nombre[0]=='M') || (nombre[0]=='S'))
				strcpy (buff2,"SI");
				else
					strcpy (buff2,"NO");
					
			else if (codigo == 3)// decir si es alto
				{
					p = strtok(NULL,"/");
					float altura = atof (p);
					if (altura > 1.70)
						sprintf (buff2, "%s: eres alto",nombre);
					else
						sprintf (buff2, "%s: eres bajo",nombre);
			}
			
			else if (codigo == 4) // decir nombre palindromo
			{
				int l = 0; 
				int t = strlen(nombre) - 1;
				int pal = 1;
				
				while (t > l){
					if (toupper(nombre[l++]) != toupper(nombre[t--])){
						pal = 0;
						break;
					}
				}
				if (pal) // palindromo
					strcpy(buff2,"SI");
				else // no
					strcpy(buff2,"NO");
			}
			
			else // convertir a Mayusculas
			{
				char mayusc[20];
				for (int i = 0; i<strlen(nombre);i++){
					mayusc[i] = toupper(nombre[i]);
				}
				sprintf (buff2,"%s",mayusc);
			}
			
			if (codigo != 0)
			{
				printf ("%s\n", buff2);
				// Y lo enviamos
				write (sock_conn,buff2, strlen(buff2));
				
			}
		}
	}
}
