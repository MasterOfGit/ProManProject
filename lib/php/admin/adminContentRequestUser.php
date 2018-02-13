<?php
echo "PHP Datenabfrage<br>";
$q = $_REQUEST["q"];
echo "Anfrage : "  . $q . "<br>";

?>

<div class="User">
  <div class="jumbotron">
    <div class="container">
      <h2>Usermenü</h2>
      <br>
      <!-- Nav tabs -->
      <ul class="nav nav-tabs" role="tablist">
        <li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#home30">Registrierte User</a>&nbsp;</li>
        <li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu31">Registrierungsanfragen</a></li>
        <li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#menu32">Nachichten</a> </li>
      </ul>
      
      <!-- Tab panes -->
      <div class="tab-content">
        <div id="home30" class="container tab-pane active"><br>
          <h3>Alle User</h3>
          <form class="form-inline" action="/action_page.php">
            <input class="form-control mr-sm-2" type="text" placeholder="Search">
            <button class="btn btn-success" type="submit">Search</button>
          </form>
          <div class="table-responsive-sm">
            <table class="table">
              <thead>
                <tr>
                  <th>UserID</th>
                  <th>Vorname</th>
                  <th>Nachname</th>
                  <th>eMail</th>
                  <th>Telefon</th>
                  <th>Aktiv</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>dvc1278</td>
                  <td>Anna</td>
                  <td>Pitt</td>
                  <td>anna.Pitt@proman.de</td>
                  <td>0561/12535</td>
                  <td><input class="form-check-input" type="checkbox" value="" id="defaultCheck2" disabled></td>
                  <td><input type="button" value="Bearbeiten"></td>
                </tr>
                <tr>
                  <td>dvc2222</td>
                  <td>Peter</td>
                  <td>Müller</td>
                  <td>peter.mueller@proman.de</td>
                  <td>0561/884455</td>
                  <td><input class="form-check-input" type="checkbox" checked value="" id="defaultCheck5" disabled></td>
                  <td><input type="button" value="Bearbeiten"></td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
        <div id="menu31" class="container tab-pane fade"><br>
          <h3>Login Anfragen</h3>
          <div class="table-responsive-sm">
            <table class="table">
              <thead>
                <tr>
                  <th>UserID</th>
                  <th>Vorname</th>
                  <th>Nachname</th>
                  <th>eMail</th>
                  <th>Telefon</th>
                  <th></th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>none</td>
                  <td>Michael</td>
                  <td>Pittler</td>
                  <td>Michael.Pittler@proman.de</td>
                  <td>0561/88899</td>
                  <td><input type="button" value="Bearbeiten"></td>
                </tr>
                <tr>
                  <td>dvc87899</td>
                  <td>Uwe</td>
                  <td>Neu</td>
                  <td>uwe.neu@proman.de</td>
                  <td>0561/7777</td>
                  <td><input type="button" value="Bearbeiten"></td>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
        <div id="menu32" class="container tab-pane fade"><br>
          <h3>Nachichten</h3>
          <div class="table-responsive-sm">
            <table class="table">
              <thead>
                <tr>
                  <th>UserID</th>
                  <th>Firstname</th>
                  <th>Lastname</th>
                  <th>Aktiv</th>
                  <th></th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>dvc1278</td>
                  <td>Anna</td>
                  <td>Pitt</td>
                  <td><input class="form-check-input" type="checkbox" checked value="" id="defaultCheck2" disabled></td>
                  <th><button>Nachicht ansehen</button></th>
                </tr>
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>