
//loadDoc("url-1", myFunction1);

//loadDoc("url-2", myFunction2);
  var xhttp;
  xhttp = new XMLHttpRequest();

function loadData(url, cFunction) {
  "use strict";
	
	//console.log("URL : " + url);
	//console.log("cFunction : " + cFunktion);
   xhttp.onreadystatechange = function() {
	  
   if (this.readyState === 4 && this.status === 200) {
			cFunction();	
	   		//alert("Server loadData Anwort:" + xhttp.responseText);
			
		}
		if (this.readyState === 4 && this.status === 204) {
			alert("Server loadData schickt keine Anwort:");
			
		}
  };
  xhttp.open("GET", url, true);
  xhttp.send();
	
}

function saveData(url, data) {
	"use strict";
	
	//console.log("URL : " + url);
	//console.log("Data : " + data);

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
	//alert("Save User Data");
}

function FunctionUser() {
 	"use strict";
	$("#daten").html(xhttp.responseText);
	$("#systemstatus").html("Userdaten wurden geladen ");
	
}
function FunctionAbteilung() {
	"use strict";
	$("#daten").html(xhttp.responseText);
	$("#systemstatus").html("Abteilung wurden geladen ");
}

function FunctionBauteil() {
	"use strict";
	
	$("#daten").html(xhttp.responseText);
	$("#systemstatus").html("Bauteil wurden geladen ");
}

function FunctionRegisterUser() {
	"use strict";
	
	$("#daten").html(xhttp.responseText);
	$("#systemstatus").html("Register User wurden geladen ");
}