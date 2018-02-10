// WerkDto
function WerkDto(ID, Name,Ort,Abteilung){

   // Add object properties like this
   this.ID = ID;
   this.Name = Name;
   this.Ort = Ort;
   //Fill the Abteilung Array
   this.Abteilungen = [];
   Abteilung.forEach(function(element)
   {
	    
	   	var obj = new AbteilungDto(element.ID,element.Name,element.Fachbereich,element.WerkName,element.User,element.Fertigungen);
	    this.Abteilungen.push(obj);
   },this);
}

//AbteilungDto
function AbteilungDto(ID,Name,Fachbereich,WerkName,User,Fertigung)
{
	this.ID = ID;
	this.Name = Name;
	this.Fachbereich = Fachbereich;
	this.WerkName = WerkName;
	this.Fertigungen = [];
	   Fertigung.forEach(function(element)
	   {
			var obj = new FertigungDto(element.ID,element.Name,element.AbteilungName,element.Fertigungslinien);
			this.Fertigungen.push(obj);
	   },this);
	this.Users = [];
	   User.forEach(function(element)
	   {
			var obj = new UserDto(element.ID,element.Title,element.FirstName,element.FamilyName,element.eMail,element.Phone,element.Mobile,element.AbteilungName,element.WerkName);
			this.Users.push(obj);
	   },this);
	
}

function FertigungDto(ID,Name,AbteilungName,Fertigungslinien)
{
	this.ID = ID;
	this.Name = Name;
	this.AbteilungName = AbteilungName;
	this.Fertigungslinien = [];
	   Fertigungslinien.forEach(function(element)
	   {
			var obj = new FertigungslinieDto(element.ID,element.Name,element.FertigungName,element.Werkstuecktraeger,element.Maschinen);
			this.Fertigungslinien.push(obj);
	   },this);
}

function FertigungslinieDto(ID,Name,FertigungName,Werkstuecktraeger,Maschinen)
{
	this.ID = ID;
	this.Name = Name;
	this.FertigungName = FertigungName;
	this.Werkstuecktraeger = [];
	if(Werkstuecktraeger != null)
	{
	   Werkstuecktraeger.forEach(function(element)
	   {
			this.Werkstuecktraeger.push(element);
	   },this);
	};
      this.Maschinen = [];
	   Maschinen.forEach(function(element)
	   {
			var obj = new MaschineDto(element.ID,element.InventarNummer,element.Zeichnungsnummer,element.Status,element.Type,element.Hersteller,element.Baujahr,element.Garantie);
			this.Maschinen.push(obj);
	   },this);
}

function MaschineDto(ID,InventarNummer,Zeichnungsnummer,Status,Type,Hersteller,Baujahr,Garantie)
{
	this.ID = ID;
	this.InventarNummer = InventarNummer;
	this.Zeichnungsnummer = Zeichnungsnummer;
	this.Status = Status;
	this.Type = Type;
	this.Hersteller = Hersteller;
	this.Baujahr = Baujahr;
	this.Garantie = Garantie;
}

function ReparaturDto(ID,Start,Dauer,Status,User,InventarNummer,Zeichnungsnummer)
{
	this.ID = ID;
	this.Start = Start;
	this.Dauer = Dauer;
	this.Status = Status;
	this.InventarNummer = InventarNummer;
	this.Zeichnungsnummer = Zeichnungsnummer;
	this.User = new UserDto(User.ID,User.Title,User.FirstName,User.FamilyName,User.eMail,User.Phone,User.Mobile,User.AbteilungName,User.WerkName);
}

function WartungDto(ID,WartungsInterval,Status,Beschreibung,User,InventarNummer,Zeichnungsnummer)
{
	this.ID = ID;
	this.WartungsInterval = WartungsInterval;
	this.Status = Status;
	this.Beschreibung = Beschreibung;
	this.InventarNummer = InventarNummer;
	this.Zeichnungsnummer = Zeichnungsnummer;
	this.User = new UserDto(User.ID,User.Title,User.FirstName,User.FamilyName,User.eMail,User.Phone,User.Mobile,User.AbteilungName,User.WerkName);
}

function UserDto(ID,Title,FirstName,FamilyName,eMail,Phone,Mobile,AbteilungName,WerkName)
{
	this.ID = ID;
	this.Title = Title;
	this.FirstName = FirstName;
	this.FamilyName = FamilyName;
	this.eMail = eMail;
	this.Phone = Phone;
	this.Mobile = Mobile;
	this.AbteilungName = AbteilungName;
	this.WerkName = WerkName;
}