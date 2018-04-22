<!--
Ersteller : Markus Kessler	
MatrNr 	  : 894361
Presentation: 28.04.2018
modifikations : Sebastian Molkenthin
MartNr : 896734
-->
<?php
// Besimmen des Noetigen Indexex des Audits
	$ch1 = curl_init();
	$q = 0;
	$q = $_REQUEST[ "q"] ;
	
	curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/sonderaufgaben/audits.json" );
	curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/audit" );
	//curl_setopt( $ch1, CURLOPT_URL,"http://localhost:50435/api/audit" );
	curl_setopt( $ch1, CURLOPT_HEADER, 0 );
	curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
	$audits = curl_exec( $ch1 );
	curl_close( $ch1 );

	// Unwandlung von json in Array	
	$jsonaudits = json_decode($audits, TRUE);

	//load maschines

$chabteilung = curl_init();
curl_setopt( $chmaschine, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/abteilung" );
//curl_setopt( $chabteilung, CURLOPT_URL,"http://localhost:50435/api/abteilung" );
curl_setopt( $chabteilung, CURLOPT_HEADER, 0 );
curl_setopt( $chabteilung, CURLOPT_RETURNTRANSFER, true );
$abteilungen = curl_exec( $chabteilung );
curl_close( $chabteilung );

// Unwandlung von json in Array	
$jsonabteilungen = json_decode($abteilungen, TRUE);


	//load enums

$ch2 = curl_init();
curl_setopt( $ch2, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/addgetdeleteobject/?type=StatusArt" );
//curl_setopt( $ch2, CURLOPT_URL,"http://localhost:50435/api/addgetdeleteobject/?type=StatusArt" );
curl_setopt( $ch2, CURLOPT_HEADER, 0 );
curl_setopt( $ch2, CURLOPT_RETURNTRANSFER, true );
$StatusArt = curl_exec( $ch2 );
curl_close( $ch2 );

// Unwandlung von json in Array	
$jsonStatusArt = json_decode($StatusArt, TRUE);

$ch3 = curl_init();
curl_setopt( $ch3, CURLOPT_URL,"http://zoomnation.selfhost.eu:8080/ProManAPI/api/addgetdeleteobject/?type=Turnus" );
//curl_setopt( $ch3, CURLOPT_URL,"http://localhost:50435/api/addgetdeleteobject/?type=Turnus" );
curl_setopt( $ch3, CURLOPT_HEADER, 0 );
curl_setopt( $ch3, CURLOPT_RETURNTRANSFER, true );
$Turnus = curl_exec( $ch3 );
curl_close( $ch3 );

$jsonTurnus = json_decode($Turnus, TRUE);

// Bestimmen des Noetigen Indexex des Wartung
if( $q == 0)
{
	$maxAudit = 0;
	$abteilung = 0;
	$auditart = 0;
	$termin = 0;
	$status = 0;
	$nacharbeit = 0;
	$terminturnus = 0;
	$beurteilung = 0;

	$zugriff = 0;
}
else
{
	foreach($jsonaudits as $audit){

		if($audit['auditID'] > $q)
		{
			$maxAudit = $audit['auditID'];
			$abteilung = $audit['auditID'];
			$auditart = $audit['auditart'];
			$termin = $audit['termin'];
			$status = $audit['status'];
			$nacharbeit = $audit['nacharbeit'];
			$terminturnus = $audit['terminturnus'];
			$beurteilung = $audit['beurteilung'];
		}
	}

	$zugriff = 1;
}

echo <<<HOME1_HEADER
<script>
function createData(q)
{


		var data = JSON.stringify(
		{
		
			"auditID"	:	$("#auditID").val(),

			"abteilung"	:	$("#abteilung").val(),

			"auditart"	:	$("#auditart").val(),

			"termin"	:	$("#termin").val(),

			"status"	:	$("#status").val(),

			"nacharbeit"	:	$("#nacharbeit").val(),

			"terminturnus"	:	$("#terminturnus").val(),

			"beurteilung"	:	$("#beurteilung").val()

		}
);
saveAudit(data,{$zugriff});

alert("createData saveAudit");

};
</script><div class="Produktionplanschritt">
	<div class="jumbotron">
		<div class="container">
		
HOME1_HEADER;
			
						echo("<label for='auditID'>auditID</label>");
						echo("<input readonly type='text' class='form-control' id='auditID' aria-describedby='auditID' placeholder='' value={$maxAudit}>");
					
						echo("<label for='abteilung'>abteilung</label>");
						echo("<select id='abteilung' name='abteilung' aria-describedby='abteilung' class='form-control'>");
						foreach($jsonabteilungen as $Abteilungitem) 
						{
							if($audit['abteilungsname']==$Abteilungitem['abteilungsname'])
							{
								echo("<option value={$Abteilungitem['abteilungsID']} selected>{$Abteilungitem['abteilungsname']}</option>");
							}
							else
							{
								echo("<option value={$Abteilungitem['abteilungsID']}>{$Abteilungitem['abteilungsname']}</option>");
							}				  
						};
						echo("</select>");

	
						echo("<label for='auditart'>auditart</label>");
						echo("<input type='text' class='form-control' id='auditart' aria-describedby='auditart' placeholder='' value={$auditart}>");
					
						echo("<label for='termin'>termin</label>");
						echo("<input type='text' class='form-control' id='termin' aria-describedby='termin' placeholder='' value={$termin}>");
					
						echo("<label for='status'>status</label>");
						echo("<select id='status' name='status' aria-describedby='status' class='form-control'>");
						foreach($jsonStatusArt as $Statusitem) 
						{
							if($audit['status']==$Statusitem['Value'])
							{
								echo("<option value={$Statusitem['Key']} selected>{$Statusitem['Value']}</option>");
							}
							else
							{
								echo("<option value={$Statusitem['Key']}>{$Statusitem['Value']}</option>");
							}			  
						};
						echo("</select>");
						echo("<label for='nacharbeit'>nacharbeit</label>");
						echo("<input type='text' class='form-control' id='nacharbeit' aria-describedby='nacharbeit' placeholder='' value='{$nacharbeit}'>");
					
						echo("<label for='terminturnus'>terminturnus</label>");
						echo("<select id='terminturnus' name='terminturnus' aria-describedby='terminturnus' class='form-control'>");
						foreach($jsonTurnus as $Turnusitem) 
						{
							if($audit['terminturnus']==$Turnusitem['Value'])
							{
								echo("<option value={$Turnusitem['Key']} selected>{$Turnusitem['Value']}</option>");
							}
							else
							{
								echo("<option value={$Turnusitem['Key']}>{$Turnusitem['Value']}</option>");
							}				  
						};
						echo("</select>");
						echo("<label for='beurteilung'>beurteilung</label>");
						echo("<input type='text' class='form-control' id='beurteilung' aria-describedby='beurteilung' placeholder='' value='{$beurteilung}'>");

						echo("<br>");
						echo("<td><input class='btn btn-primary' type='button' value='Speichern'  onclick='createData({$q});'></td>");


echo <<<'HOME1_FOOTER'
						
					</div>
				</div>
			</div>
HOME1_FOOTER;
						 
?>

