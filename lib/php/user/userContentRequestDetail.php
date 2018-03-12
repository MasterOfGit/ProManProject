<?php
//echo "PHP Datenabfrage<br>";
//$q = $_REQUEST["q"];
//echo "Abfragenummer : "  . $q . "<br>";
//echo "phpDateiName : "  . __FILE__ . "<br>";


echo <<<DATA
<h1>Fertigungsübersicht</h1>

<div class"Fertigungslinie">
  <div class="jumbotron">
    <div class="container-fluid">
      <div class="row">
        <h2>Fertigungslinie_1</h2>
      </div>
	    <div class="row">
          <div class="col-sm-2">Ansprechpartner: 0561 555 111</div>
		  <div class="col-sm-2">Werk: Kassel</div>
          <div class="col-sm-2">Halle: 12a</div>
          <div class="col-sm-2">Ort: Feld C4</div>
          <div class="col-sm-4">Aktuelle Schicht: A3</div>
        </div>
		<div class="row">
		<br>
		</div>
      
      <div class="row">
        <div class="col-sm-6">
          <lable for="a1">Produktionsdaten:</lable>
          <ul id="a1" class="list-group">
            <li class="list-group-item d-flex justify-content-between align-items-center"> Aktuelle Teilenummer <span class="badge badge-primary badge-pill"><a href="../inArbeit.html" style="color:white">125 554 55 AC</a></span> </li>
            <li class="list-group-item d-flex justify-content-between align-items-center"> Aktuelle Stückzahl <span class="badge badge-primary badge-pill">Ist : 250</span> <span class="badge badge-primary badge-pill">Soll : 500</span></li>
            <li class="list-group-item d-flex justify-content-between align-items-center"> Nächste Teilnummer<span class="badge badge-primary badge-pill">125 554 55 AD</span> </li>
            <li class="list-group-item d-flex justify-content-between align-items-center"> Nächste Stückzahl<span class="badge badge-primary badge-pill">Soll 600</span></li>
          </ul>
        </div>
        <div class="row">
          <div class="col-sm-6">
            <lable for="aufgaben">Aufgaben in dieser Schicht:</lable>
            <ul id="aufgaben" class="list-group">
              <li class="list-group-item d-flex justify-content-between align-items-center"> Reperaturen <span class="badge badge-primary badge-pill">offene 0</span> </li>
              <li class="list-group-item d-flex justify-content-between align-items-center"> Wartungen <span class="badge badge-primary badge-pill">offene 5</span> </li>
            </ul>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-sm-6">
          <lable for="a1">Maschinendaten:</lable>
          <ul id="a1" class="list-group">
            <li class="list-group-item d-flex justify-content-between align-items-center"> Baujahr <span class="badge badge-primary badge-pill"><a href="../inArbeit.html" style="color:white">2010</a></span> </li>
            <li class="list-group-item d-flex justify-content-between align-items-center"> Garantie <span class="badge badge-primary badge-pill">bis 2012</span> </li>
            <li class="list-group-item d-flex justify-content-between align-items-center"> Sonderumbauten<span class="badge badge-primary badge-pill">1</span> </li>
            <li class="list-group-item d-flex justify-content-between align-items-center"> Zeichnungsnummer<span class="badge badge-primary badge-pill">as 5455 78a v1.1</span> </li>
          </ul>
        </div>
        <div class="row">
          <div class="col-sm-6">
            <lable for="aufgaben">Informationen:</lable>
            <ul id="aufgaben" class="list-group">
              <li class="list-group-item d-flex justify-content-between align-items-center"> Reperaturen 
				  <span class="badge badge-primary badge-info" style="background: blue">Historie 25</span>
				  <span class="badge badge-primary badge-pill" style="background: red">offene 2</span> 
				  <span class="badge badge-primary badge-pillstyle=" style="background: green">erledigt 2</span>
				
			</li>
              <li class="list-group-item d-flex justify-content-between align-items-center"> Wartungen 
			      <span class="badge badge-primary badge-info" style="background: blue">Historie 25</span>
			      <span class="badge badge-primary badge-pill">offene 2</span> 
				  <span class="badge badge-primary badge-pill">erledigt 2</span> 
				</li>
              <li class="list-group-item d-flex justify-content-between align-items-center"> Audits <span class="badge badge-primary badge-pill">offene 2</span> <span class="badge badge-primary badge-pill">erledigt 2</span> </li>
              <li class="list-group-item d-flex justify-content-between align-items-center"> Optimierrungen <span class="badge badge-primary badge-pill">offene 2</span> <span class="badge badge-primary badge-pill">erledigt 2</span> </li>
            </ul>
          </div>
        </div>
      </div>
      
      <div class="row">
	      <div class="col-sm-5">
          <lable for="status">Status einer Maschine dieser Fertigungslinie ändern:</lable>
		  <br>
          <select name="status">
            <option value="Produktion">Produktion</option>
            <option value="Umbau">Umbau</option>
            <option value="Wartung">Wartung</option>
            <option value="Reperatur">Reperatur</option>
          </select>
          <button type="button">Status ändern</button>
        </div>
		 <div class="col-sm-4">
          <lable for="status">Gesammtstatus dieser Fertigungslinie ändern:</lable>
		  <br>
          <select name="status">
            <option value="Produktion">Produktion</option>
            <option value="Umbau">Umbau</option>
            <option value="Wartung">Wartung</option>
            <option value="Reperatur">Reperatur</option>
          </select>
          <button type="button">Status ändern</button>
        </div>
	  </div>
    </div>
  </div>
</div>

DATA;
			  
			  
?>
