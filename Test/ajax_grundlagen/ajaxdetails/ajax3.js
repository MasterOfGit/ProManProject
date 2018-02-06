var resOb = null;
function erzXMLHttpRequestObject(){
  var resOb = null;
  try {
    resOb = new ActiveXObject("Microsoft.XMLHTTP");
  }
  catch(Error){
    try {
      resOb = new ActiveXObject("MSXML2.XMLHTTP");
    }
    catch(Error){
      try {
      resOb = new XMLHttpRequest();
      }
      catch(Error){
        alert("Erzeugung des XMLHttpRequest-Objekts nicht möglich");
      }
    }
  }
  return resOb;
}
function sndReq() {
    resOb.open('get', 'webseiten.xml',true);
    resOb.onreadystatechange = handleResponse;
    resOb.send(null);
}
function handleResponse() {
  if(resOb.readyState == 4){
    erg = resOb.responseXML;
    document.getElementById("antwort").innerHTML = 
      erg.getElementsByTagName("titel")[0].firstChild.data + "<hr />" +
      erg.getElementsByTagName("url")[0].firstChild.data + "<hr />" + 
      erg.getElementsByTagName("bemerkung")[0].firstChild.data;
  }
}
resOb = erzXMLHttpRequestObject();
