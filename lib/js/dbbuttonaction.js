var xhttp;
xhttp = new XMLHttpRequest();

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

///////////////////////////////
// registriere User Menue
///////////////////////////////
function changeRegistUser(UserID) {
	"use strict";
	//alert("changeRegistUser UserID: " + UserID);

	var url_userdata = "http://zoomnation.selfhost.eu:80/lib/php/admin/User/adminCRUserBearbeiten.php";

	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#daten").html(xhttp.responseText);
			//$("#daten").html("Hallo");


		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server changeRegistUser schickt keine Anwort:");

		}
	};

	// ein user wir ein User ohne zugewiesene UserID abgespeichert
	var querystring = url_userdata + "?q=" + UserID;
	//alert(querystring);
	xhttp.open("GET", querystring, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();

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

///////////////////////////////
// nicht registriere User Menue
///////////////////////////////

function changeNewRegistUser(UserID) {
	"use strict";
	//alert("changeRegistUser UserID: " + UserID);

	var url_userdata = "http://zoomnation.selfhost.eu:80/lib/php/admin/User/adminCRUserRegistrierungBearbeiten.php";

	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#daten").html(xhttp.responseText);
			//$("#daten").html("Hallo");


		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server changeRegistUser schickt keine Anwort:");

		}
	};

	// ein user wir ein User ohne zugewiesene UserID abgespeichert
	var querystring = url_userdata + "?q=" + UserID;
	//alert(querystring);
	xhttp.open("GET", querystring, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();

}


function saveNewRegistrierung(data) {
	"use strict";
	var url_userdata = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Userdata";

	var data_userdata = JSON.stringify({
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

	$("#systemstatus").html("Neuer User wurde bearbeitet  !");



}

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


///////////////////////////////
// Bauteil Menue
///////////////////////////////
function editBauteil(bauteilID) {
	"use strict";
	var url = "http://zoomnation.selfhost.eu/lib/php/admin/Bauteil/adminCRBauteilBear.php?q=";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#daten").html(xhttp.responseText);
			$("#systemstatus").html("Bauteil editiert");


		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};
	xhttp.open("GET", url + bauteilID, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();

	$("#systemstatus").html("Bauteil edit");
}

function saveBauteil(data) {
	"use strict";
	var url_bauteil = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Bauteile";

	var data_bauteil = JSON.stringify({

		"bauteileID": 1,

		"bauteinNummer": "120 150 115",

		"bauteilIndex": "A",

		"bauteilVersiom": "3.1",

		"bauteilArt": "Zahnrad",

		"bauteilStatus": "Serienteil",

		"bauteilIDNachfolger": null

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

	xhttp.open("POST", url_bauteil, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data_bauteil);

	$("#systemstatus").html("Neuer Bauteil wurde bearbeitet  !");

}

function editBauteilVerwendung(bauteilID) {
	"use strict";
	var url = "http://zoomnation.selfhost.eu/lib/php/admin/Bauteil/adminCRBauteilVerwBear.php?q=";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#daten").html(xhttp.responseText);
			$("#systemstatus").html("Bauteil editiert");


		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};
	xhttp.open("GET", url + bauteilID, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();

	$("#systemstatus").html("Bauteilverwendung edit");
}

function saveBauteilVerwendung(data) {
	"use strict";
		var url_bauteilVerwendung = "http://zoomnation.selfhost.eu/jsonData/bauteile/bauteileVerwendung.json";

	var data_bauteilVerwendung = JSON.stringify({

		"fertingungsLinienID": 10,

		"bauteileID": 1,

		"technologie": "Harddrehen",

		"bearbeitungen": "PlanF 10a",

		"bearbeitungsschritt": 7,

		"verwendungsZweck": "5Gang Getriebe"

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

	xhttp.open("POST", url_bauteilVerwendung, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data_bauteilVerwendung);

	$("#systemstatus").html("Neuer Bauteilverwendung wurde bearbeitet!");

}

///////////////////////////////
// Maschine Menue
///////////////////////////////

function editMaschine(maschineID) {
	"use strict";
	var url = "http://zoomnation.selfhost.eu/lib/php/admin/Maschine/adminCRMaschineBear.php?q=";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#daten").html(xhttp.responseText);
			$("#systemstatus").html("Maschine editiert");


		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};
	xhttp.open("GET", url + maschineID, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();

	$("#systemstatus").html("Maschine edit");
}

function saveMaschine(data) {
	"use strict";
	var url_bauteil = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Maschine";

	var data_bauteil = JSON.stringify({

		
			"maschinenID" :	1,

			"maschinenInventarNummer"	: "12355545",

			"hersteller"	:	"Scherrer",

			"technologie"	:	"Drehen",

			"standort"		:	"Werk1 Hall 5 Feld 10a",

			"abteilung"		:   "1755",

			"status"		:	"produktiv"


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

	xhttp.open("POST", url_bauteil, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data_bauteil);

	$("#systemstatus").html("Neuer Maschine wurde bearbeitet  !");

}

function editMaschineVerwendung(maschineID) {
	"use strict";
	var url = "http://zoomnation.selfhost.eu/lib/php/admin/Maschine/adminCRMaschineVerwBear.php?q=";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#daten").html(xhttp.responseText);
			$("#systemstatus").html("Bauteil editiert");


		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};
	xhttp.open("GET", url + maschineID, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();

	$("#systemstatus").html("Maschineverwendung edit");
}

function saveBauteilVerwendung(data) {
	"use strict";
	var url_bauteilVerwendung = "http://zoomnation.selfhost.eu/jsonData/maschine/maschineVerwendung.json";

	var data_bauteilVerwendung = JSON.stringify({

		
			"maschinenID"		:	1,

			"bauteileID"			:	4,

			"abteilungID"		:	11,

			"fertigungID"		:	8,

			"fertigungslinieID"	:	7,

			"arbeitsfolge"		:	3


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

	xhttp.open("POST", url_bauteilVerwendung, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data_bauteilVerwendung);

	$("#systemstatus").html("Neuer Mascineverwendung wurde bearbeitet!");

}




///////////////////////////////
// Fertigungslinie Menue  (inArbeit)
///////////////////////////////


function newArbeitsfolgeInFertigunglinie(fertigungslinieID) {
	"use strict";
	alert("Neue Arbeitsfolge in Fertigunglinie : " + fertigungslinieID);
}

function moveArbeitsfolgeFertigungslinien(FertigungslinienID, vonArbeitsfolgeID) {
	"use strict";
	
	var nachArbeitsfolgeID = prompt("An welche position soll diese Arbeitfolge verschoben werden ?", "5");
	alert("Feritungslinie : " + FertigungslinienID + " vonArbeitsfolgeID : " + vonArbeitsfolgeID + "  nachArbeitsfolgeID : " + nachArbeitsfolgeID );
	}

function deleteArbeitsfolgeFertigungslinien(FertigungslinienID, vonArbeitsfolgeID) {
	"use strict";
	
	alert("Arbeitsfolge in Feritungslinie : " + FertigungslinienID + " vonArbeitsfolgeID : " + vonArbeitsfolgeID + " wurde gelöscht" );
	}

function saveFertigungslinie() {
	"use strict";
	alert("Alle Fertigungslinein gespeichern");
}

function newFertigungslinie() {
	"use strict";
	alert("Neue Fertigungslinie erstellt");
}

function createFertigungslinienGrafik(FertigungslinienID) {
	"use strict";
}









////////////////////////////////
//				TEST		´ //
////////////////////////////////
// user button functions
function testbuttonaction(userid) {
	"use strict";
	alert("Der User :" + userid + "wurde ausgewählt");
}








////////////////////////////////
//				OFFEN		´ //
////////////////////////////////


// Usermenue

// haben eiene UserID
function changeRegisteruser(userID) {
	"use strict";
}
// können ev noch keine userID zugewiesen bekommen haben, daher userid ev null
function changeUnRegisteruser(userID, email) {
	"use strict";
}

function changeUnMessageRegUser(userID, email) {
	"use strict";
}

// Abteilung Menue
function newFertigungInAbteilung() {
	"use strict";
}

function saveAbteilung(AbteilungsID) {
	"use strict";
}

function resetAbteilung() {
	"use strict";
}

function deleteAbteilung(AbteilungsID) {
	"use strict";
}

function createAbteilungGrafik() {
	"use strict";
}

// Fertigung Menue
function newFertigunglinieInFertigung() {
	"use strict";
}

function saveFertigungen(FertigungsID) {
	"use strict";
}

function resetFertigung(FertigungsID) {
	"use strict";
}

function deleteFertigung(FertigungsID) {
	"use strict";
}

function createFertigungGrafik(FertigungsID) {
	"use strict";
}





// Maschine Menue

function createMaschine() {
	"use strict";
}

function changeMaschine(MaschinenID) {
	"use strict";
}

function deleteMaschine(MaschinenID) {
	"use strict";
}

function createVerwendungMaschie(MaschinenID) {
	"use strict";
}

function changeVerwendungMaschine(MaschinenID) {
	"use strict";
}

function deleteVerwendungMaschine(MaschinenID) {
	"use strict";
}




// Linkss für Akteilungsstatus 

function detailBauteiNummer() {
	"use strict";
}

// .....


// Linkss für Fertigungsstatus 

function detailReperaturenOffen() {
	"use strict";
}

// .....


// Instandhaltung Menue

function viewReperaturAuftrag(ReperaturauftragID) {
	"use strict";
}

function acceptReperaturAuftrag(ReperaturauftragID) {
	"use strict";
}

function deleteReperaturAuftrag(ReperaturauftragID) {
	"use strict";
}

function changeReperaturAuftrag(ReperaturauftragID) {
	"use strict";
}

function createReperaturAuftrag() {
	"use strict";
}

function moveReperaturAuftrag(ReperaturauftragID) {
	"use strict";
}

//Menue Produktionsplanung

function newProduktionplan() {
	"use strict";
}

function moveProduktionplan(ProduktionsplanID, vonSchritt, nachSchritt) {
	"use strict";
}

function deleteProduktionplan(ProduktionsplanID) {
	"use strict";
}

function changeProduktionplan(ProduktionsplanID) {
	"use strict";
}

function saveProduktionplan() {
	"use strict";
}

function newLagerort() {
	"use strict";
}

function changeLagerort(LagerortID) {
	"use strict";
}

function deleteLagerort(LagerortID) {
	"use strict";
}

function saveLagerort() {
	"use strict";
}
