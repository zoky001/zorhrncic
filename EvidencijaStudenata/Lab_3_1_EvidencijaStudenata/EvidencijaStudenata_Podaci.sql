INSERT INTO Tim ([OznakaTima],[NazivProjekta],[OpisProjekta],[Napomena]) VALUES ('T01','Teretana .NET','Jednostavna aplikacija za rad u teretani.','Srednja razina.');
INSERT INTO Tim ([OznakaTima],[NazivProjekta],[OpisProjekta],[Napomena]) VALUES ('T02','Adresar .NET','Jednostavna aplikacija za evidentiranje kontakata.','Srednja razina');
INSERT INTO Tim ([OznakaTima],[NazivProjekta],[OpisProjekta],[Napomena]) VALUES ('T03','Skladište .NET','Aplikacija za voðenje skladišta.','Viša razina');
INSERT INTO Tim ([OznakaTima],[NazivProjekta],[OpisProjekta],[Napomena]) VALUES ('T04','Aplikacija .NET','Aplikacija za testiranje','Srednja razina');

INSERT INTO Student ([Ime],[Prezime],[Status],[OdabraniModel],[Email],[Napomena],[TimId]) VALUES ('Pero','Peric','I','A','pperic@foi.hr','Odabrao model A',2);
INSERT INTO Student ([Ime],[Prezime],[Status],[OdabraniModel],[Email],[Napomena],[TimId]) VALUES ('Ivo','Ivic','I','A','iivic@foi.hr','Odabrao model A',2);
INSERT INTO Student ([Ime],[Prezime],[Status],[OdabraniModel],[Email],[Napomena],[TimId]) VALUES ('Ana','Horvat','R','A','ahorvat@foi.hr','-',2);
INSERT INTO Student ([Ime],[Prezime],[Status],[OdabraniModel],[Email],[Napomena],[TimId]) VALUES ('Iva','Horvat','R','A','ihorvat@foi.hr','-',2);
INSERT INTO Student ([Ime],[Prezime],[Status],[OdabraniModel],[Email],[Napomena],[TimId]) VALUES ('Petar','Novak','R','A','pnovak@foi.hr','-',3);
INSERT INTO Student ([Ime],[Prezime],[Status],[OdabraniModel],[Email],[Napomena],[TimId]) VALUES ('Petar','Preradoviæ','R','A','ppreradovic@foi.hr','-',3);
INSERT INTO Student ([Ime],[Prezime],[Status],[OdabraniModel],[Email],[Napomena],[TimId]) VALUES ('Iva','Ivanoviæ','R','A','iivanovic@foi.hr','-',3);
INSERT INTO Student ([Ime],[Prezime],[Status],[OdabraniModel],[Email],[Napomena],[TimId]) VALUES ('Josip','Jurko','I','A','mail@mail.com','-',4);
INSERT INTO Student ([Ime],[Prezime],[Status],[OdabraniModel],[Email],[Napomena],[TimId]) VALUES ('Igor','Igric','R','A','igor@igric.hr','-',4);

INSERT INTO TipAktivnosti ([Tip]) VALUES ('Kolokvij');
INSERT INTO TipAktivnosti ([Tip]) VALUES ('Vježbe');

INSERT INTO Aktivnost ([Naziv],[MaxBodovi],[UvjetPotpis],[UvjetOcjena],[Pocetak],[Kraj],[Opis],[TipAktivnostiId]) VALUES ('Kolokvij 1',15,7,7,'2017-05-11 00:00:00','2017-05-22 00:00:00','Prvi kolokvij iz PI-a',1);
INSERT INTO Aktivnost ([Naziv],[MaxBodovi],[UvjetPotpis],[UvjetOcjena],[Pocetak],[Kraj],[Opis],[TipAktivnostiId]) VALUES ('Kolokvij 2',15,7,7,'2017-06-22 00:00:00','2017-06-22 00:00:00','Drugi kolokvij iz PI-a',1);

INSERT INTO AktivnostStudenta ([AktivnostId],[StudentId],[Bodovi],[Datum]) VALUES (1,2,8,'2017-05-12 00:00:00');
