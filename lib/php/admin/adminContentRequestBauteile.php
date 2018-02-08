<?php
echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
echo "Anfrage : "  . $q . "<br>";

?>

<div class="bauteile">
  <div class="jumbotron">
    <div class="container">
      <h2>User</h2>
      <br>
      <!-- Nav tabs -->
      <ul class="nav nav-tabs" role="tablist">
        <li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#home">Alle Bauteile anzeigen</a> </li>
        <li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu1">Bauteil suchen</a> </li>
        <li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu2">Bauteil bearbeiten</a> </li>
      </ul>
      
      <!-- Tab panes -->
      <div class="tab-content">
        <div id="home" class="container tab-pane active"><br>
          <h3>Alle Bauteile anzeigen</h3>
          <div class="table-responsive-sm">
            <table class="table">
              <thead>
                <tr>
                  <th>#</th>
                  <th>Firstname</th>
                  <th>Lastname</th>
                  <th>Age</th>
                  <th>City</th>
                  <th>Country</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>1</td>
                  <td>Anna</td>
                  <td>Pitt</td>
                  <td>35</td>
                  <td>New York</td>
                  <td>USA</td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
        <div id="menu1" class="container tab-pane fade"><br>
          <h3>Bauteile suchen</h3>
          <form class="form-inline" action="/action_page.php">
            <input class="form-control mr-sm-2" type="text" placeholder="Search">
            <button class="btn btn-success" type="submit">Search</button>
          </form>
          <div class="table-responsive-sm">
            <table class="table">
              <thead>
                <tr>
                  <th>#</th>
                  <th>Firstname</th>
                  <th>Lastname</th>
                  <th>Age</th>
                  <th>City</th>
                  <th>Country</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>1</td>
                  <td>Anna</td>
                  <td>Pitt</td>
                  <td>35</td>
                  <td>New York</td>
                  <td>USA</td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
        <div id="menu2" class="container tab-pane fade"><br>
          <h3>Bauteile bearbeiten</h3>
          <div class="table-responsive-sm">
            <table class="table">
              <thead>
                <tr>
                  <th>#</th>
                  <th>Firstname</th>
                  <th>Lastname</th>
                  <th>ddd</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>1</td>
                  <td>Anna</td>
                  <td>Pitt</td>
                  <th><button>bearbeiten</button></th>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>
