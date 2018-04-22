// JavaScript Document

function currentDate() {
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
	var kw = currentKW(year, month + 1, day);
	document.getElementById("datekw").innerHTML = dkw + " ( KW " + kw + " )";
	//alert("Skript helpers Läuft !!!");
	//alert(kw);

}

function currentKW(j, m, t) {
	"use strict";

	var Datum = new Date();
	if (!t) {
		j = Datum.getYear();
		if (1900 > j) {
			j += 1900;
		}
		m = Datum.getMonth();
		t = Datum.getDate();
	} else {
		m--;
	}
	Datum = new Date(j, m, t, 0, 0, 1);
	var tag = Datum.getDay();
	if (tag === 0) {
		tag = 7;
	}
	var d = new Date(2004, 0, 1).getTimezoneOffset();
	var Sommerzeit = (Date.UTC(j, m, t, 0, d, 1) - Number(Datum)) / 3600000;
	Datum.setTime(Number(Datum) + Sommerzeit * 3600000 - (tag - 1) * 86400000);
	var Jahr = Datum.getYear();
	if (1900 > Jahr) {
		Jahr += 1900;
	}
	var kw = 1;
	if (new Date(Jahr, 11, 29) > Datum) {
		var Start = new Date(Jahr, 0, 1);
		Start = new Date(Number(Start) + 86400000 * (8 - Start.getDay()));
		if (Start.getDate() > 4) {
			Start.setTime(Number(Start) - 604800000);
		}
		kw = Math.ceil((Datum.getTime() - Start) / 604800000);
	}
	return kw;
}

function createCanvas(){
	"use strict";
	//alert("Skript Canvas");
	var c = document.getElementById("myCanvas");
	var ctx = c.getContext("2d");
	ctx.font = "30px Arial";
	ctx.fillText("Fertigung_1", 10, 50);

	ctx.font = "10px Arial";
	ctx.fillText("Fertigungslinie_1", 30 + 25, 100 + 30);
	ctx.strokeRect(30, 100, 120, 50);


	ctx.moveTo(80, 150);
	ctx.lineTo(80, 180);
	ctx.lineTo(70, 170);
	ctx.moveTo(80, 180);
	ctx.lineTo(90, 170);

	ctx.font = "10px Arial";
	ctx.fillText("Fertigungslinie_3", 30 + 25, 180 + 30);
	ctx.strokeRect(30, 180, 120, 50);

	ctx.moveTo(80, 230);
	ctx.lineTo(80, 260);
	ctx.lineTo(70, 250);
	ctx.moveTo(80, 260);
	ctx.lineTo(90, 250);

	ctx.font = "10px Arial";
	ctx.fillText("Fertigungslinie_4", 30 + 25, 260 + 30);
	ctx.strokeRect(30, 260, 120, 50);



	ctx.stroke();
}
