if (navigator.appName.search("Microsoft")>-1) {
      resObjekt = new ActiveXObject("MSXML2.XMLHTTP");
}
else {
       resObjekt = new XMLHttpRequest();
}
function sndReq() {
    resObjekt.open('get', 'json.txt',true);
    resObjekt.onreadystatechange = handleResponse;
    resObjekt.send(null);
}
function handleResponse() {
  var text="<table border='1' width='400'><tr><th>Kennzeichen</th><th>Gebiet</th></tr>";
  document.getElementById("ergeb").style.visibility = "visible";
  if(resObjekt.readyState == 4){
    meinJSONObjekt = eval( "(" + resObjekt.responseText + ")" );
    for(i=0;i <meinJSONObjekt.bindings.length;i++) {
      text += "<tr><td>" + meinJSONObjekt.bindings[i].kennzeichen + "</td><td>" 
	     + meinJSONObjekt.bindings[i].gebiet + "</td></tr>";
    }
    document.getElementById("ergeb").innerHTML = text;
  }
} 
