<!--
Ersteller : Markus Kessler	
MatrNr 	  : 894361
Presentation: 28.04.2018
Theam : ProMan
-->
<?php

$ch1 = curl_init();

curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/bauteile/bauteile.json" );
//curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/API/Audits" );
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$audits = curl_exec( $ch1 );
curl_close( $ch1 );

//echo($audits);

//$dateiname = 'C:/xampp/htdocs/proman/jsonData/sonderaufgaben/auditstest.json';
$dateiname = '../../../../jsonData/bauteile/bauteile.json';

file_put_contents($dateiname, $audits);

?>