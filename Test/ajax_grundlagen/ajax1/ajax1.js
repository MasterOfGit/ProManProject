if (navigator.appName.search("Microsoft")>-1) {
      resObjekt = new ActiveXObject("MSXML2.XMLHTTP");
}
else {
       resObjekt = new XMLHttpRequest();
}
function sndReq() {
    resObjekt.open('get', 'info.txt',true);
    resObjekt.onreadystatechange = handleResponse;
    resObjekt.send(null);
}
function handleResponse() {
  if(resObjekt.readyState == 4){
    document.getElementById("ausgabe").innerHTML = resObjekt.responseText;
  }
}
