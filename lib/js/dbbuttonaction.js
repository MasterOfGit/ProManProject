
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






// Bauteil Menue

function createBauteil()
{
	"use strict";
	var url = "http://zoomnation.selfhost.eu:8080/ProManAPI/api/AdminPage/?identifier=AdminPageBauteil";
	var data = 	"{'ID':20,'Teilart':'Bauteil_30','Version':'1.0','Verwendungsort':'hier','Abhaengigkeiten':null}";
	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState === 4 && this.status === 200) {
			alert("Server saveData Anwort:" + xhttp.responseText);
			
			}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server saveData schickt keine Anwort:");
			
		}
	};
	xhttp.open("POST", url, true);
	xhttp.setRequestHeader("Content-type", "application/json");
	xhttp.send(data);
	$("#systemstatus").html("Bauteil erzeugt !! " + data + "--" + xhttp.responseText);
}

function changeBauteil( BauteilID )
{
	"use strict";
}

function deleteBauteil( BauteilID )
{
	"use strict";
}

function createVerwendungBauteil( BauteilID )
{
	"use strict";
}

function changeVerwendungBauteil( BauteilID )
{
	"use strict";
}

function deleteVerwendungBauteil( BauteilID )
{
	"use strict";
}


////////////////////////////////
//				TEST		´ //
////////////////////////////////
// user button functions
function testbuttonaction(userid){
	"use strict";
	alert("Der User :" + userid + "wurde ausgewählt");
}








////////////////////////////////
//				OFFEN		´ //
////////////////////////////////
// registriere User Menue
function saveRegistrierung( userID )
{
"use strict";
}

function resetRegistrierung( )
{
"use strict";
}

// Usermenue
function saveRegistrierung( userID )
{
"use strict";
}
// haben eiene UserID
function changeRegisteruser( userID )
{
"use strict";
}
// können ev noch keine userID zugewiesen bekommen haben, daher userid ev null
function changeUnRegisteruser( userID, email  )
{
"use strict";
}

function changeUnMessageRegUser( userID, email  )
{
"use strict";
}

// Abteilung Menue
function newFertigungInAbteilung( )
{
"use strict";
}

function saveAbteilung( AbteilungsID )
{
"use strict";
}

function resetAbteilung( )
{
"use strict";
}

function deleteAbteilung( AbteilungsID )
{
"use strict";
}

function createAbteilungGrafik( )
{
"use strict";
}

// Fertigung Menue
function newFertigunglinieInFertigung ()
{
"use strict";
}

function saveFertigungen( FertigungsID )
{
"use strict";
}

function resetFertigung ( FertigungsID )
{
"use strict";
}

function deleteFertigung( FertigungsID )
{
"use strict";
}

function createFertigungGrafik( FertigungsID  )
{
"use strict";
}


// Fertigungslinie Menue
function newArbeitsfolgeInFertigunglinie()
{
"use strict";
}

function saveFertigungslinie( FertigungslinienID )
{
"use strict";
}

function resetFertigungslinie( FertigungslinienID )
{
"use strict";
}

function deleteFertigungslinie( FertigungslinienID )
{
"use strict";
}

function changeFertigungslinie( FertigungslinienID )
{
"use strict";
}

function moveFertigungslinien( FertigungslinienID, vonAbteilungID, nachAbteilungID )
{
"use strict";
}

function createFertigungslinienGrafik( FertigungslinienID )
{
"use strict";
}


// Maschine Menue

function createMaschine()
{
	"use strict";
}

function changeMaschine( MaschinenID )
{
	"use strict";
}

function deleteMaschine( MaschinenID )
{
	"use strict";
}

function createVerwendungMaschie( MaschinenID )
{
	"use strict";
}

function changeVerwendungMaschine( MaschinenID )
{
	"use strict";
}

function deleteVerwendungMaschine( MaschinenID )
{
	"use strict";
}




// Linkss für Akteilungsstatus 

function detailBauteiNummer()
{
	"use strict";
}

// .....


// Linkss für Fertigungsstatus 

function detailReperaturenOffen()
{
	"use strict";
}

// .....


// Instandhaltung Menue

function viewReperaturAuftrag( ReperaturauftragID )
{
	"use strict";
}
	
function acceptReperaturAuftrag( ReperaturauftragID )
{
	"use strict";
}	

function deleteReperaturAuftrag( ReperaturauftragID )
{
	"use strict";
}

function changeReperaturAuftrag( ReperaturauftragID )
{
	"use strict";
}

function createReperaturAuftrag()
{
	"use strict";
}

function moveReperaturAuftrag( ReperaturauftragID )
{
	"use strict";
}

//Menue Produktionsplanung

function newProduktionplan()
{
	"use strict";
}

function moveProduktionplan( ProduktionsplanID, vonSchritt, nachSchritt)
{
	"use strict";
}

function deleteProduktionplan( ProduktionsplanID )
{
	"use strict";
}

function changeProduktionplan( ProduktionsplanID )
{
"use strict";
}

function saveProduktionplan()
{
	"use strict";
}

function newLagerort()
{
	"use strict";
}
function changeLagerort( LagerortID )
{
	"use strict";
}

function deleteLagerort( LagerortID )
{
	"use strict";
}

function saveLagerort()
{
	"use strict";
}



 
 