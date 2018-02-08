
//loadDoc("url-1", myFunction1);

//loadDoc("url-2", myFunction2);
  var xhttp;
  xhttp = new XMLHttpRequest();


	function loadDoc(url, cFunction) {
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

function myFunction1(xhttp) {
 	"use strict";
	document.getElementById("daten").innerHTML = xhttp.responseText;
	//alert("Skript: mayFunction 1 !!");
	myFunction2();
}
function myFunction2() {
	//alert("Skript: mayFunction 2 !!");
  //document.getElementById("daten").appendChild(document.getElementById("daten").lastChild);
  //alert("Skript: mayFunction 2 !!");	
}

