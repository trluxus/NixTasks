CREATE TABLE ReservationCandidates(
	ResId INT FOREIGN KEY REFERENCES Reservations(Id),
	CusId INT FOREIGN KEY REFERENCES CUSTOMERS(Id),
	PRIMARY KEY(ResId, CusId)
)