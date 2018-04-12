<?php
loadAbteilung();
loadBauteil();
loadFertigung();
loadFertigungslinie();
loadMaschinen();
loadUserData();

	
//$url_in = "fertigungslinien.json";
//$url_out = "save.json";
//
//$file = file_get_contents($url_in, FILE_USE_INCLUDE_PATH);
//
//$jsoninput = json_decode($file, TRUE);
//
//$a = $jsoninput['fertigungslinie'];
//
//foreach( $a as &$b)
//{	
//	if($b['fertigungslinieID'] == 1)
//	{
//		$b['fertigunglinenname'] = "Fertigung_1";
//	}
// 	
//};
//$b = json_encode($a);
//
//file_put_contents($url, $b);



// json Dateien laden

// Abteilung
function loadAbteilung()
{

$url_in = "http://zoomnation.selfhost.eu:8080/ProManAPIDummy/api/AdminPage/?identifier=AdminPageAbteilung";
$url_out = "abteilung.json";

$file = file_get_contents($url_in, FILE_USE_INCLUDE_PATH);

$jsoninput = json_decode($file, TRUE);

$b = json_encode($jsoninput);

file_put_contents($url_out, $b);
	
}

function loadBauteil()
{
$url_in = "http://zoomnation.selfhost.eu:8080/ProManAPIDummy/api/AdminPage/?identifier=AdminPageBauteil";
$url_out = "bauteile.json";

$file = file_get_contents($url_in, FILE_USE_INCLUDE_PATH);

$jsoninput = json_decode($file, TRUE);

$b = json_encode($jsoninput);

file_put_contents($url_out, $b);
	
}

function loadFertigung()
{
$url_in = "http://zoomnation.selfhost.eu:8080/ProManAPIDummy/api/AdminPage/?identifier=AdminPageFertigung";
$url_out = "fertigungen.json";

$file = file_get_contents($url_in, FILE_USE_INCLUDE_PATH);

$jsoninput = json_decode($file, TRUE);

$b = json_encode($jsoninput);

file_put_contents($url_out, $b);	
}

function loadFertigungslinie()
{
$url_in = "http://zoomnation.selfhost.eu:8080/ProManAPIDummy/api/AdminPage/?identifier=o	AdminPageFertigungslinie";
$url_out = "fertigungslinien.json";

$file = file_get_contents($url_in, FILE_USE_INCLUDE_PATH);

$jsoninput = json_decode($file, TRUE);

$b = json_encode($jsoninput);

file_put_contents($url_out, $b);		
}

function loadMaschinen()
{
$url_in = "http://zoomnation.selfhost.eu:8080/ProManAPIDummy/api/AdminPage/?identifier=AdminPageMaschine";
$url_out = "maschinen.json";

$file = file_get_contents($url_in, FILE_USE_INCLUDE_PATH);

$jsoninput = json_decode($file, TRUE);

$b = json_encode($jsoninput);

file_put_contents($url_out, $b);	
}

function loadUserData()
{
$url_in = "http://zoomnation.selfhost.eu:8080/ProManAPIDummy/api/AdminPage/?identifier=AdminPageUser";
$url_out = "userdata.json";

$file = file_get_contents($url_in, FILE_USE_INCLUDE_PATH);

$jsoninput = json_decode($file, TRUE);

$b = json_encode($jsoninput);

file_put_contents($url_out, $b);	
}




// OFFEN

function loadUserLogin()
{
	
}


function loadUserAnfragen(){
	
}



function loadWartungen(){
	
}



function loadAudits(){
	
}



function loadProduktionsplanung(){
	
}

function loadLagerbestend(){
	
}


function loadMaschinenverwendung(){
	
}





function loadInstandhaltung(){
	
}







function loadBauteiverwendung(){
	
}





function loadfertigunggststusdeteils(){
	
}


function loadabteilungfertigungsstatus(){
	
}






?>