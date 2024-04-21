
USE Poker;
CREATE TABLE Usuarios(
					   ID_j INTEGER PRIMARY KEY NOT NULL,
					   Nombre TEXT NOT NULL,
					   Contraseña INTEGER NOT NULL
					   )ENGINE = InnoDB;

CREATE TABLE Partidas (
						ID_partida INT NOT NULL PRIMARY KEY AUTO_INCREMENT, 
						Num_jug INT, Duracion FLOAT, 
						Jugador1 INT NOT NULL, 
						Jugador2 INT NOT NULL, 
						Jugador3 INT NOT NULL, 
						Jugador4 INT NOT NULL, 
						FOREIGN KEY (Jugador1) REFERENCES Usuarios(ID_usuario),
						FOREIGN KEY (Jugador2) REFERENCES Usuarios(ID_usuario),
						FOREIGN KEY (Jugador3) REFERENCES Usuarios(ID_usuario),
						FOREIGN KEY (Jugador4) REFERENCES Usuarios(ID_usuario),
						Puntos_T1 INT, Puntos_T2 INT
						) ENGINE = InnoDB;



CREATE TABLE Ranking(
					 Jugador INTEGER NOT NULL,
					 Partida INTEGER NOT NULL,
					 ID_r INTEGER PRIMARY KEY NOT NULL,
					 FOREIGNER KEY (Usuarios) REFERENCES Jugador (Nombre),
					 )ENGINE = InnoDB;


