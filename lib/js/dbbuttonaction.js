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

function changeUnMessageRegUser(userID, email) {
	"use strict";
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

	alert("Datentranfer : " + data);
	
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
	xhttp.send(data);

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
	
	alert("Datentranfer : " + data);
	
	var url_bauteil = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Maschine";


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
	xhttp.send(data);

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

function saveMaschineVerwendung(data) {
	
	"use strict";
	alert("Datentranfer : " + data);
	var url_bauteilVerwendung = "http://zoomnation.selfhost.eu/jsonData/maschine/maschineVerwendung.json";

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

	$("#systemstatus").html("Neuer Mascineverwendung wurde bearbeitet!");

}




///////////////////////////////
// Fertigungslinie Menue  
///////////////////////////////

function editNewArbeitsfolgeInFertigunglinie(fertigungslinieID) {
	"use strict";
	var url = "http://zoomnation.selfhost.eu/lib/php/admin/Fertigungslinie/adminCRNeuArbeitsfolgeFertigungslinie.php?q=";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#daten").html(xhttp.responseText);
			$("#systemstatus").html("Arbeitsfolge von Fertigungslinie editiert");


		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};
	xhttp.open("GET", url + fertigungslinieID, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();

	$("#systemstatus").html("Arbeitsfolge von Fertigungslinie edit");

}

function SaveNewArbeitsfolgeInFertigunglinie(data, fertigungslinieID) {
	
	"use strict";
	
	alert("Datentranfer : " + data);
	alert("Datentranfer : " + fertigungslinieID);
	
	var url_bauteil = "http://zoomnation.selfhost.eu:8080/ProManAPI/API/Fertigungslinie";


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

	// TODO : Fertigungslinie muss vor dem speicher ermittelt werden

	xhttp.open("POST", url_bauteil, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data);

	$("#systemstatus").html("Neuer Arbeitsfolgein Fertigungslinie wurde angelegt  !");
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




///////////////////////////////
// Fertigung Menue  
///////////////////////////////
function editFertigung(fertigungsID) {
	
	"use strict";
	
	alert("Datentranfer : " + fertigungsID);
	
	var url = "http://zoomnation.selfhost.eu/lib/php/admin/Fertigung/adminCRNewFertigunglinieFertigung.php?q=";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#daten").html(xhttp.responseText);
			


		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};
	xhttp.open("GET", url + fertigungsID, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();

	$("#systemstatus").html("Fertigungslinie in Fertigung editiert");
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
		
	alert("Neu Fertigung angelegt");
}

function deleteFertigung(fertigungsID) {
	"use strict";
	alert("Datentranfer : " + fertigungsID);
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
	
	alert("Datentranfer : " + abteilungsID);
	
	var url = "http://zoomnation.selfhost.eu/lib/php/admin/Abteilung/adminCRFertigungAbteilung.php?q=";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#daten").html(xhttp.responseText);
			


		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};
	xhttp.open("GET", url + abteilungsID, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();

	$("#systemstatus").html("Fertigung in Abteilung editiert");
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
	alert("Neu Abteilung wurde angelegt");
}


function deleteAbteilung(AbteilungsID) {
	
	"use strict";
	alert("Datentranfer : " + AbteilungsID);
	
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
	
	alert("Datentranfer : " + reperaturauftragID);
	
	var url = "http://zoomnation.selfhost.eu/lib/php/admin/Instandhaltung/adminCRFertigungAbteilung.php?q=";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#daten").html(xhttp.responseText);
			


		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};
	xhttp.open("GET", url + reperaturauftragID, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();

	$("#systemstatus").html("Instandhaltungsauftrag editiert");
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


///////////////////////////////
// Produktionsplanung Menue  
///////////////////////////////


function editProduktionplanSchritt() {
	
	
	"use strict";
	
	var url = "http://zoomnation.selfhost.eu/lib/php/admin/Produktionsplanung/adminCRNewSchrittProduktionsplan.php?q=";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#daten").html(xhttp.responseText);
			


		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};
	xhttp.open("GET", url + 0, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();

	$("#systemstatus").html("Produktionslan editiert");
	
	
	
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



function editLagerort(lagerort) {
	"use strict";
	
	var url = "http://zoomnation.selfhost.eu/lib/php/admin/Produktionsplanung/adminCRLagerortBear.php?q=";


	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			$("#daten").html(xhttp.responseText);
			


		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");

		}
	};
	xhttp.open("GET", url + lagerort, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send();

	$("#systemstatus").html("Lager editiert");
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






////////////////////////////////
//				OFFEN		´ //
////////////////////////////////






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




