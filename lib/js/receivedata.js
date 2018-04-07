
//loadDoc("url-1", myFunction1);

//loadDoc("url-2", myFunction2);
  var xhttp;
  xhttp = new XMLHttpRequest();


function loadData(url, cFunction) {
  "use strict";
	
	/*alert("Test "+ xhttp.readyState);
		alert("Test "+ url);
			alert("Test "+ cFunction);*/
  xhttp.onreadystatechange = function() {
	  
    if (this.readyState == 4  && this.status == 200) {
    	cFunction(this);
		//alert("Skript: loadDoc !!");
	}
  };
  xhttp.open("GET", url, true);
  xhttp.send();
	
}
function saveData(url, data) {
  "use strict";
 //xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");	
	
		alert("Test "+ url);
		alert("Test "+ data);
	
	
  xhttp.onreadystatechange = function() {
	  alert("readyState: "+ this.readyState);
	alert("status: "+ this.status);
	  
    if (this.readyState == 4  && this.status == 200) {
    	alert("Server Anwort:" + xhttp.responseText);
		//alert("Skript: loadDoc !!");
	}
  };
  xhttp.open("POST", url, true);
  xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
  xhttp.send({"ID":0,"Active":false,"Namenszusatz":0,"Vorname":"Frank","Nachname":"Test","Festnetz":"0123/122","Mobil":"0123/122","eMail":"test@mail.de","Bemerkung":null});
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
function FunctionAbteilung() {
	"use strict";
	$("#daten").append(xhttp.responseText);
	document.getElementById("systemstatus").innerHTML = "Abteilungsdaten wurden geladen ";
}

function FunctionsaveUser() {
	"use strict";
	alert("Nutzer wurde angelegt");
	document.getElementById("systemstatus").innerHTML = "Nutzer gespeichert ";
}

