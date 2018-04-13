<?php
//echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
//echo "Anfrage : "  . $q . "<br>";
//$q= 2;
$ch1 = curl_init();


//curl_setopt($ch2, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/adminPage/?identifier=AdminPageAbteilung");

curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu/jsonData/bauteile/bauteileVerwendung.json");

curl_setopt($ch1, CURLOPT_HEADER, 0);
curl_setopt($ch1,CURLOPT_RETURNTRANSFER,true);
$bauteilverwendung=curl_exec($ch1);
curl_close($ch1);

// Testausgabe
//echo($bauteil);

// Unwandlung von json in Array	
$jsonbauteilverwendung = json_decode($bauteilverwendung, TRUE);


echo <<<HEADER
<div class="bautelbearbeiten">
  <div class="jumbotron">
    <div class="jumbotron">
	 <div class="row">
      <div class="col-md-6 col-md-offset-3">
      <form>
        <div class="form-group">
         
HEADER;

			 foreach($jsonbauteilverwendung['bauteilVerwendung'] as $bauteilverwendung)
				{
				// Neues Bauteil
			  	if( $bauteilverwendung['bauteileID'] == $q)
					{
										
						echo("<label for='bauteilverwendungsID'>bauteilverwendungsID</label>");
						echo("<input readonly type='text' class='form-control' id='bauteilverwendungsID' aria-describedby='bauteilverwendungsID' placeholder='' value={$bauteilverwendung['bauteilverwendungsID']}>");
						echo("<label for='bauteileID'>bauteileID</label>");
						echo("<input readonly type='text' class='form-control' id='bauteileID' aria-describedby='userID' placeholder='' value={$bauteilverwendung['bauteileID']}>");
					
						echo("<label for='fertingungsLinienID'>fertingungsLinienID</label>");
						echo("<input type='text' class='form-control' id='fertingungsLinienID' aria-describedby='fertingungsLinienID' placeholder='' value={$bauteilverwendung['fertingungsLinienID']}>");
						echo("<label for='bauteilIndex'>bauteilIndex</label>");
						echo("<input type='text' class='form-control' id='technologie' aria-describedby='technologie' placeholder='' value={$bauteilverwendung['technologie']}>");
						echo("<label for='bearbeitungen'>bearbeitungen</label>");
						echo("<input type='text' class='form-control' id='bearbeitungen' aria-describedby='bearbeitungen' placeholder='' value={$bauteilverwendung['bearbeitungen']}>");
						echo("<label for='bearbeitungsschritt'>bearbeitungsschritt</label>");
						echo("<input type='text' class='form-control' id='bearbeitungsschritt' aria-describedby='bearbeitungsschritt' placeholder='' value={$bauteilverwendung['bearbeitungsschritt']}>");
						echo("<label for='bauteilStatus'>bauteilStatus</label>");
						echo("<input type='text' class='form-control' id='verwendungsZweck' aria-describedby='verwendungsZweck' placeholder='' value={$bauteilverwendung['verwendungsZweck']}>");

					}
				 };
			  if( $q == 0) //neues Bauteil
					{
				  		foreach($jsonbauteilverwendung['bauteilVerwendung'] as $bauteilverwendung)
						{	$bauteilverwendungidmax = 0;
							if($bauteilverwendung['bauteileID'] > $bauteilverwendungidmax)
							{
								$bauteilverwendungidmax = $bauteilverwendung['bauteileID'];
								
							}
						 	$bauteilverwendungidmax++;
						}
				  		echo("<label for='bauteilverwendungsID'>bauteilverwendungsID</label>");
						echo("<input readonly type='text' class='form-control' id='bauteilverwendungsID' aria-describedby='bauteilverwendungsID' placeholder='' value=$bauteilverwendungidmax>");
				  
						echo("<label for='bauteileID'>bauteileID</label>");
						echo("<input  type='text' class='form-control' id='bauteileID' aria-describedby='userID' placeholder='' value=0>");
					
						echo("<label for='fertingungsLinienID'>fertingungsLinienID</label>");
						echo("<input type='text' class='form-control' id='fertingungsLinienID' aria-describedby='fertingungsLinienID' placeholder='' value=0>");
				  
						echo("<label for='bauteilIndex'>bauteilIndex</label>");
						echo("<input type='text' class='form-control' id='technologie' aria-describedby='technologie' placeholder='' value=0>");
				  
						echo("<label for='bearbeitungen'>bearbeitungen</label>");
						echo("<input type='text' class='form-control' id='bearbeitungen' aria-describedby='bearbeitungen' placeholder='' value=0>");
				  
						echo("<label for='bearbeitungsschritt'>bearbeitungsschritt</label>");
						echo("<input type='text' class='form-control' id='bearbeitungsschritt' aria-describedby='bearbeitungsschritt' placeholder='' value=0>");
				  
						echo("<label for='bauteilStatus'>bauteilStatus</label>");
						echo("<input type='text' class='form-control' id='verwendungsZweck' aria-describedby='verwendungsZweck' placeholder='' value=0>");
			  		}
			  		

		  
				
		  foreach($jsonbauteilverwendung['bauteilVerwendung'] as $bauteilverwendung)
				{
				// Neues Bauteil
			  	if( $bauteilverwendung['bauteileID'] == $q)
					{
						
						
					

					}

		  
				};
           
echo <<<FOOTER
		</div>
<button type="button" class="btn btn-primary" onclick="saveBauteilVerwendung('data')"> Speichern</button>
<input type="button" value="Zurück" onclick="window.location.href='usercontent.html'" />
	      </form>
    </div>
  </div>
</div>
</div>
</div>

FOOTER;
?>
