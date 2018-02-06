if (navigator.appName.search("Microsoft")>-1) {
      resObjekt = new ActiveXObject("MSXML2.XMLHTTP");
}
else {
       resObjekt = new XMLHttpRequest();
}
function sndReq() {
    resObjekt.open('get', 'ajax1.txt',true);
    resObjekt.onreadystatechange = handleResponse;
    resObjekt.send(null);
}
function handleResponse() {
  if(resObjekt.readyState == 4){
    document.getElementById("antwort").innerHTML =  
    "Antwort vom Server: " + resObjekt.responseText +
    "<br />Übertragungsstatus: " + resObjekt.readyState +
    "<br />Status: " + resObjekt.status +
    "<br />Statustext: " + resObjekt.statusText +
    "<hr />Die vom Server gesendeten Header-Felder: " +
    resObjekt.getAllResponseHeaders();
  }
}

