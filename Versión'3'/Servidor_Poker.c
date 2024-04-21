#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <my_global.h>
#include <mysql.h>
#include <pthread.h>

int contadorConectados = 0;
const int maximoConectados = 100;
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

/* Ponemos estas variables aqui porque deben ser de acceso global */
/* Ya que la conexion se abre en la funcion "main" pero */
/* las consultas MySQL se hacen en "AtenderCliente" */
MYSQL *conn;
MYSQL_RES *resultado;
MYSQL_ROW row;

int main(int argc, char *argv[]) 
{
	conn = mysql_init(NULL);
	
	if (conn==NULL) {
		printf ("Error al crear la on: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}

	conn = mysql_real_connect (conn, "localhost","root", "mysql", "Campeonato",0, NULL, 0);
	
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn))
		exit (1);
	}
	
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	
	memset(&serv_adr, 0, sizeof(serv_adr));
	serv_adr.sin_family = AF_INET;
	
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	
	serv_adr.sin_port = htons(9050);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf ("Error en la escucha");


	/* Por cada cliente, crearemos un thread */
	/* Cada thread se encargará de crear un bucle infinito que procese las peticiones de su cliente */
	pthread_t threadCliente;
	
	/* Creamos un bucle while para que se escuchen peticiones indefinidamente */
	while (true) {
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf("Conexion recibida\n");

		/* Comprobamos que no haya el maximo de conectados ya */
		pthread_mutex_lock(&mutex);

		if (contadorConectados >= maximoConectados)
		{
			pthread_mutex_unlock(&mutex);
			close(sock_conn);

			printf("Maximo de clientes alcanzado!\n");
			continue;
		}

		/* Como no hemos llegado al maximo aun, */
		/* procesamos este cliente*/
		contadorConectados++;
		pthread_mutex_unlock(mutex);

		/* Creamos un thread que ejecuta la funcion "AtenderCliente" */
		/* y le pasa como parametro "sock_conn" (su socket, conexion) */
		pthread_create(&thread, NULL, AtenderCliente, &sock_conn);
		
	}	
}

/* Creamos una funcion que se encargara de atender las peticiones de un cliente */
/* Como parametro recibe el "socket" de su conexion */
void *AtenderCliente(void *socket)
{
	int sockConn = *((int*) socket);

	char peticion[512];
	char respuesta[512];
	int err;

	/* Utilizamos esta variable para saber cuando salir del bucle infinito */
	/* seDesconecta = 1 cuando el cliente se quiera desconectar (mensaje "0/")*/
	int seDesconecta = 0;

	while (seDesconecta == 0)
	{
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf("Recibido\n");
		
		peticion[ret]='\0';
		printf("Peticion: %s\n",peticion);
			
		char *p = strtok(peticion, "/");
		int codigo = atoi(p);
		p = strtok(NULL, "/");
		// char nombre[20];
		int gradosc = atof (p);

		/* Cuando se recibe el codigo 0 ("0/") el jugador se desconecta */
		if (codigo == 0)
		{
			seDesconecta = 1;
			continue;
		} else if (codigo == 1){
			/* Obtenemos el nombre del jugador que queremos consultar */
			char nombre[20];
			strcpy(nombre, p);
			p = strtok(NULL, "/");

			/* Aqui hace falta escribir la consulta a la base de datos para obtener el numero de partidas */
			/* Por ejemplo... */

			 char consulta[80];
			 strcpy(consulta, "SELECT Jugadores.Nombre FROM Jugadores, Ranking WHERE Jugadores.Nombre = '%s''", nom);
			 strcat (consulta, nom)
			 err = mysql_query(conn, consulta);

			 if (err != 0)
			 {
			// 	/* procesar error en MySQL... */	
				printf ("Error al consultar datos de la base %u %s\n",mysql_errno(conn), mysql_error(conn));
				exit (1);
			 }

			resultado = mysql_store_result (conn);
			row = mysql_fetch_row (resultado);
			
			int contador = 0;

			if (row == NULL)
			{
				printf ("No se han obtenido datos en la consulta\n");
			}
			else
			{
				while (row != NULL) {
					contador++;

					/* Intentamos obtener una nueva fila */
					row = mysql_fetch_row(resultado);
				}

				printf("%s ha jugado %u partidas\n", nombre, contador);
				
				sprintf(respuesta, "%d\n", contador);
				write(sockConn, respuesta, strlen(respuesta));
			}
		}	
		else if (codigo == 2){
			/* Obtenemos la fecha que queremos consultar */
			char fecha[20];
			p = strtok(NULL, "/");
			strcpy(fecha, p);

			/* Aqui hace falta escribir la consulta a la base de datos para obtener el numero de jugadores que jugaron en una fecha */
			/* Por ejemplo... */

			char consulta[80];
			strcpy(consulta, "SELECT Jugadores.Nombre FROM Jugadores, Ranking, Partidas WHERE Partidas.Fecha = '%s'", data);
			strcat (consulta, nom)
			printf(jugadores.Nombre);
			err = mysql_query(conn, consulta);

			if (err != 0)
			{
			// 	/* procesar error en MySQL... */	
			
				printf ("Error al consultar datos de la base %u %s\n",mysql_errno(conn), mysql_error(conn));
				exit (1);
			}

			resultado = mysql_store_result (conn);
			row = mysql_fetch_row (resultado);

			int contador = 0;

			if (row == NULL)
				printf ("No se han obtenido datos en la consulta\n");
			else
			{
				while (row != NULL) {
					contador++;

					/* Intentamos obtener una nueva fila */
					row = mysql_fetch_row(resultado);
				}
				printf("Fecha %s se han jugado %u partidas\n", fecha, contador);
				

				/* Enviamos el resultado al cliente */
				sprintf(respuesta, "%d\n", contador);
				write(sockConn, respuesta, strlen(respuesta));
			}
		}	
		else if (codigo == 3){
			/* Obtenemos el nombre que queremos consultar */
			char nombre[20];
			p = strtok(NULL, "/");
			strcpy(nombre, p);

			/* Obtenemos la altura que queremos consultar */
			char altura[20];
			p = strtok(NULL, "/");
			strcpy(altura, p);

			/* Aqui hace falta escribir la consulta a la base de datos para obtener la posicion del ranking */
			/* Por ejemplo... */

			char consulta[80];
			strcpy(consulta, "SELECT Ranking.ID_r FROM Jugadores, Ranking, Partidas WHERE Jugadores.Nombre = '%s'", nombre);
			strcat (consulta, nom);

			err = mysql_query(conn, consulta);
			printf(Ranking.ID_r);

			if (err != 0)
			{
			// 	/* procesar error en MySQL... */
				printf ("Error al consultar datos de la base %u %s\n",mysql_errno(conn), mysql_error(conn));
				exit (1);
				
			}

			resultado = mysql_store_result (conn);
			row = mysql_fetch_row (resultado);

			int contador = 0;

			if (row == NULL)
				printf ("No se han obtenido datos en la consulta\n");
			else
			{

				/* Obtener la posicion del ranking a partir de la consulta MySQL */
				int posicionRanking = 0;
				/* ... */

				/* Enviamos el resultado al cliente */
				sprintf(respuesta, "%d\n", posicionRanking);
				write(sockConn, respuesta, strlen(respuesta));
			}
		}
		resultado = mysql_store_result (conn);
			row = mysql_fetch_row (resultado);
			int contador = 0;
			if (row == NULL)
				printf ("No se han obtenido datos en la consulta\n");
			else
				char consulta [80];
			
			strcpy (consulta,"INSERT INTO Jugadores VALUES (7, 'º%s', %d)",nombre, contraseña );
			strcat (consulta, nom)  
				err=mysql_query (conn, consulta);
			if (err!=0) {
				printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
		 else if (codigo == 0){
			/* Procesamos la desconexion */
			
			/* El jugador se ha querido desconectar, cerramos la conexion y salimos de la funcion... */

			/* Restamos 1 al conectador de conectados */
			pthread_mutex_lock(&mutex);
			contadorConectados--;
			pthread_mutex_unlock(&mutex);

			/* Cerramos la conexion */
			/* goodbye! */
			close(socketConn);
		 }
	}
}