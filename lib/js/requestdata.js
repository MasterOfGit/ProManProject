// JavaScript Document
function saveData(url, data) {
	"use strict";
	//xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");	

	alert("Test " + url);
	alert("Test " + data);
	var mitarbeiter = "http://zoomnation.selfhost.eu:8080/ProManAPI/api/User"
	
	var mitarbeiterData = JSON.stringify({
		"Active": false,
		"Namenszusatz": 2,
		"Vorname": "Frank",
		"Nachname": "Test",
		"Festnetz": "0123/122",
		"Mobil": "0123/122",
		"eMail": "test@mail.de",
		"Bemerkung": "test",
		"Login_LoginID": 1,
		"Passbild_EFImageID": 1,
		"Reparatur_ReparaturID": 1,
		"Audit_AuditID": 1,
		"Wartung_WartungID": 1
	});
	
	var login = "http://zoomnation.selfhost.eu:8080/ProManAPI/api/Login"
	
	var LoginData = JSON.stringify({
		"LastLogin": null,
		"Username": "dvcTEST",
		"Password": "dvcTEST",
		"Logintype": 0,
		});

	console.log("dataoject: " + dataoject);

	xhttp.onreadystatechange = function () {
		//alert("readyState: " + this.readyState);
		//alert("status: " + this.status);

		if (this.readyState == 4 && this.status == 200) {
			alert("Server Anwort:" + xhttp.responseText);
			//alert("Skript: loadDoc !!");
		}
	};
	xhttp.open("POST", url, login);
	xhttp.setRequestHeader("Content-type", "application/json");

	xhttp.send(LoginData);
	alert("Save User Data");

}

function FunctionUser(xhttp) {
	"use strict";
	//document.getElementById("daten").innerHTML = xhttp.responseText;
	$("#daten").append(xhttp.responseText);
	document.getElementById("systemstatus").innerHTML = "Userdaten wurden geladen ";
	//alert("Skript: myFunction 1 !!");
	//myFunction2();
}
