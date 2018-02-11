// JavaScript Document

function currentDate(){
    "use strict";
   
    var monthname = [   
                "Januar",
                "Februar",
                "März",
                "April",
                "Mai",
                "Juni",
                "Juli",
                "August",
                "September",
                "Oktober",
                "November",
                "Dezember"
                ];
    
    
    var day = new Date().getDate();
    var month = new Date().getMonth();
    var year = new Date().getFullYear();
    var dkw = day + "." + monthname[month] + " " + year;
    var kw = currentKW(year, month+1, day);
    document.getElementById("datekw").innerHTML =  dkw + " ( KW " + kw +  " )" ;
    //alert("Skript helpers Läuft !!!");
    //alert(kw);
    
}

function currentKW(j,m,t) {
  "use strict";
  
  var Datum = new Date();
  if (!t) 
  {
    j = Datum.getYear(); 
      if (1900>j){ j+=1900;}
    m = Datum.getMonth(); 
    t = Datum.getDate();
  }
  else {m--;}
  Datum = new Date(j,m,t,0,0,1);
  var tag = Datum.getDay(); 
    if(tag === 0){tag = 7;}
  var d = new Date(2004,0,1).getTimezoneOffset();
  var Sommerzeit = (Date.UTC(j,m,t,0,d,1) - Number(Datum)) /3600000;
  Datum.setTime(Number(Datum) + Sommerzeit*3600000 - (tag-1)*86400000);
  var Jahr = Datum.getYear(); 
    if (1900 > Jahr) {Jahr +=1900;}
  var kw = 1;
  if (new Date(Jahr,11,29) > Datum) 
  {
    var Start = new Date(Jahr,0,1);
    Start = new Date(Number(Start) + 86400000*(8-Start.getDay()));
    if(Start.getDate() > 4) {Start.setTime(Number(Start) - 604800000);}
    kw = Math.ceil((Datum.getTime() - Start) /604800000);
  }
  return kw;
}


