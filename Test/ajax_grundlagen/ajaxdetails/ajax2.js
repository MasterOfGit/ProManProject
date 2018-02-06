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
    resOb.open('get', 'ajax2.php?n=' + encodeURI(document.f.n.value),true);
    resOb.onreadystatechange = handleResponse;
    resOb.send(null);
}
function handleResponse() {
  if(resOb.readyState == 4){
    document.getElementById("antwort").innerHTML = resOb.responseText;
  }
}
resOb = erzXMLHttpRequestObject();
