<?php
echo("PHP Datenabfrage");
$q = $_REQUEST["q"];
echo "Anfrage : "  . $q;

?>

<div class="container-fluid">
  <div class="container-fluid">
    <div class="container-fluid">
      <div class="jumbotron">

        <div class="container-fluid">
            <div class="row">
              <h1>Bereichsübersicht</h1>
              <div class="row">
                  <div class="col-sm-4">
                      <lable for="linienname">Grünfertigung</lable>
                  </div>
                  <div class="col-sm-4">
                       <lable for="linienname">Festrad 3:</lable>
                  </div>
                 <div class="col-sm-4">
                   <lable for="verfügbarkeit">Linienverfügbarkeit:</lable>
                   <div id="verfügbarkeit">
                          <div class="progress-bar" role="progressbar" style="width: 25%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">25%</div>
                   </div>
                 </div>
              </div>
              <div class="row">
                  <div class="col-sm-6">
                  <lable for="a1">Informationen:</lable>      
                  <ul id="a1" class="list-group">
                      <li class="list-group-item d-flex justify-content-between align-items-center">
                        Teilenummer
                        <span class="badge badge-primary badge-pill"><a href="../txt/inArbeit.html" style="color:white">1</a></span>
                      </li>
                      <li class="list-group-item d-flex justify-content-between align-items-center">
                        Stückzahl
                        <span class="badge badge-primary badge-pill">Soll: 450</span>
                        <span class="badge badge-primary badge-pill">Ist: 450</span>  
                      </li>
                      <li class="list-group-item d-flex justify-content-between align-items-center">offene Umbauten<span class="badge badge-primary badge-pill">Soll: 1</span>
                        <span class="badge badge-primary badge-pill">Ist: 1</span> </li>
                  </ul>
                </div>
                  <div class="col-sm-6">
                  <lable for="aufgaben">Aufgaben:</lable>      
                  <ul id="aufgaben" class="list-group">
                      <li class="list-group-item d-flex justify-content-between align-items-center">
                        Reperaturen
                        <span class="badge badge-primary badge-pill">2</span>
                      </li>
                      <li class="list-group-item d-flex justify-content-between align-items-center">
                        Wartungen
                        <span class="badge badge-primary badge-pill">4</span>
                      </li>
                      <li class="list-group-item d-flex justify-content-between align-items-center">
                        Audits
                        <span class="badge badge-primary badge-pill">1</span>
                      </li>
                    </ul>
                  </div>
                
                
                  
              <div class="row">
                  <div class="row">
                      <div class="col-sm-2">Tel.0561/12345</div>
                      <div class="col-sm-2">Werk Kassel</div>
                      <div class="col-sm-2">Halle 12</div>
                      <div class="col-sm-2">Feld c4-g17</div>
                      <div class="col-sm-4">Aktuelle Schicht A3</div>
                </div>
              </div>
              </div> 
            </div>
                        
</div>
		  
<br>
<br>
		  
		  
		  
<div class="container-fluid">
  <div class="container-fluid">
    <div class="container-fluid">
      <div class="jumbotron">

        <div class="container-fluid">
            <div class="row">
              <h1>Bereichsübersicht</h1>
              <div class="row">
                  <div class="col-sm-4">
                      <lable for="linienname">Grünfertigung</lable>
                  </div>
                  <div class="col-sm-4">
                       <lable for="linienname">Festrad 3:</lable>
                  </div>
                 <div class="col-sm-4">
                   <lable for="verfügbarkeit">Linienverfügbarkeit:</lable>
                   <div id="verfügbarkeit">
                          <div class="progress-bar" role="progressbar" style="width: 25%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">25%</div>
                   </div>
                 </div>
              </div>
              <div class="row">
                  <div class="col-sm-6">
                  <lable for="a1">Informationen:</lable>      
                  <ul id="a1" class="list-group">
                      <li class="list-group-item d-flex justify-content-between align-items-center">
                        Teilenummer
                        <span class="badge badge-primary badge-pill"><a href="../txt/inArbeit.html" style="color:white">1</a></span>
                      </li>
                      <li class="list-group-item d-flex justify-content-between align-items-center">
                        Stückzahl
                        <span class="badge badge-primary badge-pill">Soll: 450</span>
                        <span class="badge badge-primary badge-pill">Ist: 450</span>  
                      </li>
                      <li class="list-group-item d-flex justify-content-between align-items-center">offene Umbauten<span class="badge badge-primary badge-pill">Soll: 1</span>
                        <span class="badge badge-primary badge-pill">Ist: 1</span> </li>
                  </ul>
                </div>
                  <div class="col-sm-6">
                  <lable for="aufgaben">Aufgaben:</lable>      
                  <ul id="aufgaben" class="list-group">
                      <li class="list-group-item d-flex justify-content-between align-items-center">
                        Reperaturen
                        <span class="badge badge-primary badge-pill">2</span>
                      </li>
                      <li class="list-group-item d-flex justify-content-between align-items-center">
                        Wartungen
                        <span class="badge badge-primary badge-pill">4</span>
                      </li>
                      <li class="list-group-item d-flex justify-content-between align-items-center">
                        Audits
                        <span class="badge badge-primary badge-pill">1</span>
                      </li>
                    </ul>
                  </div>
                
                
                  
              <div class="row">
                  <div class="row">
                      <div class="col-sm-2">Tel.0561/12345</div>
                      <div class="col-sm-2">Werk Kassel</div>
                      <div class="col-sm-2">Halle 12</div>
                      <div class="col-sm-2">Feld c4-g17</div>
                      <div class="col-sm-4">Aktuelle Schicht A3</div>
                </div>
              </div>
              </div> 
            </div>
                        
</div>

