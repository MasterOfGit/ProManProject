<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";
//$q= 2;
$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/maschinen/maschinenVerwendung.json");

curl_setopt($ch1, CURLOPT_HEADER, 0);
curl_setopt($ch1,CURLOPT_RETURNTRANSFER,true);
$maschineverwendung=curl_exec($ch1);
curl_close($ch1);

// Testausgabe
//echo($bauteil);

// Unwandlung von json in Array	
$jsonmaschineverwendung = json_decode($maschineverwendung, TRUE);


echo <<<HEADER


<script>
function createData()
{


		var data = JSON.stringify(
		{
	
			"maschinenID"				:	$("#maschinenID").val(),

			"bauteileID"				:	$("#bauteileID").val(),

			"abteilungID"				:	$("#abteilungID").val(),

			"fertigungID"				:	$("#fertigungID").val(),

			"fertigungslinieID"			:	$("#fertigungslinieID").val(),

			"arbeitsfolge"	 			:	$("#arbeitsfolge").val()			
		}
);

saveMaschineVerwendung(data);

alert("createData saveMaschineVerwendung");

};
</script>
<div class="maschineverwendungbearbeiten">
 
    <div class="jumbotron">
	 <div class="row">
      <div class="col-md-6 col-md-offset-3">
      <form>
        <div class="form-group">
         
HEADER;
		  foreach($jsonmaschineverwendung['machinenVerwendung'] as $maschineverwendung)
				{
				// Neues Bauteil
			  	if( $maschineverwendung['maschinenID'] == $q)
					{
										
						echo("<label for='maschinenID'>maschinenID</label>");
						echo("<input readonly type='text' class='form-control' id='maschinenID' aria-describedby='userID' placeholder='' value={$maschineverwendung['maschinenID']}>");
					
						echo("<label for='bauteileID'>bauteileID</label>");
						echo("<input type='text' class='form-control' id='bauteileID' aria-describedby='bauteileID' placeholder='' value={$maschineverwendung['bauteileID']}>");
					
						echo("<label for='abteilungID'>abteilungID</label>");
						echo("<input type='text' class='form-control' id='bauteilIndex' aria-describedby='abteilungID' placeholder='' value={$maschineverwendung['abteilungID']}>");
					
						echo("<label for='fertigungID'>fertigungID</label>");
						echo("<input type='text' class='form-control' id='fertigungID' aria-describedby='fertigungID' placeholder='' value={$maschineverwendung['fertigungID']}>");
					
						echo("<label for='fertigungslinieID'>fertigungslinieID</label>");
						echo("<input type='text' class='form-control' id='fertigungslinieID' aria-describedby='fertigungslinieID' placeholder='' value={$maschineverwendung['fertigungslinieID']}>");
					
						echo("<label for='arbeitsfolge'>arbeitsfolge</label>");
						echo("<input type='text' class='form-control' id='arbeitsfolge' aria-describedby='arbeitsfolge' placeholder='' value={$maschineverwendung['arbeitsfolge']}>");
					

					}
			  	};
           		if( $q == 0) //neues Bauteil
					{
				  		foreach($jsonmaschineverwendung['machinenVerwendung'] as $maschineverwendung)
						{	$maschineverwendungidmax = 0;
							if($maschineverwendung['maschinenID']>$maschineverwendungidmax)
							{
								$maschineverwendungidmax = $maschineverwendung['maschinenID'];
								
							}
						 	$maschineverwendungidmax++;
						}
						
				  	    echo("<label for='maschinenID'>maschinenID</label>");
						echo("<input readonly type='text' class='form-control' id='maschinenID' aria-describedby='userID' placeholder='' value=$maschineverwendungidmax>");
					
						echo("<label for='bauteileID'>bauteileID</label>");
						echo("<input type='text' class='form-control' id='bauteileID' aria-describedby='bauteileID' placeholder='' value=0>");
					
						echo("<label for='abteilungID'>abteilungID</label>");
						echo("<input type='text' class='form-control' id='bauteilIndex' aria-describedby='abteilungID' placeholder='' value=0>");
					
						echo("<label for='fertigungID'>fertigungID</label>");
						echo("<input type='text' class='form-control' id='fertigungID' aria-describedby='fertigungID' placeholder='' value=0>");
					
						echo("<label for='fertigungslinieID'>fertigungslinieID</label>");
						echo("<input type='text' class='form-control' id='fertigungslinieID' aria-describedby='fertigungslinieID' placeholder='' value=0>");
					
						echo("<label for='arbeitsfolge'>arbeitsfolge</label>");
						echo("<input type='text' class='form-control' id='arbeitsfolge' aria-describedby='arbeitsfolge' placeholder='' value=0>");
						
			  		}
echo <<<FOOTER
		</div>
<button type="button" class="btn btn-primary" onclick="createData();"> Speichern</button>
<input type="button" value="Zurück" onclick="window.location.href='usercontent.html'" />
	      </form>
    </div>
  </div>
</div>
</div>


FOOTER;
?>
