<!--
Ersteller : Markus Kessler	
MatrNr 	  : 894361
Presentation: 28.04.2018
Team : ProMan
modifikations : Sebastian Molkenthin
MartNr : 896734
-->
<?php

$ch1 = curl_init();


curl_setopt($ch1, CURLOPT_URL, "http://zoomnation.selfhost.eu:8080/ProManAPI/api/addgetdeleteobject/?type=FertigungType");
//curl_setopt($ch1, CURLOPT_URL, "http://localhost:50435/api/addgetdeleteobject/?type=FertigungType");
//curl_setopt( $ch1, CURLOPT_URL,"http://zoomnation.selfhost.eu/jsonData/fertigungslinien/fertigungslinien.json" );
curl_setopt( $ch1, CURLOPT_HEADER, 0 );
curl_setopt( $ch1, CURLOPT_RETURNTRANSFER, true );
$fertigungstypes = curl_exec( $ch1 );
curl_close( $ch1 );

// Testausgabe
//echo($maschinen);

// Unwandlung von json in Array	
$jsonfertigungstypes = json_decode($fertigungstypes, TRUE);

echo($jsonfertigungstypes);

echo <<<HEADER

<script>
function createData()
{
		var data = JSON.stringify(
		{
	
      "fertigungslinienname"	:	$("#fertigungslinienname").val(),
      
      "fertigungstyp"	:	$("#fertigungstyp").val(),

      //"fertigungsname"	:	$("#fertigungsname").val(),

		}
        );
    

    createFertigungslinie(data);

		
};
</script>



<div class="fertigunglinieerstellen">
  <div class="jumbotron">
    <div class="jumbotron">
	 <div class="row">
      <div class="col-md-6 col-md-offset-3">
      <form>
        <div class="form-group">
         
HEADER;
		
echo("<label for='fertigungslinienname'>fertigungslinienname</label>");
echo("<input type='text' class='form-control' id='fertigungslinienname' aria-describedby='fertigungslinienname' placeholder='' value=>");
echo("<label for='fertigungstyp'>fertigungstyp</label>");
echo("<select id='fertigungstyp' name='fertigungstyp' aria-describedby='fertigungstyp' class='form-control'>");
  foreach($jsonfertigungstypes as $fertigungtypeitem) 
  {
    echo("<option value={$fertigungtypeitem['Key']}>{$fertigungtypeitem['Value']}</option>");
  };
echo("</select>");

//echo("<input type='text' class='form-control' id='fertigungstyp' aria-describedby='fertigungstyp' placeholder='' value=>");
//echo("<label for='fertigungsname'>fertigungsname</label>");
//echo("<input type='text' class='form-control' id='fertigungsname' aria-describedby='fertigungsname' placeholder='' value=>");

echo <<<FOOTER
		</div>
<button class='btn btn-primary' type="button" class="btn btn-primary" onclick="createData();">Speichern</button>
<input class='btn btn-primary' type="button" value="Zurück" onclick="window.location.href='usercontent.html'" />
	      </form>
    </div>
  </div>
</div>
</div>
</div>

FOOTER;
?>

	



