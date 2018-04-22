<!--
Ersteller : Markus Kessler	
MatrNr 	  : 894361
Presentation: 28.04.2018
Theam : ProMan
-->
<?php
// Besimmen des Noetigen Indexex des Audits
	$ch1 = curl_init();
	$q = 0;
	$q = $_REQUEST[ "q"] ;
	curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/sonderaufgaben/audits.json" );
	curl_setopt( $ch1, CURLOPT_HEADER, 0 );
	curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
	$audits = curl_exec( $ch1 );
	curl_close( $ch1 );

	// Unwandlung von json in Array	
	$jsonaudits = json_decode($audits, TRUE);

	foreach($jsonaudits['audits'] as $audit){
		$maxAudit = 0;
		if($audit['auditID'] > $maxAudit)
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
		if($q == 0)
		{
			$maxAudit = 0;
			$abteilung = 0;
			$auditart = 0;
			$termin = 0;
			$status = 0;
			$nacharbeit = 0;
			$terminturnus = 0;
			$beurteilung = 0;
		}
	}

	// Aktueller Index bei neuem Audit
	
	$maxAudit++ ;

	// Aktueller Index bei aenderung eines Audits
	
	if($q > 0)
	{
		$maxAudit = $q ;
		$zugriff = 1;
		
	}
	else 
		$zugriff = 0;

//echo ("MaxauditID : " . $maxAudit);

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
			
						// TODO: maxiD muss noch bestimmt werden

						echo("<label for='auditID'>auditID</label>");
						echo("<input readonly type='text' class='form-control' id='auditID' aria-describedby='auditID' placeholder='' value={$maxAudit}>");

					
						echo("<label for='abteilung'>abteilung</label>");
						echo("<input type='text' class='form-control' id='abteilung' aria-describedby='abteilung' placeholder='' value={$abteilung}>");
					
						echo("<label for='auditart'>auditart</label>");
						echo("<input type='text' class='form-control' id='auditart' aria-describedby='auditart' placeholder='' value={$auditart}>");
					
						echo("<label for='termin'>termin</label>");
						echo("<input type='text' class='form-control' id='termin' aria-describedby='termin' placeholder='' value={$termin}>");
					
						echo("<label for='status'>status</label>");
						echo("<input type='text' class='form-control' id='status' aria-describedby='status' placeholder='' value={$status}>");
						
						echo("<label for='nacharbeit'>nacharbeit</label>");
						echo("<input type='text' class='form-control' id='nacharbeit' aria-describedby='nacharbeit' placeholder='' value='{$nacharbeit}'>");
					
						echo("<label for='terminturnus'>terminturnus</label>");
						echo("<input type='text' class='form-control' id='terminturnus' aria-describedby='terminturnus' placeholder='' value='{$terminturnus}'>");
						
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

