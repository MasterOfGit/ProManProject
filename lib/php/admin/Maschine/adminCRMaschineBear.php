<!--
Ersteller : Markus Kessler	
MatrNr 	  : 894361
Presentation: 28.04.2018
Team : ProMan
modifikations : Sebastian Molkenthin
MartNr : 896734
-->
<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";
//$q= 0;
$ch1 = curl_init();

//curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/maschinen/maschinen.json");
curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/maschine");
//curl_setopt($ch1, CURLOPT_URL, "http://localhost/api/maschine");
curl_setopt($ch1, CURLOPT_HEADER, 0);
curl_setopt($ch1,CURLOPT_RETURNTRANSFER,true);
$maschine=curl_exec($ch1);
curl_close($ch1);
// Unwandlung von json in Array	
$jsonmaschine = json_decode($maschine, TRUE);

$ch2 = curl_init();

//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/maschinen/maschinen.json");
curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/addgetdeleteobject/?type=MaschinenStatus");
//curl_setopt($ch2, CURLOPT_URL, "http://localhost/api/addgetdeleteobject/?type=MaschinenStatus");
curl_setopt($ch2, CURLOPT_HEADER, 0);
curl_setopt($ch2,CURLOPT_RETURNTRANSFER,true);
$maschinestatus=curl_exec($ch2);
curl_close($ch2);
// Unwandlung von json in Array	
$jsonmaschinestatus = json_decode($maschinestatus, TRUE);

echo <<<HEADER

<script>
function createData()
{

		var givenId = $q;
		var data = JSON.stringify(
		{
	
			"maschinenID"				:	$("#maschinenID").val(),

			"maschinenInventarNummer"	:	$("#maschinenInventarNummer").val(),

			"hersteller"				:	$("#hersteller").val(),

			"technologie"				:	$("#technologie").val(),

			"standort"					:	$("#standort").val(),

			"abteilungsId"	 				:	$("#abteilung").val(),
			
			"status"					:	$("#status").val()
		}

);

		if(givenId==0)		{	
			saveMaschine(data);		
		}
		else{
			updateMaschine(data,givenId);
		}
};
</script>



<div class="maschinebearbeiten">
 
    <div class="jumbotron">
	 <div class="row">
      <div class="col-md-6 col-md-offset-3">
      <form>
        <div class="form-group">
         
HEADER;
		  foreach($jsonmaschine as $maschine)
				{
				// Neues Bauteil
			  	if( $maschine['maschinenID'] == $q)
					{
										
						echo("<label for='maschinenID'>maschinenID</label>");
						echo("<input readonly type='text' class='form-control' id='maschinenID' aria-describedby='userID' placeholder='' value={$maschine['maschinenID']}>");
													
						echo("<label for='maschinenInventarNummer'>maschinenInventarNummer</label>");
						echo("<input type='text' class='form-control' id='maschinenInventarNummer' aria-describedby='maschinenInventarNummer' placeholder='' value={$maschine['maschinenInventarNummer']}>");
					
						echo("<label for='hersteller'>hersteller</label>");
						echo("<input type='text' class='form-control' id='hersteller' aria-describedby='hersteller' placeholder='' value={$maschine['hersteller']}>");
					
						echo("<label for='technologie'>technologie</label>");
						echo("<input type='text' class='form-control' id='technologie' aria-describedby='userID' placeholder='' value={$maschine['technologie']}>");
					
						echo("<label for='standort'>standort</label>");
						echo("<input type='text' class='form-control' id='standort' aria-describedby='standort' placeholder='' value={$maschine['standort']}>");
					
						echo("<label for='abteilung'>abteilung</label>");
						echo("<input type='text' class='form-control' id='abteilung' aria-describedby='abteilung' placeholder='' value={$maschine['abteilungsId']}>");
					
						echo("<label for='status'>status</label>");
						echo("<input type='text' class='form-control' id='status' aria-describedby='status' placeholder='' value={$maschine['status']}>");

					}
			  	};
           		if( $q == 0) //neues Bauteil
					{
				  		//foreach($jsonmaschine['maschinen'] as $maschine)
						//{	$maschineidmax = 0;
						//	if($maschine['maschinenID']>$maschineidmax)
						//	{
						//		$maschineidmax = $maschine['maschinenID'];
						//		
						//	}
						// 	$maschineidmax++;
						//}
						
				  		echo("<label for='maschinenID'>maschinenID</label>");
						echo("<input readonly type='text' class='form-control' id='maschinenID' aria-describedby='userID' placeholder='' value=0>");
																					
						echo("<label for='maschinenInventarNummer'>maschinenInventarNummer</label>");
						echo("<input type='text' class='form-control' id='maschinenInventarNummer' aria-describedby='maschinenInventarNummer' placeholder='' value=0>");
					
						echo("<label for='hersteller'>hersteller</label>");
						echo("<input type='text' class='form-control' id='hersteller' aria-describedby='hersteller' placeholder='' value=0>");
					
						echo("<label for='technologie'>technologie</label>");
						echo("<input type='text' class='form-control' id='technologie' aria-describedby='userID' placeholder='' value=0>");
					
						echo("<label for='standort'>standort</label>");
						echo("<input type='text' class='form-control' id='standort' aria-describedby='standort' placeholder='' value=0>");
					
						echo("<label for='abteilung'>abteilung</label>");
						echo("<input type='text' class='form-control' id='abteilung' aria-describedby='abteilung' placeholder='' value=0>");
					
						echo("<label for='status'>status</label>");
						echo("<select id='status' name='status' aria-describedby='status' class='form-control'>");
						foreach($jsonmaschinestatus as $maschinestatusitem) 
						{
						  echo("<option value={$jsonmaschinestatus['Key']}>{$maschinestatusitem['Value']}</option>");
						};
					  	echo("</select>");

						//echo("<input type='text' class='form-control' id='status' aria-describedby='status' placeholder='' value=0>");
						
			  		}
echo <<<FOOTER
		</div>
<button type="button" class="btn btn-primary" onclick="createData()"> Speichern</button>
<input class='btn btn-primary' type="button" value="Zurück" onclick="window.location.href='usercontent.html'" />
	      </form>
    </div>
  </div>
</div>
</div>


FOOTER;
?>