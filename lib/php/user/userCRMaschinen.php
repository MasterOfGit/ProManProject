<?php
echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
echo "Abfragenummer : "  . $q . "<br>";
echo "phpDateiName : "  . __FILE__ . "<br>";

?>

<div class"detailbereich">
  <div class="jumbotron">
    <div class="container-fluid">
      <div class="row">
        <h1>Detailbereich</h1>
        <div class="col-sm-3">
          <lable for="inventar">Inventarnummer : 94051562</lable>
        </div>
        <div class="col-sm-3">
          <lable for="hersteller">Hersteller: Scherer</lable>
        </div>
        <div class="col-sm-3">
          <lable for="Technologie">Technologhie: Drehen</lable>
        </div>
        <div class="col-sm-3">
          <lable for="status">Status:</lable>
          <select name="status">
            <option value="volvo">Produktion</option>
            <option value="saab">Umbau</option>
            <option value="fiat">Wartung</option>
            <option value="audi">Reperatur</option>
          </select>
          <button type="button">status ändern</button>
        </div>
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
        <div class="row">
          <div class="col-sm-2"><button> <a href="#" data-toggle="popover" title="Popover Header" data-content="Some content inside the popover">Toggle popover</a>Ansprechpartner kontaktieren</button></div>
          <div class="col-sm-2"><button>Werk:<br>Kassel</button></div>
          <div class="col-sm-2"><button>Halle:<br>12a</button></div>
          <div class="col-sm-2"><button>Ort:<br>Feld C4</button></div>
          <div class="col-sm-4"><button>Aktuelle Schicht:  <br>A3</button></div>
        </div>
      </div>
    </div>
  </div>
</div>
<div class"detailbereich">
  <div class="jumbotron">
    <div class="container-fluid">
      <div class="row">
        <h1>Detailbereich</h1>
        <div class="col-sm-3">
          <lable for="inventar">Inventarnummer : 94051562</lable>
        </div>
        <div class="col-sm-3">
          <lable for="hersteller">Hersteller: Scherer</lable>
        </div>
        <div class="col-sm-3">
          <lable for="Technologie">Technologhie: Drehen</lable>
        </div>
        <div class="col-sm-3">
          <lable for="status">Status:</lable>
          <select name="status">
            <option value="volvo">Produktion</option>
            <option value="saab">Umbau</option>
            <option value="fiat">Wartung</option>
            <option value="audi">Reperatur</option>
          </select>
          <button type="button">status ändern</button>
        </div>
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
        <div class="row">
          <div class="col-sm-2"><button>Ansprechpartner kontaktieren</button></div>
          <div class="col-sm-2"><button>Werk:<br>Kassel</button></div>
          <div class="col-sm-2"><button>Halle:<br>12a</button></div>
          <div class="col-sm-2"><button>Ort:<br>Feld C4</button></div>
          <div class="col-sm-4"><button>Aktuelle Schicht:  <br>A3</button></div>
        </div>
      </div>
    </div>
  </div>
</div>
<div class"detailbereich">
  <div class="jumbotron">
    <div class="container-fluid">
      <div class="row">
        <h1>Detailbereich</h1>
        <div class="col-sm-3">
          <lable for="inventar">Inventarnummer : 94051562</lable>
        </div>
        <div class="col-sm-3">
          <lable for="hersteller">Hersteller: Scherer</lable>
        </div>
        <div class="col-sm-3">
          <lable for="Technologie">Technologhie: Drehen</lable>
        </div>
        <div class="col-sm-3">
          <lable for="status">Status:</lable>
          <select name="status">
            <option value="volvo">Produktion</option>
            <option value="saab">Umbau</option>
            <option value="fiat">Wartung</option>
            <option value="audi">Reperatur</option>
          </select>
          <button type="button">status ändern</button>
        </div>
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
        <div class="row">
          <div class="col-sm-2"><button>Ansprechpartner kontaktieren</button></div>
          <div class="col-sm-2"><button>Werk:<br>Kassel</button></div>
          <div class="col-sm-2"><button>Halle:<br>12a</button></div>
          <div class="col-sm-2"><button>Ort:<br>Feld C4</button></div>
          <div class="col-sm-4"><button>Aktuelle Schicht:  <br>A3</button></div>
        </div>
      </div>
    </div>
  </div>
</div>
