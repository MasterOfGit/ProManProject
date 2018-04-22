//Ersteller : Markus Kessler	
//MatrNr 	  : 894361
//Presentation: 28.04.2018
//Team : ProMan
// modifikations : Sebastian Molkenthin
// MartNr : 896734

var xhttp;
var apiadress;
var adminphpadress;
var jsondatapath;
xhttp = new XMLHttpRequest();
//apiadress = "http://localhost:50435/api/";
//adminphpadress = "http://localhost:8080/lib/php/admin/";
//jsondatapath = "http://localhost:8080/jsonData/";
apiadress = "http://zoomnation.selfhost.eu:8080/ProManApi/api/";
adminphpadress = "http://zoomnation.selfhost.eu:80/lib/php/admin/";
jsondatapath = "http://zoomnation.selfhost.eu:80/jsonData/";

//function loadData(url, cFunction) {
//  "use strict";
//	
//	//console.log("URL : " + url);
//	//console.log("cFunction : " + cFunktion);
//   xhttp.onreadystatechange = function() {
//	  
//   if (this.readyState === 4 && this.status === 200) {
//			cFunction();	
//	   		//alert("Server loadData Anwort:" + xhttp.responseText);
//			
//		}
//		if (this.readyState === 4 && this.status === 204) {
//			alert("Server loadData schickt keine Anwort:");
//			
//		}
//  };
//  xhttp.open("GET", url, true);
//  xhttp.send();
//	
//}
//
//function saveData(url, data) {
//	"use strict";
//	
//	//console.log("URL : " + url);
//	//console.log("Data : " + data);
//
//	xhttp.onreadystatechange = function () {
//		//alert("readyState: " + this.readyState);
//		//alert("status: " + this.status);
//
//		if (this.readyState === 4 && this.status === 200) {
//			alert("Server saveData Anwort:" + xhttp.responseText);
//			
//			}
//		if (this.readyState === 4 && this.status === 204) {
//			alert("Server saveData schickt keine Anwort:");
//			
//		}
//	};
//	xhttp.open("POST", url, true);
//	xhttp.setRequestHeader("Content-type", "application/json");
//	xhttp.send(data);
//	//alert("Save User Data");
//}

//General function to open the edit page
function OpenEditPage(urlpart,systemstatus)
{
	"use strict";
	//alert("OpenEditPage with url path: "+urlpart);
	var url = adminphpadress+urlpart;

	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#daten").html(xhttp.responseText);
			$("#systemstatus").html(systemstatus);


		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};
	xhttp.open("GET", url, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();
	$("#systemstatus").html(systemstatus);
}


//region Execute functions DB

////////////////////////////////
//	Execute functions DB	´ //
////////////////////////////////

//General function to create an entry in the db
function ExecuteCreateActionDb(urlpart,data)
{
	alert("ExecuteCreateActionDb with url path: "+urlpart);
	var url = apiadress+urlpart;

	//alert(url);
	//alert(data);
	
	xhttp.onreadystatechange = function () {
/* 		alert("readyState: " + this.readyState);
		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html(xhttp.responseText);

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
		if (this.status === 500) {
			alert(xhttp.responseText);
		}
		if (this.status === 400) {
			alert(xhttp.responseText);
		} */
	};





	xhttp.open("POST", url, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data);

	$("#systemstatus").html("Neues Element wurde hinzugefügt !");
}

//General function to update an entry from the db by the id
function ExecuteUpdateActionDb(urlpart,data,id)
{
	"use strict";
	var url = apiadress+urlpart+"/"+id;
//	alert(url)
	xhttp.onreadystatechange = function () {
//		alert("readyState: " + this.readyState);
//		alert("status: " + this.status);

		//if (this.readyState === 4 && this.status === 200) {
		//	$("#systemstatus").html("Mendungen" + xhttp.responseText);

//		}
//		if (this.readyState === 4 && this.status === 204) {
//			alert("Server saveData schickt keine Anwort:");
//
//		}
	};

	xhttp.open("PUT", url, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data);

	$("#systemstatus").html("Element wurde geupdatet !");
}

//General function to delete an entry from the db by the id
function ExecuteDeleteActionDb(urlpart,id)
{
	"use strict";
	
	var url = apiadress+urlpart+"/"+id;


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html("Bestehendes Audit wurde geaendert !");

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveAudit schickt keine Anwort:");

		}
	};

	xhttp.open("DELETE", url, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();

}

//General function to delete an entry from the db by the id
function ExecuteDeleteActionDbSingle(urlpart)
{
	"use strict";
	
	var url = apiadress+urlpart;

	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		//if (this.readyState === 4 && this.status === 200) {
		//	$("#systemstatus").html("Bestehendes Audit wurde geaendert !");

		//}
		//if (this.readyState === 4 && this.status === 204) {
		//	alert("Server saveAudit schickt keine Anwort:");
		//
		//}
	};

	xhttp.open("DELETE", url, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();
}

//endregion

//region functions JSon

////////////////////////////////
//	Execute functions JSon	´ //
////////////////////////////////

function ExecuteCreateActionJson(urlpart,data,systemstatus)
{
	var url = jsondatapath+urlpart;

	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html(systemstatus);

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveAudit schickt keine Anwort:");
			$("#systemstatus").html(systemstatus);

		}
	};

	xhttp.open("GET", url, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();
}

//endregion


//region User Menue

///////////////////////////////
// registriere User Menue
///////////////////////////////
function changeRegistUser(UserID) {
	"use strict";
	OpenEditPage("User/adminCRUserBearbeiten.php?q=" + UserID,"Editiere User");
}

function saveUserData(data) {
	"use strict";
	var url_userdata = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Userdata";

	//var data_userdata = JSON.stringify({
	//			"userAnrede"	:	"Herr",
	//		 	"userVorname"	:	"Markus",
	//		 	"userNachname"	:	"Kessler",
	//		 	"userPosition"	: 	"Administrator",
	//		 	"userBild"		: 	"/user/Bilder/1253.pnp",
	//		 	"userLand"		: 	"Deutschland",
	//		 	"userWerk"		: 	"Werk_1",
	//		 	"userAbteilung"	:	"1788_2",
	//		 	"userEmail"		:	"mk@proman.de",
	//		 	"userFestnetzNr":	"0561/123456",
	//		 	"userMobilNr"	:	"0171/123456",
	//		 	"userBemerkung"	:	"keine"
	//				});

	var data_userdata = data;

	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html("User gesichert !" + xhttp.responseText);

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};

	// ein user wir ein User ohne zugewiesene UserID abgespeichert

	xhttp.open("POST", url_userdata, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data_userdata);

	$("#systemstatus").html("User gesichert !");
}

function changeUnMessageRegUser(userID, email) {
	"use strict";
}

///////////////////////////////
// nicht registriere User Menue
///////////////////////////////

function changeNewRegistUser(UserID) {
	"use strict";
	//alert("changeRegistUser UserID: " + UserID);
	OpenEditPage("User/adminCRUserRegistrierungBearbeiten.php?q=" + UserID,"Editiere neu registierten User");
}


function saveNewRegistrierung(data) {
	"use strict";
	var url_userdata = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Userdata";
	alert("Create User");
	alert(data);
/* 	var data_userdata = JSON.stringify({
		"userAnrede": "Herr",
		"userVorname": "Markus",
		"userNachname": "Kessler",
		"userPosition": "Administrator",
		"userBild": "/user/Bilder/1253.pnp",
		"userLand": "Deutschland",
		"userWerk": "Werk_1",
		"userAbteilung": "1788_2",
		"userEmail": "mk@proman.de",
		"userFestnetzNr": "0561/123456",
		"userMobilNr": "0171/123456",
		"userBemerkung": "keine"
	});

	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html("Mendungen" + xhttp.responseText);

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};

	// ein user wir ein User ohne zugewiesene UserID abgespeichert

	xhttp.open("POST", url_userdata, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data_userdata);

	$("#systemstatus").html("Neuer User wurde bearbeitet  !"); */



}

//endregion

///////////////////////////////
// registrierung von Admin bearbeiten
///////////////////////////////

function saveRegistrierung(email) {
	"use strict";
	var url_userdata = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Userdata";
	var url_userlogin = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Userlogin";

	var data_userdata = JSON.stringify({
		"userID": "1253",
		"userAnrede": "Herr",
		"userVorname": "Markus",
		"userNachname": "Kessler",
		"userPosition": "Administrator",
		"userBild": "/user/Bilder/1253.pnp",
		"userLand": "Deutschland",
		"userWerk": "Werk_1",
		"userAbteilung": "1788_2",
		"userEmail": "mk@proman.de",
		"userFestnetzNr": "0561/123456",
		"userMobilNr": "0171/123456",
		"userBemerkung": "keine"
	});

	var data_userlogin = JSON.stringify({
		"userID": "1253",
		"userLastLogin": "17-05-2018",
		"userStatus": true,
		"userbereich": "Administrator",
		"userKennung": "dvc1253a",
		"userpasswort": "pw"
	});

	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html("Mendungen" + xhttp.responseText);

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};
	// hier werden Userdata und UserLogin über die eindeutige UserID verbunden

	// Post Userdata
	xhttp.open("POST", url_userdata, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data_userdata);

	// Post Userlogin
	xhttp.open("POST", url_userlogin, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data_userlogin);

	$("#daten").html("<div class='daten'><div class='jumbotron'><div class='container'><h2>Wir bedanken uns für ihre Registrierung</h2><p>Der Administrator wird ihren Registrierungswunsch bearbeiten.Nach Abschluss erhalten sie ihre Login Daten per eMail.Bei weiteren Fragen kontaktieren sie mich bitte über das Kontaktformular im Bereich Kontakte.MFG Markus Kessler <br><a class='btn btn-primary btn-lg' href='start.html' role='button'>Zum Start</a></p></div></div></div>");
}

//region Bauteil


///////////////////////////////
// Bauteil Menue
///////////////////////////////
function editBauteil(bauteilID) {
	"use strict";
	alert(bauteilID);
	OpenEditPage("Bauteil/adminCRBauteilBear.php?q="+bauteilID,"Bauteil editiert");
}

function saveBauteil(data) {
	
	"use strict";
	ExecuteCreateActionDb("bauteil",data);
	//ExecuteCreateActionJson("bauteile/saveBauteilJsonDatei.php",data,"Bauteile Json Datei wurde gespeichert  !");
	$("#systemstatus").html("Neues Bauteil wurde bearbeitet  !");
}

function updateBauteil(data,id) {
	
	"use strict";
	alert("updateBauteil");
	ExecuteUpdateActionDb("bauteil",data,id);
	$("#systemstatus").html("Bauteil wurde geupdatet  !");
}

function editBauteilVerwendung(bauteilID) {
	"use strict";
	OpenEditPage("Bauteil/adminCRBauteilVerwBear.php?q="+bauteilID,"Bauteilverwendung editiert");
}

function saveBauteilVerwendung(data) {
	"use strict";
	
	alert("Datentranfer : " + data);
	
	var url_bauteilVerwendung = "http://zoomnation.selfhost.eu/jsonData/bauteile/bauteileVerwendung.json";
	
	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html("Mendungen" + xhttp.responseText);

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};

	// ein user wir ein User ohne zugewiesene UserID abgespeichert

	xhttp.open("POST", url_bauteilVerwendung, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data);

	$("#systemstatus").html("Neuer Bauteilverwendung wurde bearbeitet!");

}

//endregion

//region Maschine

///////////////////////////////
// Maschine Menue
///////////////////////////////

function editMaschine(maschineID) {
	"use strict";
	OpenEditPage("Maschine/adminCRMaschineBear.php?q="+maschineID,"Maschine editiert");
}

function saveMaschine(data) {
	
	"use strict";
	//var rawdata = JSON.parse(data);
	ExecuteCreateActionDb("maschine",data);			


}

function updateMaschine(data,id) {
	
	"use strict";
	alert("Start Update")
	ExecuteUpdateActionDb("maschine",data,id);
}

function editMaschineVerwendung(maschineID) {
	
	"use strict";
	OpenEditPage("Maschine/adminCRMaschineVerwBear.php?q="+maschineID,"Maschineverwendung editiert");
}

function saveMaschineVerwendung(data) {
	
	"use strict";
	ExecuteCreateActionDb("maschine",data);		
	ExecuteCreateActionJson("maschine/maschineVerwendung.json",data,"Neuer Maschineverwendung wurde bearbeitet!")
}

//endregion

//region Fertigungslinie


///////////////////////////////
// Fertigungslinie Menue  
///////////////////////////////

function editNewArbeitsfolgeInFertigunglinie(fertigungslinieID) {
	"use strict";
	OpenEditPage("Fertigungslinie/adminCRNeuArbeitsfolgeFertigungslinie.php?q="+fertigungslinieID,"Arbeitsfolge von Fertigungslinie editiert");
}

function editArbeitsfolgeFertigungs(fertigungslinieID){
<<<<<<< HEAD
	"use strict";
	OpenEditPage("Abteilung/adminCRNeuArbeitsfolgeFertigungslinie.php?q="+fertigungslinieID,"Arbeitsfolge der Fertigungslinie hinzufügen");
}

function addArbeitsfolgeFertigungs(fertigungslinieID,arbeitsfolgeID){
	"use strict";
=======
	"use strict";
	OpenEditPage("Abteilung/adminCRNeuArbeitsfolgeFertigungslinie.php?q="+fertigungslinieID,"Arbeitsfolge der Fertigungslinie hinzufügen");
}

function addArbeitsfolgeFertigungs(fertigungslinieID,arbeitsfolgeID){
	"use strict";
>>>>>>> bd0714b7c6e1179fd876c5fd07ddc93702ea23aa
	ExecuteCreateActionDb("addgetdeleteobject?type=Fertigungslinie&parent="+fertigungslinieID+"&id="+arbeitsfolgeID,"Arbeitsfolge der Fertigungslinie hinzufügen");
}


function SaveNewArbeitsfolgeInFertigunglinie(data) {
	
	"use strict";
	
	ExecuteCreateActionDb("arbeitsfolge",data);	

	//var url_bauteil = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Fertigungslinie";


/* 	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html("Mendungen" + xhttp.responseText);

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};

	// TODO : Fertigungslinie muss vor dem speicher ermittelt werden

	xhttp.open("POST", url_bauteil, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data);

	$("#systemstatus").html("Neuer Arbeitsfolgein Fertigungslinie wurde angelegt  !"); */
}

function moveArbeitsfolgeFertigungslinien(FertigungslinienID, vonArbeitsfolgeID) {
	"use strict";
	
	var nachArbeitsfolgeID = prompt("An welche position soll diese Arbeitfolge verschoben werden ?", "5");
	alert("Feritungslinie : " + FertigungslinienID + " vonArbeitsfolgeID : " + vonArbeitsfolgeID + "  nachArbeitsfolgeID : " + nachArbeitsfolgeID );
	}

function deleteArbeitsfolgeFertigungslinien(FertigungslinienID, vonArbeitsfolgeID) {
	"use strict";
	
	ExecuteDeleteActionDbSingle("addgetdeleteobject?type=Fertigungslinie&parent="+FertigungslinienID+"&id="+vonArbeitsfolgeID);	
	}

function saveFertigungslinie() {
	"use strict";
	alert("Alle Fertigungslinein gespeichern");
}

function newFertigungslinie() {
	"use strict";
	OpenEditPage("Fertigungslinie/adminCRFertigungslinieCreate.php","Fertigungslinie erstellen");
}

function createFertigungslinie(data)
{
	"use strict";
	ExecuteCreateActionDb("fertigungslinie",data);
}

function createFertigungslinienGrafik(FertigungslinienID) {
	"use strict";
}

//endregion



///////////////////////////////
// Fertigung Menue  
///////////////////////////////
function editFertigung(fertigungsID) {
	
	"use strict";
	OpenEditPage("Fertigung/adminCRNewFertigunglinieFertigung.php?q="+fertigungsID,"Fertigungslinie in Fertigung editiert");
}

function editFertigungAbteilung(fertigungsID){
	"use strict";
	OpenEditPage("Abteilung/adminCRNewFertigunglinieFertigung.php?q="+fertigungsID,"Fertigungslinie der Fertigung hinzufügen");
}

function addFertigungslinieFertigung(fertigungsID,fertigungslinie){
	"use strict";
	ExecuteCreateActionDb("addgetdeleteobject?type=Fertigung&parent="+fertigungsID+"&id="+fertigungslinie,"Fertigungslinie der Fertigung hinzufügen");
}

function saveFertigung(data, fertigungsID) {
	
	"use strict";
	
	alert("Datentranfer : " + data);
	alert("Datentranfer : " + fertigungsID);
	
	var url_bauteil = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Fertigung";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html("Mendungen" + xhttp.responseText);

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};

	// TODO : Fertigung muss vor dem speicher ermittelt werden

	xhttp.open("POST", url_bauteil, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data);

	$("#systemstatus").html("Neuer Fertigungslinie in Fertigung wurde angelegt  !");
}

function newFertigung() {
	"use strict";
	OpenEditPage("Fertigung/adminCRFertigungCreate.php","Fertigung erstellen");
}

function createFertigung(data)
{
	"use strict";
	ExecuteCreateActionDb("fertigung",data);
}

function deleteFertigung(fertigungsID) {
	"use strict";
	alert("Datentranfer : " + fertigungsID);
}

function deleteFertigungslinieFertigung(fertigungsID,fertigungslinieID) {
	
	"use strict";
	ExecuteDeleteActionDbSingle("addgetdeleteobject?type=Fertigung&parent="+fertigungsID+"&id="+fertigungslinieID);	
}

function saveFertigungen() {
	"use strict";
	alert("Save Fertigung");
}

function createFertigungGrafik(fertigungsID) {
	"use strict";
	
	alert("Datentranfer : " + fertigungsID);
}


///////////////////////////////
// Abteilungen Menue  
///////////////////////////////

// Abteilung Menue
function editAbteilung(abteilungsID) {
	"use strict";
	OpenEditPage("Abteilung/adminCRFertigungAbteilung.php?q="+abteilungsID,"Fertigung in Abteilung editiert");
}

function editFertigungAbteilung(abteilungsID){
	"use strict";
	OpenEditPage("Abteilung/adminCRFertigungAbteilung.php?q="+abteilungsID,"Fertigung der Abteilung hinzufügen");
}

function addFertigungAbteilung(abteilungsID,fertigungsID){
	"use strict";
	ExecuteCreateActionDb("addgetdeleteobject?type=Abteilung&parent="+abteilungsID+"&id="+fertigungsID,"Fertigung der Abteilung hinzufügen");
}

function saveAbteilung(data, abteilungsID) {
	"use strict";
	
	alert("Datentranfer : " + data);
	alert("Datentranfer : " + abteilungsID);
	
	var url_bauteil = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Abteilung";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html("Mendungen" + xhttp.responseText);

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};

	// TODO : Abteilung muss vor dem speicher ermittelt werden

	xhttp.open("POST", url_bauteil, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data);

	$("#systemstatus").html("Neuer Fertigung in Abteilung wurde angelegt  !");
}

function newAbteilung() {
	"use strict";
	OpenEditPage("Abteilung/adminCRAbteilungCreate.php","Abteilung erstellen");
}


function createAbteilung(data)
{
	"use strict";
	ExecuteCreateActionDb("abteilung",data);
}


function deleteAbteilung(AbteilungsID) {
	
	"use strict";
	alert("Datentranfer : " + AbteilungsID);
	
}

function deleteFertigungAbteilung(abteilungsID,fertigungsID) {
	
	"use strict";
	ExecuteDeleteActionDbSingle("addgetdeleteobject?type=Abteilung&parent="+abteilungsID+"&id="+fertigungsID);	
}

function saveAbteilungen() {
	
	"use strict";
	alert("Alle Abteilung wurde gespeichert");
}

function createAbteilungGrafik() {
	"use strict";
}



///////////////////////////////
// Instandhaltung Menue  
///////////////////////////////


function editReperaturAuftrag(reperaturauftragID) {
	"use strict";
	OpenEditPage("Instandhaltung/adminCRFertigungAbteilung.php?q="+reperaturauftragID,"Fertigung in Abteilung editiert");
}

function saveReperaturAuftrag(data, ReperaturauftragID) {
	"use strict";
	
	alert("Datentranfer : " + data);
	alert("Datentranfer : " + ReperaturauftragID);
	
	var url_bauteil = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Reperaturauftrag";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html("Mendungen" + xhttp.responseText);

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};

	// TODO : Reperaturauftrag muss vor dem speicher ermittelt werden

	xhttp.open("POST", url_bauteil, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data);

	$("#systemstatus").html("Reperaturauftrag wurde gespeichert  !");
}

function acceptReperaturAuftrag(ReperaturauftragID) {
	"use strict";
	alert("Datentranfer : " + ReperaturauftragID);
	alert("Reperaturauftrag wurde in den Status inArbeit gesetzt");
}

function deleteReperaturAuftrag(ReperaturauftragID) {
	"use strict";
	alert("Datentranfer : " + ReperaturauftragID);
	alert("Reperaturauftrag wurde in den gelöscht");
}


function saveNewReperaturAuftrag(data) {

	"use strict";
	ExecuteCreateActionDb("reparatur",data);	
	$("#systemstatus").html("Reperaturauftrag wurde gespeichert  !");
}


///////////////////////////////
// Produktionsplanung Menue  
///////////////////////////////


function editProduktionplanSchritt() {
	"use strict";

	//TODO
	//"Produktionsplanung/adminCRNewSchrittProduktionsplan.php?q=0"+reperaturauftragID
	OpenEditPage("Produktionsplanung/adminCRNewSchrittProduktionsplan.php?q=0"+reperaturauftragID,"Produktionslan editiert");
}

function saveProduktionplanSchritt(data) {
	
	
	"use strict";
	
	
	var url_bauteil = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Produktionsplan";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html("Mendungen" + xhttp.responseText);

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};

	// TODO : Reperaturauftrag muss vor dem speicher ermittelt werden

	xhttp.open("POST", url_bauteil, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data);

	$("#systemstatus").html("Neue Produktionmenge wurde gespeichert  !");
	
}

function moveProduktionplanSchritte(vonSchritt) {
	
	"use strict";
	var nachSchritt = prompt("An welche position soll diese Produktionsmenge verschoben werden ?", vonSchritt);
	alert("Produktionsmenge : " +  " vonSchritt : " + vonSchritt + "  nachSchritt : " + nachSchritt );
}

function deleteProduktionplan(folgenummer) {
	"use strict";
	alert("Datentransfer : " + folgenummer);
	alert("Produktionsmenge wurde gelöscht");
}

function changeSchrittStatusProduktionplan(folgenummer) {
	
	"use strict";
	var status = prompt("In welchen Status soll die Produktionsmende versetzt werden", "erlegigt");
	alert("Produktionsmengeschritt : " +  " folgenummer : " + folgenummer + "  neuer Status  : " + status );
	alert("Produktionsmenge (Status) wurde ggeändert");
	
}

function saveProduktionplan() {
	
	"use strict";
	alert("Neue Produktionsmenge wurde gespeichert");
}

///////////////////////////////
// lagerort Menue  
///////////////////////////////

function editLagerort(lagerort) {
	"use strict";
	OpenEditPage("Produktionsplanung/adminCRLagerortBear.php?q=0"+lagerort,"Lager editiert");
}

function saveLagerort(data){
		
	"use strict";
	
	
	var url_bauteil = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Lagerort";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html("Mendungen" + xhttp.responseText);

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};

	// TODO : Reperaturauftrag muss vor dem speicher ermittelt werden

	xhttp.open("POST", url_bauteil, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data);

	$("#systemstatus").html("Neue Lagerort wurde gespeichert  !");
	
}

function deleteLagerort(LagerortID) {
	
	"use strict";
	alert("datentransfer : " + LagerortID);
	alert("Lagerorte wurden gespeichert");
}

function saveAllLagerort() {
	
	"use strict";
	alert("Alle Lagerorte wurden gespeichert");
	
}




///////////////////////////////
// Sonderaufgaben Menue  
///////////////////////////////

function editWartung(wartungsID) {

	"use strict";
	OpenEditPage("Sonderaufgaben/adminCRWartungBear.php?q="+wartungsID,"Wartung editiert");
}

function saveWartung(data, zugriff, id){
		
	alert("Zugriff:"+zugriff);
	if(zugriff == 0)
	{
		ExecuteCreateActionDb("wartung",data);
	}
	///////////////////////////////
	//Uptdate Audit in Datenbank
	///////////////////////////////
	if(zugriff == 1) 
	{
		ExecuteUpdateActionDb("wartung",data,id);
	}

			
	///////////////////////////////////
	// Daten  in Json Datei speichern 
	///////////////////////////////////
/* 	var url_wartung = "http://zoomnation.selfhost.eu/lib/php/admin/Sonderaufgaben/saveWartungJsonDatei.php";

	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html("Wartung Json Datei wurde gespeichert  !");

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveAudit schickt keine Anwort:");
			$("#systemstatus").html("Wartung Json Datei wurde gespeichert  !");

		}
	};

	xhttp.open("GET", url_wartung, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(); */

	
	
}

function deleteWartung(wartungsID) {
	
	"use strict";
	ExecuteDeleteActionDb("wartung",wartungsID);
}

function moveWartungDatum(wartungsID) {
	
	"use strict";
	alert("datentransfer : " + wartungsID);
	var neuesDatum = prompt("Auf welches Datum wollen sie die Wartung verschieben ? ", "10.10.2018");
	alert("Wartungsdatum : " +  " neues Datum : " + neuesDatum );
}

function aenderWartungStatus(wartungsID) {
	
	"use strict";
	alert("datentransfer : " + wartungsID);
	var neuStatus = prompt("Welchen Status soll die Wartung erhalten ?", "erledigt");
	alert("Wartungsstatus : " +  " Neuer Staus : " + neuStatus);
}

function saveAllWartungen() {
		
	"use strict";
	alert("Alle Wartungen wurden gespeichert");
	
}






function editAudit(AuditID) {
	"use strict";
	OpenEditPage("Sonderaufgaben/adminCRAuditsBear.php?q="+AuditID,"Audit editiert");
}

function saveAudit(data, zugriff){
	
	if(zugriff == 0)
	{
		ExecuteCreateActionDb("audit",data);
	}
	///////////////////////////////
	//Uptdate Audit in Datenbank
	///////////////////////////////
	if(zugriff == 1) 
	{
		ExecuteUpdateActionDb("audit",data,data["auditId"]);
	}
		
	/* ///////////////////////////////////
	// Daten  in Json Datei speichern 
	///////////////////////////////////
	var url_audit = "http://zoomnation.selfhost.eu/lib/php/admin/Sonderaufgaben/saveAuditJsonDatei.php";

	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#systemstatus").html("Audit Json Datei wurde gespeichert  !");

		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveAudit schickt keine Anwort:");
			$("#systemstatus").html("Audit Json Datei wurde gespeichert  !");

		}
	};

	xhttp.open("GET", url_audit, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(); */

	
	
}

function deleteAudit(auditID) {
	
	"use strict";
	ExecuteDeleteActionDb("audit",auditID);
}

function moveAuditDatum(auditID) {
	
	"use strict";
	alert("datentransfer : " + auditID);
	var neuesDatum = prompt("An welche position soll diese Produktionsmenge verschoben werden ?", 1);
	alert("Produktionsmenge : " +  " vonSchritt : "  + neuesDatum );
}

function aenderAuditStatus(status) {
	
	
	"use strict";
	var neuerStatus = prompt("An welche position soll diese Produktionsmenge verschoben werden ?", "erledigt");
	alert("Produktionsmenge : " +  " vonSchritt : " + neuerStatus );
}

function saveAllAudit() {
	
	"use strict";
	alert("Alle Lagerorte wurden gespeichert");
	
}

////////////////////////////////
//				TEST		´ //
////////////////////////////////1
// user button functions
function testbuttonaction(userid) {
	"use strict";
	alert("Der User :" + userid + "wurde ausgewählt");
}

function testbuttondata(data) {
	"use strict";
	alert("Datenempfang : " + data);

	//for(var key in data)
//		{
//		var value = data[key];	
//		document.write(key + " = " + value + '<br>');
//		}
	
	//alert("Data : " + data["text1"].val );
}








